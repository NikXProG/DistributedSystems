using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace RGU.DistributedSystems.Labs.WPF.Presentation;

public sealed class InvokeDelegateCommandAction : TriggerAction<DependencyObject>
{
    /// <summary>
    ///
    /// </summary>
    public static readonly DependencyProperty CommandParameterProperty =
        DependencyProperty.Register("CommandParameter", typeof(object), typeof(InvokeDelegateCommandAction), null);

    /// <summary>
    ///
    /// </summary>
    public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
        "Command", typeof(ICommand), typeof(InvokeDelegateCommandAction), null);

    /// <summary>
    ///
    /// </summary>
    public static readonly DependencyProperty InvokeParameterProperty = DependencyProperty.Register(
        "InvokeParameter", typeof(object), typeof(InvokeDelegateCommandAction), null);

    private string _commandName;

    /// <summary>
    ///
    /// </summary>
    public object InvokeParameter
    {
        get
        {
            return this.GetValue(InvokeParameterProperty);
        }
        set
        {
            this.SetValue(InvokeParameterProperty, value);
        }
    }

    /// <summary>
    ///
    /// </summary>
    public ICommand Command
    {
        get
        {
            return (ICommand)this.GetValue(CommandProperty);
        }
        set
        {
            this.SetValue(CommandProperty, value);
        }
    }

    /// <summary>
    ///
    /// </summary>
    public string CommandName
    {
        get => this._commandName;
        set
        {
            if (this.CommandName != value)
            {
                this._commandName = value;
            }
        }
    }

    /// <summary>
    ///
    /// </summary>
    public object CommandParameter
    {
        get
        {
            return this.GetValue(CommandParameterProperty);
        }
        set
        {
            this.SetValue(CommandParameterProperty, value);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="parameter"></param>
    protected override void Invoke(object parameter)
    {
        this.InvokeParameter = parameter;
       
        if (this.AssociatedObject != null)
        {
            ICommand command = this.ResolveCommand();
            if ((command != null) && command.CanExecute(this.CommandParameter))
            {
                command.Execute(this.CommandParameter);
            }
        }
    }

    private ICommand ResolveCommand()
    {
        ICommand command = null;
        
        if (this.Command != null)
        {
            return this.Command;
        }

        if (this.AssociatedObject is FrameworkElement frameworkElement)
        {
            object dataContext = frameworkElement.DataContext;
            if (dataContext != null)
            {
                PropertyInfo? commandPropertyInfo = dataContext
                    .GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .FirstOrDefault(
                        p =>
                        typeof(ICommand).IsAssignableFrom(p.PropertyType) &&
                        string.Equals(p.Name, this.CommandName, StringComparison.Ordinal)
                    );

                if (commandPropertyInfo != null)
                {
                    command = (ICommand)commandPropertyInfo.GetValue(dataContext, null)!;
                }
            }
        }
        return command;
    }
}
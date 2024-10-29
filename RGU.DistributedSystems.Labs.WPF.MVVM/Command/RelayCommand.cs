using System.Windows.Input;
 
namespace RGU.DistributedSystems.Labs.WPF.MVVM.Command;

public class RelayCommand:
    ICommand
{
    
    #region Fields
    
    /// <summary>
    /// Action delegate object that invokes the command
    /// </summary>
    private readonly Action<object?> _execute;
    
    /// <summary>
    /// checks whether the command can be executed
    /// </summary>
    private readonly Predicate<object?>? _canExecute;

    #endregion
    
    /// <summary>
    /// a constructor RelayCommand that checks and executes a command
    /// </summary>
    /// <param name="execute"></param>
    /// <param name="canExecute"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public RelayCommand(
        Action<object?> execute,
        Predicate<object?>? canExecute = null)
    {
        _canExecute = canExecute;
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
    }
    
    #region System.Windows.Input.ICommand implementation
    
    /// <inheritdoc cref="ICommand.CanExecute" />
    public bool CanExecute(
        object? parameter)
    {
        return _canExecute?.Invoke(parameter) ?? true;
    }
    
    /// <inheritdoc cref="ICommand.Execute" />
    public void Execute(
        object? parameter)
    {
        _execute(parameter);
    }
    
    /// <inheritdoc cref="ICommand.CanExecuteChanged" />
    public event EventHandler? CanExecuteChanged
    {
        add =>
            CommandManager.RequerySuggested += value;

        remove =>
            CommandManager.RequerySuggested -= value;
    }

    #endregion

}

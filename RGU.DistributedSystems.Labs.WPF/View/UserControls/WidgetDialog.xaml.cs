using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class WidgetDialog : UserControl
{
    public WidgetDialog()
    {
        InitializeComponent();
    }
    
    
    public ICommand ButtonCommand
    {
        get => (ICommand)GetValue(ButtonCommandProperty);
        set => SetValue(ButtonCommandProperty, value);
    }

    public static readonly DependencyProperty ButtonCommandProperty = DependencyProperty.Register(
        nameof(ButtonCommand),
        typeof(ICommand),
        typeof(WidgetDialog));


}
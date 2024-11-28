using System.Windows;
using System.Windows.Controls;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class DdMenu : UserControl
{
    public DdMenu()
    {
        InitializeComponent();
    }
    
    public bool IsOpen
    {
        get =>
            (bool)GetValue(IsOpenProperty);
        
        set =>
            SetValue(IsOpenProperty, value);
    }
    

    public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register(
        nameof(IsOpen),
        typeof(bool), 
        typeof(DdMenu));

    
}
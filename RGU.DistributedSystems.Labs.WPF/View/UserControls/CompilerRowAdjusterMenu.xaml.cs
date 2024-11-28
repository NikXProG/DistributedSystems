using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class CompilerRowAdjusterMenu : UserControl
{
    public CompilerRowAdjusterMenu()
    {
        InitializeComponent();
    }
    
    
    
    
    public static readonly DependencyProperty RowValueProperty = DependencyProperty.Register(
        nameof(RowValue),
        typeof(int), 
        typeof(CompilerRowAdjusterMenu), new PropertyMetadata(0, null, RowValueCoerceCallback));
    
    public int RowValue
    {
        get => (int)GetValue(RowValueProperty);
        set => SetValue(RowValueProperty, value);
    }

    private static object RowValueCoerceCallback(DependencyObject d, object baseValue)
    {
        return baseValue is int and > 0 ? baseValue : 0;
    }
    
    public static readonly DependencyProperty UpValueCommandProperty = DependencyProperty.Register(
        nameof(UpValueCommand), 
        typeof(ICommand),
        typeof(CompilerRowAdjusterMenu));
    
    public ICommand UpValueCommand
    {
        get => (ICommand)GetValue(UpValueCommandProperty);
        set => SetValue(UpValueCommandProperty, value);
    }
    
    public static readonly DependencyProperty DownValueCommandProperty = DependencyProperty.Register(
        nameof(DownValueCommand),
        typeof(ICommand),
        typeof(CompilerRowAdjusterMenu));
    
    public ICommand DownValueCommand
    {
        get => (ICommand)GetValue(DownValueCommandProperty);
        set => SetValue(DownValueCommandProperty, value);
    }
    
}
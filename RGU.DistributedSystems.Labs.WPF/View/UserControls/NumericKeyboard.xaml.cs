using System.Windows;
using System.Windows.Controls;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class NumericKeyboard : UserControl
{
    public NumericKeyboard()
    {
        InitializeComponent();
    }
    
    public Thickness ColumnSpacing
    {
        get => (Thickness)GetValue(ColumnSpacingProperty );
        set => SetValue(ColumnSpacingProperty, value);
    }
    
    public static readonly DependencyProperty ColumnSpacingProperty = DependencyProperty.Register(
        nameof(ColumnSpacing),
        typeof(Thickness),
        typeof(NumericKeyboard),
        new PropertyMetadata(default(Thickness)));

    
    public double FontSizeKey
    {
        get => (double)GetValue(FontSizeKeyProperty );
        set => SetValue(FontSizeKeyProperty, value);
    }
    
    public static readonly DependencyProperty FontSizeKeyProperty = DependencyProperty.Register(
        nameof(FontSizeKey),
        typeof(double),
        typeof(NumericKeyboard),
        new FrameworkPropertyMetadata(0.0));
    
    public Thickness RowSpacing
    {
        get => (Thickness)GetValue(RowSpacingProperty );
        set => SetValue(RowSpacingProperty, value);
    }
    
    public static readonly DependencyProperty RowSpacingProperty = DependencyProperty.Register(
        nameof(RowSpacing),
        typeof(Thickness),
        typeof(NumericKeyboard));

    public Thickness KeyPadding
    {
        get => (Thickness)GetValue(KeyPaddingProperty );
        set => SetValue(KeyPaddingProperty, value);
    }
    
    public static readonly DependencyProperty KeyPaddingProperty = DependencyProperty.Register(
        nameof(KeyPadding),
        typeof(Thickness),
        typeof(NumericKeyboard));

    
}
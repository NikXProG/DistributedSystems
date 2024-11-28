using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DryIoc.ImTools;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class LetterKeyboard : UserControl
{
    
    public LetterKeyboard()
    {
        InitializeComponent();
    }
    
    #region Dependency Properties
    
    public Thickness ColumnSpacing
    {
        get => (Thickness)GetValue(ColumnSpacingProperty );
        set => SetValue(ColumnSpacingProperty, value);
    }
    
    public static readonly DependencyProperty ColumnSpacingProperty = DependencyProperty.Register(
        nameof(ColumnSpacing),
        typeof(Thickness),
        typeof(LetterKeyboard),
        new PropertyMetadata(default(Thickness)));

    
    public double FontSizeKey
    {
        get => (double)GetValue(FontSizeKeyProperty );
        set => SetValue(FontSizeKeyProperty, value);
    }
    
    public static readonly DependencyProperty FontSizeKeyProperty = DependencyProperty.Register(
        nameof(FontSizeKey),
        typeof(double),
        typeof(LetterKeyboard),
        new FrameworkPropertyMetadata(0.0));
    
    public Thickness RowSpacing
    {
        get => (Thickness)GetValue(RowSpacingProperty );
        set => SetValue(RowSpacingProperty, value);
    }
    
    public static readonly DependencyProperty RowSpacingProperty = DependencyProperty.Register(
        nameof(RowSpacing),
        typeof(Thickness),
        typeof(LetterKeyboard));

    public Thickness KeyPadding
    {
        get => (Thickness)GetValue(KeyPaddingProperty );
        set => SetValue(KeyPaddingProperty, value);
    }
    
    public static readonly DependencyProperty KeyPaddingProperty = DependencyProperty.Register(
        nameof(KeyPadding),
        typeof(Thickness),
        typeof(LetterKeyboard));
    
    
    public Brush BackgroundKey
    {
        get => (Brush)GetValue(BackgroundKeyProperty );
        set => SetValue(BackgroundKeyProperty, value);
    }
    
    public static readonly DependencyProperty BackgroundKeyProperty = DependencyProperty.Register(
        nameof(BackgroundKey),
        typeof(Brush),
        typeof(LetterKeyboard));
    
    public Brush ForegroundKey
    {
        get => (Brush)GetValue(ForegroundKeyProperty );
        set => SetValue(ForegroundKeyProperty, value);
    }
    
    public static readonly DependencyProperty ForegroundKeyProperty = DependencyProperty.Register(
        nameof(ForegroundKey),
        typeof(Brush),
        typeof(LetterKeyboard));
    
    #endregion
    
}
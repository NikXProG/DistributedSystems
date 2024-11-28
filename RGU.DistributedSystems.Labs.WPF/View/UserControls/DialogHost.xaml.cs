using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;


//для замены cвойства content надо юзать атрибуты
[ContentProperty("InnerContent")]

public partial class DialogHost : UserControl
{
    public DialogHost()
    {
        InitializeComponent();
    }
    
    public double OpacityBackground
    {
        get =>
            (double)GetValue(   OpacityBackgroundProperty);
        
        set =>
            SetValue(  OpacityBackgroundProperty, value);
    }
    
    public Thickness MarginContent
    {
        get =>
            (Thickness)GetValue(MarginContentProperty);
        
        set =>
            SetValue(  MarginContentProperty, value);
    }

  
    public CornerRadius CornerRadiusBackground
    {
        get =>
            (CornerRadius)GetValue( CornerRadiusBackgroundProperty);
        
        set =>
            SetValue( CornerRadiusBackgroundProperty, value);
    }
    
    public CornerRadius CornerRadiusForeground
    {
        get =>
            (CornerRadius)GetValue( CornerRadiusForegroundProperty);
        set =>
            SetValue( CornerRadiusForegroundProperty, value);
    }
    
    public SolidColorBrush BackgroundColor
    {
        get =>
            (SolidColorBrush)GetValue( BackgroundColorProperty);
        
        set =>
            SetValue( BackgroundColorProperty, value);
    }
    
    public object InnerContent
    {
        get => (object)GetValue(InnerContentProperty); 
        set =>  SetValue(InnerContentProperty, value); 
    }
    
    public static readonly DependencyProperty CornerRadiusBackgroundProperty = 
        DependencyProperty.Register(nameof(CornerRadiusBackground), typeof(CornerRadius), 
            typeof(DialogHost), new PropertyMetadata(new CornerRadius(0.0)));
    
     public static readonly DependencyProperty CornerRadiusForegroundProperty = 
         DependencyProperty.Register(nameof(CornerRadiusForeground), typeof(CornerRadius), 
             typeof(DialogHost), new PropertyMetadata(new CornerRadius(0.0)));
    
     public static readonly DependencyProperty BackgroundColorProperty = 
         DependencyProperty.Register(nameof(BackgroundColor), typeof(SolidColorBrush), 
             typeof(DialogHost), new PropertyMetadata(Brushes.White));
     
     public static readonly DependencyProperty MarginContentProperty = 
         DependencyProperty.Register(nameof(MarginContent), typeof(Thickness), 
             typeof(DialogHost), new PropertyMetadata(default(Thickness)));
     
    public static readonly DependencyProperty OpacityBackgroundProperty = 
        DependencyProperty.Register(nameof(Opacity), typeof(double), 
            typeof(DialogHost), new PropertyMetadata(0.4));
    
    public static readonly DependencyProperty InnerContentProperty =
        DependencyProperty.Register(nameof(InnerContent), typeof(object), typeof(DialogHost));



    
    
}
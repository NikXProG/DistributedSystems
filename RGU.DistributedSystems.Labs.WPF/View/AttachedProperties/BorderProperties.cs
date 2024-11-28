using System.Windows;

namespace RGU.DistributedSystems.Labs.WPF.View.AttachedProperties;

public class Border
{
        
    #region Dependency Properties
    
    public static readonly DependencyProperty RadiusCoefficientProperty =
        DependencyProperty.RegisterAttached(
            "RadiusCoefficient",
            typeof(double),
            typeof(Border),
            new FrameworkPropertyMetadata(default(double), FrameworkPropertyMetadataOptions.Inherits));
        
    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.RegisterAttached(
            nameof(CornerRadius),
            typeof(CornerRadius),
            typeof(Border),
            new FrameworkPropertyMetadata(new CornerRadius(0.0), FrameworkPropertyMetadataOptions.Inherits));

    
    public static readonly DependencyProperty ScaleMaskCoefficientProperty =
        DependencyProperty.RegisterAttached(
            "ScaleMaskCoefficient",
            typeof(double),
            typeof(Border),
            new FrameworkPropertyMetadata(default(double), FrameworkPropertyMetadataOptions.Inherits));

    public static readonly DependencyProperty OverlayMaskProperty =
        DependencyProperty.RegisterAttached(
            "OverlayMask",
            typeof(bool),
            typeof(Border),
            new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.Inherits));

    #endregion
    
    #region Methods
    
    public static double GetRadiusCoefficient(DependencyObject obj) => (double)obj.GetValue(RadiusCoefficientProperty);
    public static void SetRadiusCoefficient(DependencyObject obj,double value) => obj.SetValue(RadiusCoefficientProperty, value);

    public static CornerRadius GetCornerRadius(DependencyObject obj) => (CornerRadius)obj.GetValue(CornerRadiusProperty);
    public static void SetCornerRadius(DependencyObject obj,CornerRadius value) => obj.SetValue(CornerRadiusProperty, value);


    
    public static double GetScaleMaskCoefficient(DependencyObject obj) => (double)obj.GetValue(ScaleMaskCoefficientProperty);
    public static void SetScaleMaskCoefficient(DependencyObject obj,double value) => obj.SetValue(ScaleMaskCoefficientProperty, value);

    public static bool GetOverlayMask(DependencyObject obj) => (bool)obj.GetValue(OverlayMaskProperty);
    public static void SetOverlayMask(DependencyObject obj,bool value) => obj.SetValue(OverlayMaskProperty, value);

    
    #endregion

}
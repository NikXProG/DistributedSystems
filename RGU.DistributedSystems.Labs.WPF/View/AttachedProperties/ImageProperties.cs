using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RGU.DistributedSystems.Labs.WPF.View.AttachedProperties;

public static class Image
{    
    
    #region Dependency Properties
    
    public static readonly DependencyProperty ImageSourceProperty =
        DependencyProperty.RegisterAttached(
            nameof(ImageSource),
            typeof(ImageSource),
            typeof(Image),
            new FrameworkPropertyMetadata(default(ImageSource), FrameworkPropertyMetadataOptions.Inherits));
    
    public static readonly DependencyProperty UrlProperty =
        DependencyProperty.RegisterAttached(
            "Url",
            typeof(string),
            typeof(Image),
            new PropertyMetadata(string.Empty, OnUrlChanged));


    public static readonly DependencyProperty ScaleXProperty =
        DependencyProperty.RegisterAttached(
            nameof(ScaleTransform.ScaleX),
            typeof(double),
            typeof(Image),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.Inherits));
    
    public static readonly DependencyProperty ScaleYProperty =
        DependencyProperty.RegisterAttached(
            nameof(ScaleTransform.ScaleY),
            typeof(double),
            typeof(Image),
            new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.Inherits));
    

    public static readonly DependencyProperty AlignXProperty =
        DependencyProperty.RegisterAttached(
            "AlignX",
            typeof(HorizontalAlignment),
            typeof(Image),
            new FrameworkPropertyMetadata(default(HorizontalAlignment), FrameworkPropertyMetadataOptions.Inherits));
    
    public static readonly DependencyProperty AlignYProperty =
        DependencyProperty.RegisterAttached(
            "AlignY",
            typeof(VerticalAlignment),
            typeof(Image),
            new FrameworkPropertyMetadata(default(VerticalAlignment), FrameworkPropertyMetadataOptions.Inherits));

    #endregion
    
    #region Methods
    public static ImageSource GetImageSource(DependencyObject obj) => (ImageSource)obj.GetValue(ImageSourceProperty);
    public static void SetImageSource(DependencyObject obj, ImageSource value) => obj.SetValue(ImageSourceProperty, value);
    

    public static double GetScaleX(DependencyObject obj) => (double)obj.GetValue(ScaleXProperty);
    public static void SetScaleX(DependencyObject obj, double value) => obj.SetValue(ScaleXProperty, value);

    public static double GetScaleY(DependencyObject obj) => (double)obj.GetValue(ScaleYProperty);
    public static void SetScaleY(DependencyObject obj, double value) => obj.SetValue(ScaleYProperty, value);
    
    
    public static HorizontalAlignment GetAlignX(DependencyObject obj) => (HorizontalAlignment)obj.GetValue(AlignXProperty);
    public static void SetAlignX(DependencyObject obj, HorizontalAlignment value) => obj.SetValue(AlignXProperty, value);

    
    public static VerticalAlignment GetAlignY(DependencyObject obj) => (VerticalAlignment)obj.GetValue(AlignYProperty);
    public static void SetAlignY(DependencyObject obj, VerticalAlignment value) => obj.SetValue(AlignYProperty, value);

    
    public static void SetUrl(UIElement element, string value)
    {
        element.SetValue(UrlProperty, value);
    }

    public static string GetUrl(UIElement element)
    {
        return (string)element.GetValue(UrlProperty);
    }

     private static void OnUrlChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Button button)
        {
            if (e.NewValue is string url && !string.IsNullOrEmpty(url))
            {
                button.Click += (s, args) => OpenUrl(url);
            }
        }
    }

    private static void OpenUrl(string url)
    {
        if (!string.IsNullOrEmpty(url))
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }

    #endregion
    
}




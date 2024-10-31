namespace RGU.DistributedSystems.Labs.WPF.View.ControlProperties;

public class TextProperties
{
    // #region Dependency Properties
    //
    // public static readonly DependencyProperty TextProperty =
    //     DependencyProperty.RegisterAttached(
    //         nameof(ImageSource),
    //         typeof(ImageSource),
    //         typeof(Image),
    //         new FrameworkPropertyMetadata(default(ImageSource), FrameworkPropertyMetadataOptions.Inherits));
    //
    //
    // #endregion
    //
    // #region Methods
    //
    // public static ImageSource GetImageSource(DependencyObject obj) => (ImageSource)obj.GetValue(ImageSourceProperty);
    // public static void SetImageSource(DependencyObject obj, ImageSource value) => obj.SetValue(ImageSourceProperty, value);
    //
    //
    // #endregion
}









//
// public class ImageButton : Button
// {
//     #region Constructors
//     
//     static ImageButton()
//     {
//         DefaultStyleKeyProperty.OverrideMetadata(typeof (ImageButton),
//             new FrameworkPropertyMetadata(typeof (ImageButton)));
//     }
//     
//     #endregion
//     
//     #region Dependency Properties
//     
//     public static readonly DependencyProperty ScaleXProperty =
//         DependencyProperty.Register(nameof(ScaleX), typeof(double), typeof(ImageButton), new PropertyMetadata(1.0));
//         
//     public static readonly DependencyProperty ScaleYProperty =
//         DependencyProperty.Register(nameof(ScaleY), typeof(double), typeof(ImageButton), new PropertyMetadata(1.0));
//         
//     public static readonly DependencyProperty ImageSourceProperty =
//         DependencyProperty.Register(nameof(ImageSource), typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(default(ImageSource)));
//         
//     #endregion
//     
//     #region Properties
//     
//     public ImageSource ImageSource
//     {
//
//         get => (ImageSource)GetValue(ImageSourceProperty);
//         set => SetValue(ImageSourceProperty, value);
//     }
//     
//     public double ScaleX
//     {
//         get => (double)GetValue(ScaleXProperty);
//         set => SetValue(ScaleXProperty, value);
//     }
//
//     public double ScaleY
//     {
//         get => (double)GetValue(ScaleYProperty);
//         set => SetValue(ScaleYProperty, value);
//     }
//
//     #endregion
//     
//     #region Methods
//
//     private static object CoerceValueCallback(DependencyObject d, object imageSourceValue)
//     {
//         if (string.IsNullOrEmpty(imageSourceValue as string))
//             throw new ArgumentNullException(nameof(imageSourceValue), " cannot be null or empty.");
//         return imageSourceValue;
//     }
//     #endregion
//     
// }
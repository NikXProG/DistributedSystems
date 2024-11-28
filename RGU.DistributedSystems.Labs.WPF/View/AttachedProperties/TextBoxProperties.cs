using System.Windows;
using System.Windows.Controls;
using RGU.DistributedSystems.Labs.WPF.View.UserControls;

namespace RGU.DistributedSystems.Labs.WPF.View.AttachedProperties;

public class TextBox
{

    public static LetterKeyboard GetKeyboard(DependencyObject obj) => (LetterKeyboard)obj.GetValue(KeyboardProperty);
    public static void SetKeyboard(DependencyObject obj,LetterKeyboard value) => obj.SetValue(KeyboardProperty, value);
    
    public static readonly DependencyProperty KeyboardProperty =
        DependencyProperty.RegisterAttached(
            "Keyboard",
            typeof(LetterKeyboard),
            typeof(TextBox));
    
    
    
    public static string GetPlaceHolder(DependencyObject obj) => (string)obj.GetValue(PlaceHolderProperty);
    public static void SetPlaceHolder(DependencyObject obj,string value) => obj.SetValue(PlaceHolderProperty, value);

    
    public static readonly DependencyProperty PlaceHolderProperty =
        DependencyProperty.RegisterAttached(
            "PlaceHolder",
            typeof(string),
            typeof(TextBox));
    
    
}


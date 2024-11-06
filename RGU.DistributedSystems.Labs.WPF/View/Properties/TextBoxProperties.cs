using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RGU.DistributedSystems.Labs.WPF.View.UserControls;

namespace RGU.DistributedSystems.Labs.WPF.View.Properties;

public class AdvancedTextBox : TextBox
{
    
    public static LetterKeyboard GetKeyboard(DependencyObject obj) => (LetterKeyboard)obj.GetValue(KeyboardProperty);
    public static void SetKeyboard(DependencyObject obj,LetterKeyboard value) => obj.SetValue(KeyboardProperty, value);

    
    public static readonly DependencyProperty KeyboardProperty =
        DependencyProperty.RegisterAttached(
            "Keyboard",
            typeof(LetterKeyboard),
            typeof(AdvancedTextBox));
    
    
}


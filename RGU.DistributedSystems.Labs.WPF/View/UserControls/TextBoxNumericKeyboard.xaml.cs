using System.Windows;
using System.Windows.Controls;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class TextBoxNumericKeyboard : UserControl
{
    public TextBoxNumericKeyboard()
    {
        InitializeComponent();
    }


    #region  Dependency Properties

        public string TextValue
        {
            get => (string)GetValue(TextValueProperty);
            set => SetValue(TextValueProperty, value);
        }
        
        public static readonly DependencyProperty TextValueProperty =
            DependencyProperty.Register(nameof(TextValue),
                typeof(string), 
                typeof(TextBoxNumericKeyboard));

        
             
        public static readonly DependencyProperty ColumnSpacingKeyboardProperty = DependencyProperty.Register(
            nameof(ColumnSpacingKeyboard),
            typeof(Thickness),
            typeof(TextBoxNumericKeyboard));

    
        public Thickness ColumnSpacingKeyboard
        {
            get => (Thickness)GetValue(ColumnSpacingKeyboardProperty);
            set => SetValue(ColumnSpacingKeyboardProperty, value);
        }


    
        public Thickness RowSpacingKeyboard
        {
            get => (Thickness)GetValue(RowSpacingKeyboardProperty);
            set => SetValue(RowSpacingKeyboardProperty, value);
        }
    

        public static readonly DependencyProperty RowSpacingKeyboardProperty = DependencyProperty.Register(
            nameof(RowSpacingKeyboard),
            typeof(Thickness),
            typeof(TextBoxNumericKeyboard));
    
        public Thickness KeyPaddingKeyboard
        {
            get => (Thickness)GetValue(KeyPaddingKeyboardProperty);
            set => SetValue(KeyPaddingKeyboardProperty, value);
        }

        public static readonly DependencyProperty KeyPaddingKeyboardProperty = DependencyProperty.Register(
            nameof(KeyPaddingKeyboard),
            typeof(Thickness),
            typeof(TextBoxNumericKeyboard));
        




    #endregion
}
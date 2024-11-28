using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RGU.DistributedSystems.Labs.WPF.Converter;

using RGU.DistributedSystems.Labs.WPF.MVVM.Command;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;


namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class TextBoxLetterKeyboard : UserControl
{
    
    // public sealed class TextBoxKeyboardViewModel : ViewModelBase
    //
    // {
    //     
    //     #region Fields
    //     
    //     private StringBuilder _keyboardText;
    //     private bool _uppercase;
    //     private int _caretPosition;
    //     private string _selectedValue;
    //     
    //     private readonly Lazy<ICommand> _addCharacter;
    //     public  readonly Lazy<ICommand> _changeCasing;
    //     public  readonly Lazy<ICommand> _removeCharacter;
    //     public readonly Lazy<ICommand> _changeKeyboardType;
    //     public readonly Lazy<ICommand> _accept;
    //
    //     #endregion
    //     
    //     #region Constructors
    //     
    //         public TextBoxKeyboardViewModel(StringBuilder initialValue)
    //         {
    //             _keyboardText = initialValue;
    //             
    //
    //             _uppercase = false;
    //             CaretPosition = _keyboardText.Length;
    //             
    //             _addCharacter = new Lazy<ICommand>(() => 
    //                 new RelayCommand(AddCharacter));
    //             
    //             
    //         }
    //     
    //     #endregion
    //     
    //     #region Properties
    //     
    //         public StringBuilder KeyboardText {
    //             get => _keyboardText;
    //             set
    //             {
    //                 _keyboardText = value;
    //                 RaisePropertyChanged(nameof(KeyboardText));
    //                 
    //             }
    //         }
    //         
    //         public bool Uppercase
    //         {
    //             get => _uppercase;
    //             private set
    //             {
    //                 _uppercase = value;
    //                 RaisePropertyChanged(nameof(Uppercase));
    //             }
    //         }
    //         
    //       
    //         
    //         public int CaretPosition
    //         {
    //             get => _caretPosition;
    //             set
    //             {
    //                 if (value < 0) _caretPosition = 0;
    //                 else if (value > KeyboardText.Length) _caretPosition = KeyboardText.Length;
    //                 else _caretPosition = value;
    //                 RaisePropertyChanged(nameof(CaretPosition));
    //             }
    //         }
    //         
    //         public string SelectedValue
    //         {
    //             get => _selectedValue;
    //             set
    //             {
    //                 _selectedValue = value;
    //                 RaisePropertyChanged(nameof(SelectedValue));
    //             }
    //         }
    //         
    //     
    //     #endregion
    //     
    //     #region Command
    //     
    //     public ICommand AddCharacterCommand => _addCharacter.Value;
    //      
    //     #endregion
    //     
    //     #region Methods
    //
    //         private void RemoveSubstring(string substring)
    //         {
    //             
    //             var position = KeyboardText.IndexOf(substring);
    //             
    //             KeyboardText = KeyboardText.Remove(position, substring.Length);
    //         }
    //         
    //
    //
    //         private void AddCharacter(object? parameter)
    //         {
    //
    //
    //             if (parameter is not char character)
    //             {
    //                 throw new ArgumentException("Parameter must be of type char.", nameof(parameter));
    //             }
    //             
    //             if (Uppercase) character = Char.ToUpper(character);
    //             
    //             
    //             
    //             if (SelectedValue.Length != 0)
    //             {
    //                 RemoveSubstring(SelectedValue);
    //                 KeyboardText = KeyboardText.Insert(CaretPosition, character);
    //                 CaretPosition++;
    //                 SelectedValue = string.Empty;
    //             }
    //             else
    //             {
    //                 KeyboardText = KeyboardText.Insert(CaretPosition, character);
    //                 CaretPosition++;
    //             }
    //
    //
    //         }
    //
    //     #endregion
    //     
    // }
    
    
    public TextBoxLetterKeyboard()
    {
        InitializeComponent();
    }
    
    
    #region Dependency Properties
    
        
    public static readonly DependencyProperty KeyboardVisibileProperty = DependencyProperty.Register(
        nameof(KeyboardVisible),
        typeof(bool),
        typeof(TextBoxLetterKeyboard),
        new FrameworkPropertyMetadata(true)
    );
    
    public bool KeyboardVisible
    {
        get => (bool)GetValue(KeyboardVisibileProperty );
        set => SetValue(KeyboardVisibileProperty, value);
    }
    
    
    public static readonly DependencyProperty ForegroundKeyKeyboardProperty = DependencyProperty.Register(
        nameof(ForegroundKeyKeyboard),
        typeof(Brush),
        typeof(TextBoxLetterKeyboard));
    
    public Brush ForegroundKeyKeyboard
    {
        get => (Brush)GetValue(ForegroundKeyKeyboardProperty);
        set => SetValue(ForegroundKeyKeyboardProperty, value);
    }
    
    public static readonly DependencyProperty BackgroundKeyKeyboardProperty = DependencyProperty.Register(
        nameof(BackgroundKeyKeyboard),
        typeof(Brush),
        typeof(TextBoxLetterKeyboard));
    
    public Brush BackgroundKeyKeyboard
    {
        get => (Brush)GetValue(BackgroundKeyKeyboardProperty);
        set => SetValue(BackgroundKeyKeyboardProperty, value);
    }
    
        
    public static readonly DependencyProperty ColumnSpacingKeyboardProperty = DependencyProperty.Register(
        nameof(ColumnSpacingKeyboard),
        typeof(Thickness),
        typeof(TextBoxLetterKeyboard));

    
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
        typeof(TextBoxLetterKeyboard));
    
    public Thickness KeyPaddingKeyboard
    {
        get => (Thickness)GetValue(KeyPaddingKeyboardProperty);
        set => SetValue(KeyPaddingKeyboardProperty, value);
    }

    public static readonly DependencyProperty KeyPaddingKeyboardProperty = DependencyProperty.Register(
        nameof(KeyPaddingKeyboard),
        typeof(Thickness),
        typeof(TextBoxLetterKeyboard));

    
    public double FontSizeKeyKeyboard
    {
        get => (double)GetValue(FontSizeKeyboardProperty);
        set => SetValue(FontSizeKeyboardProperty, value);
    }
    

    public static readonly DependencyProperty FontSizeKeyboardProperty = DependencyProperty.Register(
        nameof(FontSizeKeyKeyboard),
        typeof(double),
        typeof(TextBoxLetterKeyboard));

    
    public string SelectedValue
    {
        get => (string)GetValue(SelectedValueProperty);
        set => SetValue(SelectedValueProperty, value);
    }
    
        
    public static readonly DependencyProperty SelectedValueProperty =
        DependencyProperty.Register( nameof(SelectedValue), 
            typeof(string),
            typeof(TextBoxLetterKeyboard));

    
    public string TextValue
    {
        get => (string)GetValue(TextValueProperty);
        set => SetValue(TextValueProperty, value);
    }
    
    public static readonly DependencyProperty TextValueProperty =
        DependencyProperty.Register(nameof(TextValue),
            typeof(string), 
            typeof(TextBoxLetterKeyboard));
    
    
    public int CaretPosition
    {
        get => (int)GetValue(CaretPositionProperty);
        set => SetValue(CaretPositionProperty, value);
    }
    
    public static readonly DependencyProperty CaretPositionProperty =
        DependencyProperty.Register(nameof(CaretPosition),
            typeof(int),
            typeof(TextBoxLetterKeyboard));
    

    #endregion
    
}
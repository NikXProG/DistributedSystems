using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RGU.DistributedSystems.Labs.WPF.Extensions;
using RGU.DistributedSystems.Labs.WPF.MVVM.Command;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;
using RGU.DistributedSystems.Labs.WPF.Types;
using RGU.DistributedSystems.Labs.WPF.View.UserControls.UserControlViewModel;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class TextBoxKeyboard : UserControl
{
    
    public sealed class TextBoxKeyboardViewModel : ViewModelBase
    
    {
        
        #region Fields
        
        private StringBuilder _keyboardText;
        private KeyboardType _keyboardType;
        private bool _uppercase;
        private int _caretPosition;
        private string _selectedValue;
        
        private readonly Lazy<ICommand> _addCharacter;
        public  readonly Lazy<ICommand> _changeCasing;
        public  readonly Lazy<ICommand> _removeCharacter;
        public readonly Lazy<ICommand> _changeKeyboardType;
        public readonly Lazy<ICommand> _accept;
    
        #endregion
        
        #region Constructors
        
            public TextBoxKeyboardViewModel(StringBuilder initialValue)
            {
                _keyboardText = initialValue;
                
                _keyboardType = KeyboardType.Alphabet;
                _uppercase = false;
                CaretPosition = _keyboardText.Length;
                
                _addCharacter = new Lazy<ICommand>(() => 
                    new RelayCommand(AddCharacter));
                
                
            }
        
        #endregion
        
        #region Properties
        
            public StringBuilder KeyboardText {
                get => _keyboardText;
                set
                {
                    _keyboardText = value;
                    RaisePropertyChanged(nameof(KeyboardText));
                    
                }
            }
            
            public bool Uppercase
            {
                get => _uppercase;
                private set
                {
                    _uppercase = value;
                    RaisePropertyChanged(nameof(Uppercase));
                }
            }
            
            public KeyboardType KeyboardType {
                get => _keyboardType; 
                private set
                {
                    _keyboardType = value;
                   RaisePropertyChanged(nameof(KeyboardType));
                }
            }
            public int CaretPosition
            {
                get => _caretPosition;
                set
                {
                    if (value < 0) _caretPosition = 0;
                    else if (value > KeyboardText.Length) _caretPosition = KeyboardText.Length;
                    else _caretPosition = value;
                    RaisePropertyChanged(nameof(CaretPosition));
                }
            }
            
            public string SelectedValue
            {
                get => _selectedValue;
                set
                {
                    _selectedValue = value;
                    RaisePropertyChanged(nameof(SelectedValue));
                }
            }
            
        
        #endregion
        
        #region Command
        
        public ICommand AddCharacterCommand => _addCharacter.Value;
         
        #endregion
        
        #region Methods

            private void RemoveSubstring(string substring)
            {
                
                var position = KeyboardText.IndexOf(substring);
                
                KeyboardText = KeyboardText.Remove(position, substring.Length);
            }
            


            private void AddCharacter(object? parameter)
            {


                if (parameter is not char character)
                {
                    throw new ArgumentException("Parameter must be of type char.", nameof(parameter));
                }
                
                if (Uppercase) character = Char.ToUpper(character);
                
                
                
                if (SelectedValue.Length != 0)
                {
                    RemoveSubstring(SelectedValue);
                    KeyboardText = KeyboardText.Insert(CaretPosition, character);
                    CaretPosition++;
                    SelectedValue = string.Empty;
                }
                else
                {
                    KeyboardText = KeyboardText.Insert(CaretPosition, character);
                    CaretPosition++;
                }


            }

        #endregion
        
        
    }
    
    public static readonly DependencyProperty SelectedValueProperty =
        DependencyProperty.Register( nameof(SelectedValue), 
            typeof(string),
            typeof(TextBoxKeyboard));
    
    public static readonly DependencyProperty CaretPositionProperty =
        DependencyProperty.Register(nameof(CaretPosition),
            typeof(int),
            typeof(TextBoxKeyboard));

    
    public static readonly DependencyProperty TextValueProperty =
        DependencyProperty.Register(nameof(TextValue),
            typeof(string), 
            typeof(TextBoxKeyboard));
    

    public TextBoxKeyboard()
    {
        InitializeComponent();
        Items = new ObservableCollection<TextBoxKeyboardViewModel>();
    }
    
    public string SelectedValue
    {
        get => (string)GetValue(SelectedValueProperty);
        set => SetValue(SelectedValueProperty, value);
    }
    
    public string TextValue
    {
        get => (string)GetValue(TextValueProperty);
        set => SetValue(TextValueProperty, value);
    }
    
    public int CaretPosition
    {
        get => (int)GetValue(CaretPositionProperty);
        set => SetValue(CaretPositionProperty, value);
    }
    

    
}
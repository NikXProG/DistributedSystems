using System.Text;
using System.Windows.Input;
using RGU.DistributedSystems.Labs.WPF.Extensions;
using RGU.DistributedSystems.Labs.WPF.MVVM.Command;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;
using RGU.DistributedSystems.Labs.WPF.Types;


namespace RGU.DistributedSystems.Labs.WPF.Extensions
{
    public static class StringBuilderExtensions
    {
        public static int IndexOf(
            this StringBuilder sb,
            string value,
            int startIndex = 0,
            bool ignoreCase = false)
        {
            int len = value.Length;
            int max = (sb.Length - len) + 1;
            
            var v1 = (ignoreCase)
                ? value.ToLower() : value;
            
            var func1 = (ignoreCase)
                ? new Func<char, char, bool>((x, y) => char.ToLower(x) == y)
                : new Func<char, char, bool>((x, y) => x == y);
            
            for (int i1 = startIndex; i1 < max; ++i1)
                if (func1(sb[i1], v1[0]))
                {
                    int i2 = 1;
                    while ((i2 < len) && func1(sb[i1 + i2], v1[i2]))
                        ++i2;
                    if (i2 == len)
                        return i1;
                }
            return -1;
            
            
        }
    }
}

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls.UserControlViewModel
{
        
    public class LetterKeyboardViewModel : ViewModelBase
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
        
            public LetterKeyboardViewModel(StringBuilder initialValue)
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
}

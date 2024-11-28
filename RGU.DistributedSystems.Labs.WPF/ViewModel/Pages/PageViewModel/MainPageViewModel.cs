using System.Dynamic;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Input;
using RGU.DistributedSystems.Labs.WPF.Converter;
using RGU.DistributedSystems.Labs.WPF.MVVM.Command;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;
using RGU.DistributedSystems.Labs.WPF.MVVM.Navigation;
using RGU.DistributedSystems.Labs.WPF.Utils;
namespace RGU.DistributedSystems.Labs.WPF.ViewModel.Pages.PageViewModel;

internal sealed class MainPageViewModel : PageViewModelBase
{
        
    
    #region Fields
    

    private string _textLetterKeyboardValue = "";
    private string _textNumericKeyboardValue = "****";
    private bool _uppercase = false;
    private bool _isRussianLanguage = false;
    
    private readonly Lazy<ICommand> _buttonClickNavigated;
    private readonly Lazy<ICommand> _addCharLetterKeyboard;
    private readonly Lazy<ICommand> _removeLetterCharKeyboard;
    private readonly Lazy<ICommand> _addCharNumericKeyboard;
    private readonly Lazy<ICommand> _removeNumericCharKeyboard;
    private readonly Lazy<ICommand> _capsLockKeyboard;
    private readonly Lazy<ICommand> _clearKeyKeyboard;
    private readonly Lazy<ICommand> _languageKeyKeyboard;
    
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="navigationManager"></param>
    public MainPageViewModel(NavigationManager navigationManager): base(navigationManager)
    {
        
        
        _buttonClickNavigated = new Lazy<ICommand>(() => 
            new RelayCommand(_ => ButtonNavigatedCompilerPage()));
        
        _addCharLetterKeyboard  = new Lazy<ICommand>(() => 
            new RelayCommand(InputCharLetterKeyboard));

        _removeLetterCharKeyboard = new Lazy<ICommand>(() => 
            new RelayCommand(RemoveCharLetterKeyboard));
        
        _capsLockKeyboard = new Lazy<ICommand>(() => 
            new RelayCommand(CapsLockChanged));
        
        _clearKeyKeyboard = new Lazy<ICommand>(() => 
            new RelayCommand(ClearTextValueKeyboard));
        
        _languageKeyKeyboard = new Lazy<ICommand>(() => 
            new RelayCommand(KeyboardLanguageChanged));
            
        _addCharNumericKeyboard  = new Lazy<ICommand>(() => 
            new RelayCommand(InputCharNumericKeyboard));

        _removeNumericCharKeyboard = new Lazy<ICommand>(() => 
            new RelayCommand(RemoveCharNumericKeyboard));
        
    }
    

    #endregion
    
    #region Properties
  
    
    public bool IsRussianLanguageEnabled {
        get => _isRussianLanguage; 
        private set
        {
            _isRussianLanguage = value;
            RaisePropertyChanged(nameof(IsRussianLanguageEnabled));
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
    
   
    
    public string TextLetterKeyboardValue
    {
        get => _textLetterKeyboardValue;
        set
        {
            _textLetterKeyboardValue = value;
            RaisePropertyChanged(nameof(TextLetterKeyboardValue));
        }
    }
    
    public string TextNumericKeyboardValue
    {
        get => _textNumericKeyboardValue;
        set
        {
            _textNumericKeyboardValue = value;
            RaisePropertyChanged(nameof(TextNumericKeyboardValue));
        }
    }
    
    
    
    #endregion
    
    #region Command
    
        public ICommand ButtonClickCommand => _buttonClickNavigated.Value;
        public ICommand InputKeyLetterCommand => _addCharLetterKeyboard.Value;
        public ICommand CapsLockKeyCommand => _capsLockKeyboard.Value;
        public ICommand RemoveKeyLetterCommand => _removeLetterCharKeyboard.Value;
        public ICommand ClearKeyCommand => _clearKeyKeyboard.Value;
        public ICommand LanguageKeyCommand => _languageKeyKeyboard.Value;
        public ICommand InputKeyNumericCommand => _addCharNumericKeyboard.Value;
        public ICommand RemoveKeyNumericCommand => _removeNumericCharKeyboard.Value;
        
    #endregion
    
    #region Methods
    
        private void ButtonNavigatedCompilerPage()
        {
            
            NavigationManager.Navigate(NavigationContext.Builder.Create()
                .From<MainPageViewModel>()
                .To<CompilerPageViewModel>()
                .Build());
                    
        }
    
        private void InputCharNumericKeyboard(object? parameter)
        {
                
            if (parameter is not string character)
            {
                throw new ArgumentException("Parameter must be of type string.", nameof(parameter));
            }
                
            if (character.Length  != 1)
            {
                throw new ArgumentException("Parameter must be a single character.", nameof(parameter));
            }
                
            TextNumericKeyboardValue += character;
                
        }

        private void RemoveCharNumericKeyboard(object? parameter)
        {
            if (parameter is not null)
            {
                throw new ArgumentException(
                    $"The {nameof(RemoveCharNumericKeyboard)} function must have no parameters."
                );
            }

            if (TextNumericKeyboardValue.Length > 0)
            {   
                TextNumericKeyboardValue = TextNumericKeyboardValue.Remove(TextNumericKeyboardValue.Length - 1);
            }
        }

        private void InputCharLetterKeyboard(object? parameter)
        {
            
            if (parameter is not string character)
            {
                throw new ArgumentException("Parameter must be of type string.", nameof(parameter));
            }
            
            if (character.Length  != 1)
            {
                throw new ArgumentException("Parameter must be a single character.", nameof(parameter));
            }
            
            
            if (Uppercase) character = character.ToUpper();
            
            TextLetterKeyboardValue += character;
            
        }

        private void KeyboardLanguageChanged(object? parameter)
        {
            if (parameter is not null)
            {
                throw new ArgumentException(
                    $"The {nameof(KeyboardLanguageChanged)} function must have no parameters."
                );
            }
            
            IsRussianLanguageEnabled = !IsRussianLanguageEnabled;

        }
        
        
        private void RemoveCharLetterKeyboard(object? parameter)
        {
            if (parameter is not null)
            {
                throw new ArgumentException(
                    $"The {nameof(RemoveCharLetterKeyboard)} function must have no parameters."
                );
            }

            if (TextLetterKeyboardValue.Length > 0)
            {   
                TextLetterKeyboardValue = TextLetterKeyboardValue.Remove(TextLetterKeyboardValue.Length - 1);
            }
        }
        
        private void CapsLockChanged(object? parameter)
        { 
            if (parameter is not null)
            {
                throw new ArgumentException(
                    $"The {nameof(CapsLockChanged)} function must have no parameters."
                );
            }

            Uppercase = !Uppercase;

        }
        
        private void ClearTextValueKeyboard(object? parameter)
        {
            if (parameter is not null)
            {
                throw new ArgumentException(
                    $"The {nameof(RemoveCharLetterKeyboard)} function must have no parameters."
                );
            }

            TextLetterKeyboardValue = string.Empty;
            
            
        }
         
    #endregion
    

    
}
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;
using RGU.DistributedSystems.Labs.WPF.Utils;
namespace RGU.DistributedSystems.Labs.WPF.ViewModel.Pages.PageViewModel;

internal sealed class MainPageViewModel : PageViewModelBase
{
        
    
    #region Fields
    
    private int _buttonFontSize = 18;
    private string _backgroundColor = "LightGreen";
    private string _foregroundColor = "White";
    
    #endregion
    
    
    #region Constructors
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="navigationManager"></param>
    public MainPageViewModel(NavigationManager navigationManager): base(navigationManager)
    {
        
        
        Task.Run(async () =>
        {
            await Task.Delay(10000);
            ButtonFontSize = 24;
            ButtonBackground = "White";
            ButtonForeground = "Black";
            
        });
        
        
    }
    
    
    #endregion
    
    #region Properties
    public int ButtonFontSize
    {
        get =>
            _buttonFontSize;

        set
        {
            _buttonFontSize = value;
            RaisePropertyChanged(nameof(ButtonFontSize));
        }
    }
    
    public string ButtonBackground
    {
        get => _backgroundColor;
        set
        {
            _backgroundColor = value;
            RaisePropertyChanged(nameof(ButtonBackground));
        }
    }
    
    public string ButtonForeground
    {
        get => _foregroundColor;
        set
        {
            _foregroundColor = value;
            RaisePropertyChanged(nameof(ButtonForeground));
        }
    }
    
    
    
    #endregion
  
    

    
    
}
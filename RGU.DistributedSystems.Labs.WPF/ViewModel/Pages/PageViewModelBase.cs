using RGU.DistributedSystems.Labs.WPF.MVVM.Navigation;
using RGU.DistributedSystems.Labs.WPF.Utils;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;

namespace RGU.DistributedSystems.Labs.WPF.ViewModel.Pages;

internal abstract class PageViewModelBase : ViewModelBase, INavigationAware
{
    #region Constructors
    
    protected PageViewModelBase (
        NavigationManager navigationManager)
    {
        NavigationManager = navigationManager ?? throw new ArgumentNullException(nameof(navigationManager));
    }
    
    #endregion
    
    #region Propeties
    
    protected NavigationManager NavigationManager
    {
        get;
    }
    
    #endregion
    
    #region Methods
    
    
    public virtual  void OnNavigatingFrom(NavigationContext navigationContext)
    {

    }

    public virtual  void OnNavigatedFrom(NavigationContext navigationContext)
    {
        
    }
    
    public virtual  void OnNavigatedTo(NavigationContext navigationContext)
    {
        
        
    }
    
    #endregion
}
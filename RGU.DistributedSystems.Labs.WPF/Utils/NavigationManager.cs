using System.Windows;
using System.Windows.Navigation;
using DryIoc;
using RGU.DistributedSystems.Labs.WPF.MVVM.Navigation;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;



namespace RGU.DistributedSystems.Labs.WPF.Utils;

public class NavigationManager
{
    #region Fields
    
    private NavigationService? _navigationService;
    
    private readonly Dictionary<Type, FrameworkElement> _viewTypeToViewMappings;
    
    private readonly IResolver _resolver;
    
    #endregion
    
    
    #region Constructors
    
    public NavigationManager()
    {
        _viewTypeToViewMappings = new Dictionary<Type, FrameworkElement>();
        _resolver = App.Container;
    }
    
    #endregion


    #region Properties

    public NavigationService NavigationService
    {
        set
        {
            if (_navigationService is not null)
            {
                throw new InvalidOperationException("Navigation service already set to the instance of navigation manager");
            }

            _navigationService = value;
        }
    }

    #endregion
    
    #region Methods
    
    public NavigationManager AddMapping<TView, TViewModel>()
        where TView:
        FrameworkElement
        where TViewModel:
        ViewModelBase
    {
        _viewTypeToViewMappings.Add(typeof(TViewModel), (_resolver.Resolve(typeof(TView)) as FrameworkElement)!);
        return this;
    }
    
    
    #endregion
}
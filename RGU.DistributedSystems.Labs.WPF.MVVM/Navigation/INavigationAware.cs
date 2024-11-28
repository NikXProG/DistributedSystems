namespace RGU.DistributedSystems.Labs.WPF.MVVM.Navigation;

public interface INavigationAware
{
    void OnNavigatingFrom(NavigationContext navigationContext);

    void OnNavigatedFrom(NavigationContext navigationContext);
    
    void OnNavigatedTo(NavigationContext navigationContext);

}
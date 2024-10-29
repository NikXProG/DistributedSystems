
using System.Windows;
using DryIoc;
using RGU.DistributedSystems.Labs.WPF.Utils;
using RGU.DistributedSystems.Labs.WPF.ViewModel;
using RGU.DistributedSystems.Labs.WPF.View.Pages;


namespace RGU.DistributedSystems.Labs.WPF.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// we get it out of the container and use MainWindowViewModel
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<MainWindowViewModel>();
        
        
    }
    
    #region Event Handlers
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainWindow_OnLoaded(
        object sender,
        RoutedEventArgs e)
    {
        App.Container.Resolve<NavigationManager>().NavigationService = _mainWindowMainFrame.NavigationService;
        _mainWindowMainFrame.Navigate(App.Container.Resolve<MainPage>());
    }
    
    
    
    #endregion

}
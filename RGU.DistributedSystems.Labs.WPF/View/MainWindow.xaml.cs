
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
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
        App.Container.Resolve<NavigationManager>().NavigationService = MainWindowMainFrame.NavigationService;
        MainWindowMainFrame.Navigate(App.Container.Resolve<MainPage>());
    }
    
    private void MainWindow_Closed(
        object sender,
        EventArgs e)
    {
        Close();
    }
    
    
    private void MainWindow_StateMaximizeChanged(
        object sender, 
        RoutedEventArgs e)
    {
        if (WindowState == WindowState.Maximized)
            this.WindowState = WindowState.Normal;
        else
            this.WindowState = WindowState.Maximized;
    }

    private void MainWindow_MouseDownChanged(
        object sender, 
        RoutedEventArgs e)
    {
        if (Mouse.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }
    
    private void MainWindow_StateMinimizeChanged(
        object sender,
        EventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    
    #endregion

}
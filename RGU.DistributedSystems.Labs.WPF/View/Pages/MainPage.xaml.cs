using System.Windows;
using System.Windows.Controls;
using RGU.DistributedSystems.Labs.WPF.ViewModel.Pages.PageViewModel;
using DryIoc;


namespace RGU.DistributedSystems.Labs.WPF.View.Pages;

public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        
        DataContext = App.Container.Resolve<MainPageViewModel>();
    }
}
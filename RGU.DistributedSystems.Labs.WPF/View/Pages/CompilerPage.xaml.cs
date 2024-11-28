using System.Windows.Controls;
using DryIoc;
using RGU.DistributedSystems.Labs.WPF.ViewModel.Pages.PageViewModel;

namespace RGU.DistributedSystems.Labs.WPF.View.Pages;

public partial class CompilerPage : Page
{
    public CompilerPage()
    {
        InitializeComponent();
        DataContext = App.Container.Resolve<CompilerPageViewModel>();
    }
    

    
}
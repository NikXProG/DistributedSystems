using System.Configuration;
using System.Data;
using System.Windows;
using DryIoc;
using RGU.DistributedSystems.Labs.WPF.View;
using RGU.DistributedSystems.Labs.WPF.View.Pages;
using RGU.DistributedSystems.Labs.WPF.ViewModel.Pages.PageViewModel;
using RGU.DistributedSystems.Labs.WPF.ViewModel;
using RGU.DistributedSystems.Labs.WPF.Utils;

namespace RGU.DistributedSystems.Labs.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    
    #region Fields
    
    private static readonly Lazy<IContainer> _container;
    
    #endregion
    
    #region Constructors
    
    static App()
    {
        _container = new Lazy<IContainer>(() => new Container());
    }
    
    #endregion
    
    #region Properties
    
    public static IContainer Container =>
        _container.Value;

    #endregion
    
    #region Methods
    
    private App RegisterLogging()
    {
        // TODO
        
        return this;
    }
    private App RegisterConfiguration()
    {
        // TODO
        
        return this;
    }
    
    #region RegisterView
    
    private App RegisterWindowsViews()
    {
        Container.Register<MainWindow>(Reuse.Singleton);
        
        return this;
    }
    
    private App RegisterPagesViews()
    {
        Container.Register<MainPage>(Reuse.Singleton);
        // TODO OTHER PAGES REGISTER
        return this;
    }
    
    private App RegisterDialogsViews()
    {
        // TODO:

        return this;
    }
    
    private App RegisterViews()
    {
        return RegisterWindowsViews()
            .RegisterPagesViews()
            .RegisterDialogsViews();
    }
    
    
    #endregion
    
    #region RegisterViewModels
    
    private App RegisterWindowsViewModels()
    {
        Container.Register<MainWindowViewModel>(Reuse.Singleton);
        
        // TODO: REGISTER WINDOW VIEW MODEL IN DI CONTAINER
        
        return this;
    }
    private App RegisterPagesViewModels()
    {
        
        Container.Register<MainPageViewModel>(Reuse.Singleton);

        // TODO: REGISTER PAGES VIEW MODEL IN DI CONTAINER
        return this;
    }
    
    private App RegisterDialogsViewModels()
    {
        // TODO: 

        return this;
    }
    
    private App RegisterViewModels()
    {
        return RegisterWindowsViewModels()
            .RegisterPagesViewModels()
            .RegisterDialogsViewModels();
    }
    
    
    #endregion
    
    private App RegisterNavigation()
    {
        var navigationManager = new NavigationManager();
        Container.RegisterInstance(navigationManager);

        navigationManager
            .AddMapping<MainPage, MainPageViewModel>();
            
        // TODO ADD ADD MAPPING VIEW AND VIEW MODEL
        
        
        return this;
    }
    
    #endregion
    
    
    #region System.Windows.Application OnStartup
    
    /// <inheritdoc cref="Application.OnStartup" />
    protected override void OnStartup(
        StartupEventArgs e)
    {
        this.RegisterLogging()
            .RegisterConfiguration()
            .RegisterViews()
            .RegisterViewModels()
            .RegisterNavigation();

        Container.Resolve<MainWindow>().Show();
    }
    
    #endregion

    
    

}
using System.ComponentModel;

namespace RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;

public class ViewModelBase : INotifyPropertyChanged
{
    
    #region Methods
    
    /// <summary>
    /// used to notify the User Interface
    /// about a change in the value data of the property.
    /// Triggers an event for the specified properties.
    /// </summary>
    /// <param name="propertyName"></param>
    protected void RaisePropertyChanged(
        string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    /// <summary>
    /// used to notify the User Interface
    /// about a change in the value data of the property.
    /// Triggers an event for the specified properties.
    /// </summary>
    /// <param name="propertiesNames"></param>
    protected void RaisePropertiesChanged(
        params string[]? propertiesNames)
    {
        foreach (var propertyName in propertiesNames ?? Enumerable.Empty<string>())
        {
            RaisePropertyChanged(propertyName);
        }
    }
    
    #endregion
    
    #region System.ComponentModel.INotifyPropertyChanged implementation
    
    /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged" />
    public event PropertyChangedEventHandler? PropertyChanged;
    
    #endregion
}
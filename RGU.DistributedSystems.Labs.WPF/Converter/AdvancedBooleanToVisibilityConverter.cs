using System.Windows;
using RGU.DistributedSystems.Labs.WPF.MVVM.Converter;

namespace RGU.DistributedSystems.Labs.WPF.Converter;

public class AdvancedBooleanToVisibilityConverter : ValueConverterBase<AdvancedBooleanToVisibilityConverter>
{
    #region Nested
    public enum Modes
    {
        Normal,
        Inverse
    }

    #endregion
    
    #region RGU.DistributedSystems.Labs.WPF.MVVM.ValueConverterBase<InverseBooleanConverter> overrides
    
    /// <inheritdoc cref="ValueConverterBase{TValueConverter}.Convert" />
    
    public override object? Convert(object? value, Type targetType, object? parameter,
        System.Globalization.CultureInfo culture)
    {
        ArgumentNullException.ThrowIfNull(value);
        
        if (targetType != typeof(Visibility))
            throw new InvalidOperationException("The target must be a Visibility type");
        
        if (value is not bool boolValue)
        {
            throw new ArgumentException("The value must be a bool");
        }
        
        if (!Enum.IsDefined(typeof(Modes), parameter))
        {
            // TODO: throw an exception
        }

        var mode = (Modes)parameter;
        
        return ( mode == Modes.Inverse ? !boolValue : boolValue ) ? Visibility.Visible : Visibility.Collapsed;
        

    }
    
    #endregion
}

using System.Globalization;
using System.Windows;
using System.Windows.Data;
using RGU.DistributedSystems.Labs.WPF.MVVM.Converter;

namespace RGU.DistributedSystems.Labs.WPF.Converter;

public class UppercaseTypographyConverter : ValueConverterBase<UppercaseTypographyConverter>
{
    
    #region RGU.DistributedSystems.Labs.WPF.MVVM.ValueConverterBase<UppercaseTypographyConverter> overrides
    
    /// <inheritdoc cref="ValueConverterBase{TValueConverter}.Convert" />
    
    public override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        ArgumentNullException.ThrowIfNull(value);
        
        bool uppercase = (bool)value;
        if (uppercase) return FontCapitals.AllSmallCaps;
        else return FontCapitals.Normal;
        
    }
    
    #endregion
    
}
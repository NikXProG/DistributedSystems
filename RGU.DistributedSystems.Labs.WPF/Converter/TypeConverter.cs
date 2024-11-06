using System.Globalization;
 using System.Windows;
using System.Windows.Data;
 using RGU.DistributedSystems.Labs.WPF.MVVM.Converter;


 namespace RGU.DistributedSystems.Labs.WPF.Converter;

public class TypeConverter : MultiValueConverterBase<TypeConverter>

{
    #region Nested
    
    /// <summary>
    /// 
    /// </summary>
    public enum Types
    {
        /// <summary>
        /// 
        /// </summary>
        CornerRadius,
        /// <summary>
        /// 
        /// </summary>
        Thickness
    }
    
    #endregion
    
    #region RGU.DistributedSystems.WPF.MVVM.MultiValueConverterBase<FCornerRadiusConverter> overrides
    
    /// <inheritdoc cref="MultiValueConverterBase{TMultiValueConverter}.Convert" />
    public override object? Convert(
        object[]? values,
        Type targetType,
        object? parameter,
        CultureInfo culture)
    {
        
        ArgumentNullException.ThrowIfNull(values);
        ArgumentNullException.ThrowIfNull(parameter);
        
        if (values.Length != 1)
        {
            throw new ArgumentNullException(nameof(values));
        }
        
        
        if (!Enum.IsDefined(typeof(Types), parameter))
        {
            // TODO: throw an exception
        }
        
        var numericValue = (values[0] as double?) ?? double.NaN;
        
        
        if (double.IsNaN(numericValue))
        {
            return DependencyProperty.UnsetValue;
        }
        
        
        
        var @operator = (Types)parameter;

        switch (@operator)
        {
            case Types.Thickness:
                return new Thickness(numericValue);
            case Types.CornerRadius:
                return new CornerRadius(numericValue);
            default:
                throw new ArgumentOutOfRangeException(nameof(parameter));
        }
        
        
       
        
        
    }
    
    
    
    
    #endregion
}
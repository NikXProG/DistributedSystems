using System.Globalization;
 using System.Windows;
using System.Windows.Data;
 using RGU.DistributedSystems.Labs.WPF.MVVM.Converter;


 namespace RGU.DistributedSystems.Labs.WPF.Converter;

public class CornerRadiusConverter : MultiValueConverterBase<CornerRadiusConverter>
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
        object?[] values,
        Type targetType,
        object? parameter,
        CultureInfo culture)
    {
        if (values.Length != 1)
        {
            throw new ArgumentException("Expected 1 values for CornerRadius (double value). ");
        }
            
        ArgumentNullException.ThrowIfNull(parameter);
        
        if (!Enum.IsDefined(typeof(Types), parameter))
        {
            // TODO: throw an exception
        }
        


        var value = values[0] is double valueNullable ?  valueNullable : double.NaN;
        
        if (double.IsNaN(value))
        {
            return DependencyProperty.UnsetValue;
        }
        
        var @operator = (Types)parameter;

        switch (@operator)
        {
            case Types.Thickness:
                return new Thickness(value);
            case Types.CornerRadius:
                return new CornerRadius(value);
            default:
                throw new ArgumentOutOfRangeException(nameof(parameter));
        }
        
        
       
        
        
    }
    
    
    
    
    #endregion
}
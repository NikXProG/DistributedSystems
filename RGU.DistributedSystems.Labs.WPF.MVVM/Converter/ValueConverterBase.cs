using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace RGU.DistributedSystems.Labs.WPF.MVVM.Converter;

// covariance
// contravariance
// invariance

/// <summary>
/// 
/// </summary>
public abstract class ValueConverterBase<TValueConverter>:
    MarkupExtension,
    IValueConverter
    where TValueConverter: new()
{
    
    #region Fields
    
    /// <summary>
    /// 
    /// </summary>
    private static readonly Lazy<TValueConverter> _instance;
    
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// 
    /// </summary>
    static ValueConverterBase()
    {
        _instance = new Lazy<TValueConverter>(() => new TValueConverter());
    }

    #endregion
    
    #region System.Windows.Markup.MarkupExtension overrides
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <returns></returns>
    public override object ProvideValue(
        IServiceProvider serviceProvider)
    {
        return _instance.Value;
    }
    

    #endregion
    
    #region System.Windows.Data.IMultiValueConverter implementation
    
    /// <inheritdoc cref="IMultiValueConverter.Convert" />
    public abstract object? Convert(
        object? value,
        Type targetType,
        object? parameter,
        CultureInfo culture);
    
    /// <inheritdoc cref="IMultiValueConverter.ConvertBack" />
    public virtual object ConvertBack(
        object? value,
        Type targetType,
        object? parameter,
        CultureInfo culture)
    {
        throw new NotSupportedException("Reverse conversion is not supported");
    }
    
    #endregion
}
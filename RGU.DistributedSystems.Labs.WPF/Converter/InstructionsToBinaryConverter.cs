using System.Globalization;
using RGU.DistributedSystems.Labs.WPF.MVVM.Converter;

namespace RGU.DistributedSystems.Labs.WPF.Converter;

public class InstructionsToBinaryConverter :
    MultiValueConverterBase<ArithmeticConverter>
{
    public override object? Convert(
        object?[] values,
        Type targetType,
        object? parameter,
        CultureInfo culture)
    {
        return null;
    }
}
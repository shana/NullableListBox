using System;
using System.Globalization;

namespace NullableListBox
{
    public class DefaultValueConverter : ValueConverterMarkupExtension<DefaultValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? parameter : value;
        }

    }
}
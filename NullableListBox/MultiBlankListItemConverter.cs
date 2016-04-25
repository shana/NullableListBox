using System;
using System.Collections;
using System.Globalization;
using System.Windows.Controls;

namespace NullableListBox
{
    public class MultiBlankListItemConverter : MultiValueConverterMarkupExtension<MultiBlankListItemConverter>
    {
        public override object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Length < 3)
                return null;

            if (!(value[1] is IEnumerable))
                return null;

            var control = value[2] as ListBox;
            if (control?.SelectedItem == null)
                return value[1];

            dynamic arg = value[0];
            dynamic items = value[1];
            items.Insert(0, arg);
            return items;
        }

        public override object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
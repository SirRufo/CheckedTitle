using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace CheckedTitle.WpfApp
{
    public class BooleanToCustomConverter : MarkupExtension, IValueConverter
    {
        public string? TrueValue { get; set; }
        public string? FalseValue { get; set; }
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b)
                return b ? TrueValue : FalseValue;
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

    }
}

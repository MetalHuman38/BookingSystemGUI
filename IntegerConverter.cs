using System.Globalization;
using System.Windows.Data;

namespace BookingSystem
{
    public class IntegerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Assuming 'value' is an integer, convert it to a string
            if (value is int intValue)
            {
                return intValue.ToString();
            }

            return value?.ToString(); // Return the original value if not an integer
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Attempt to convert the string back to an integer
            if (int.TryParse(value?.ToString(), out int result))
            {
                return result;
            }

            return value; // Return the original value if conversion fails
        }
    }
}

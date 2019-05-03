using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace Gsd2Aml.Gui.Converter
{
    class PathValidator : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
                return false;
            
            if (values[0] is string gsdFile && !string.IsNullOrWhiteSpace(gsdFile) &&
                values[1] is string amlFile && !string.IsNullOrWhiteSpace(amlFile))
            {
                return File.Exists(gsdFile) && Path.IsPathRooted(amlFile) &&
                    Path.GetExtension(amlFile).Equals(".amlx", StringComparison.CurrentCultureIgnoreCase);
            }

            return false;
        }
        
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

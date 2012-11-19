using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace TempWpfApplication1 {

    //[ValueConversion(typeof(int), typeof(Brush))]
    public class NumToBkColorConverter : IValueConverter {

        public static readonly IValueConverter Instance = new NumToBkColorConverter();


        public object Convert(object value, Type targetType, object o, CultureInfo info) {
            if (targetType != typeof(Brush)) { return null; }
            if (value == null) { return null; }
            int no;
            if (int.TryParse(value.ToString(), out no)) {
                return (no % 2 == 0) ? Brushes.LightBlue : Brushes.Red;
            } else
                return null;
        }

        public object ConvertBack(object value, Type targetType, object o, CultureInfo info) {
            throw new NotImplementedException();
        }
    }
}

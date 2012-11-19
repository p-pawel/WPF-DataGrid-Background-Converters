using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace TempWpfApplication1 {

    //[ValueConversion(typeof(int), typeof(Brush))]
    public class NumToBkColorConverterA : IValueConverter {

        public static readonly IValueConverter Instance = new NumToBkColorConverterA();


        public object Convert(object value, Type targetType, object o, CultureInfo info) {
            if (targetType != typeof(Brush)) { return null; }
            if (value == null) { return null; }
            int no;
            if (int.TryParse(value.ToString(), out no)) {
                switch (no % 3) {
                    case 0: return Brushes.Yellow;
                    case 1: return Brushes.LightGreen;
                    case 2: return Brushes.Blue;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object o, CultureInfo info) {
            throw new NotImplementedException();
        }
    }
}

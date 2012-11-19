using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace TempWpfApplication1 {

    //[ValueConversion(typeof(int), typeof(Brush))]
    public class NumToBkColorConverter2A : IMultiValueConverter {

        public static readonly IMultiValueConverter Instance = new NumToBkColorConverter2A();


        public object Convert(object[] value, Type targetType, object o, CultureInfo info) {
            
            if (targetType != typeof(Brush)) { return null; }
            if (value == null) { return null; }

            if (value[0] == null) { return null; }
            //if (value[1] == null) { return null; }
            Item item = value[0] as Item;
            if (item == null) return null;
            //int no;
            if (item.AreNumberEquals)
                return Brushes.LightGray;
            else
                return Brushes.DarkGray;
            //return null;
        }

        public object[] ConvertBack(object value, Type[] targetType, object o, CultureInfo info) {
            throw new NotImplementedException();
        }
    }
}

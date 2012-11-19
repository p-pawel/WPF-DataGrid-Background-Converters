using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace TempWpfApplication1 {
    public class Item : INotifyPropertyChanged {

        decimal no1, no2;
        //decimal sum;

        public int Id { get; set; }
        public string Name { get; set; }
        public string No1 {
            get {
                return no1.ToString();
            }
            set {
                decimal d;
                if (decimal.TryParse(value, out d)) {
                    no1 = d;
                    NotifyPropertyChanged("No1");
                    NotifyPropertyChanged("Sum");
                }

            }
        }
        public decimal No2 {
            get {
                return no2;
            }
            set {
                no2 = value;
                NotifyPropertyChanged("No2");
                NotifyPropertyChanged("Sum");
            }
        }

        public decimal Sum {
            get {
                decimal d;
                if (decimal.TryParse(No1, out d))
                    return d + No2;
                else
                    return 0;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(String info) {
            //Debug.WriteLine("NotifyPropertyChanged(" + info + ")");
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public bool AreNumberEquals {
            get {
                return no1 == no2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Whistregnskab_UWP.Converters
{
    public class NrTilNavnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string navn = "";
            int nr = (int)value;
            switch (nr)
            {
                case 0:
                    navn = App.Pulje.Spiller1;
                    break;
                case 1:
                    navn = App.Pulje.Spiller2;
                    break;
                case 2:
                    navn = App.Pulje.Spiller3;
                    break;
                case 3:
                    navn = App.Pulje.Spiller4;
                    break;
                default:
                    navn = "Solo";
                    break;
            }
            return navn;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Whistregnskab_UWP.Converters
{
    public class SkæveConverterNr : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int melding = 0;
            string skæve = "";
            int Melding = (int)value;
            switch (Melding)
            {
                case -1:
                    melding = 0;
                    break;
                case 0:
                    melding = 1;
                    break;
                case 1:
                    melding = 2;
                    break;
                default:
                    int korrigeretMelding = Melding;
                    if (Melding > 9)
                    {
                        if (Melding > 10 && Melding < 20) { skæve = "halve"; korrigeretMelding = korrigeretMelding - 10; }
                        if (Melding > 20 && Melding < 30) { skæve = "vip"; korrigeretMelding = korrigeretMelding - 20; }
                        if (Melding > 30 && Melding < 40) { skæve = "sans"; korrigeretMelding = korrigeretMelding - 30; }
                        if (Melding > 40 && Melding < 50) { skæve = "gode"; korrigeretMelding = korrigeretMelding - 40; }
                    }
                    melding = (korrigeretMelding);
                    break;
            }
            switch (skæve)
            {
                case "halve":
                    melding = 1;
                    break;
                case "vip":
                    melding = 2;
                    break;
                case "sans":
                    melding = 3;
                    break;
                case "gode":
                    melding = 4;
                    break;
                default:
                    melding = 0;
                    break;
            }
            return melding;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}



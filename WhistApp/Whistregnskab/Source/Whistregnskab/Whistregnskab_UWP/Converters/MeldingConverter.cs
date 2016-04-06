using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Whistregnskab_UWP.Converters
{
    public class MeldingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string melding = "";
            string skæve = "";
            int Melding = (int)value;
            switch (Melding)
            {
                case -1:
                    melding = "Bordlægger";
                    break;
                case 0:
                    melding = "Nol";
                    break;
                case 1:
                    melding = "Sol";
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
                    melding = (korrigeretMelding + 4).ToString() + " " + skæve;
                    break;
            }
            return $"{melding}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}



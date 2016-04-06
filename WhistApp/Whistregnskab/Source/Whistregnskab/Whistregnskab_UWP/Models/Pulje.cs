using System;
using Template10.Mvvm;

namespace Whistregnskab_UWP.Models
{

    public class Pulje : BindableBase
    {
        private int _PuljeId;
        public int PuljeId { get { return _PuljeId; } set { Set(ref _PuljeId, value); }}

        private string _Navn;
        public string Navn { get { return _Navn; } set { Set(ref _Navn, value); } }

        private string _Ejer;
        public string Ejer { get { return _Ejer; } set { Set(ref _Ejer, value); } }

        private DateTime _Oprettelsesdato;
        public DateTime Oprettelsesdato { get { return _Oprettelsesdato; } set { Set(ref _Oprettelsesdato, value); } }

        private string _Spiller1;
        public string Spiller1 { get { return _Spiller1; } set { Set(ref _Spiller1, value); } }

        private int _Point1;
        public int Point1 { get { return _Point1; } set { Set(ref _Point1, value); } }

        private string _Spiller2;
        public string Spiller2 { get { return _Spiller2; } set { Set(ref _Spiller2, value); } }

        private int _Point2;
        public int Point2 { get { return _Point2; } set { Set(ref _Point2, value); } }

        private string _Spiller3;
        public string Spiller3 { get { return _Spiller3; } set { Set(ref _Spiller3, value); } }

        private int _Point3;
        public int Point3 { get { return _Point3; } set { Set(ref _Point3, value); } }

        private string _Spiller4;
        public string Spiller4 { get { return _Spiller4; } set { Set(ref _Spiller4, value); } }

        private int _Point4;
        public int Point4 { get { return _Point4; } set { Set(ref _Point4, value); } }
    }
}










using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Whistregnskab_UWP.Models
{
    public class RundeHeader : BindableBase
    {
        private int _RundeId;
        public int RundeId { get { return _RundeId; } set { Set(ref _RundeId, value); } }

        private DateTime _Dato;
        public DateTime Dato { get { return _Dato; } set { Set(ref _Dato, value); } }

        private string _Sted;
        public string Sted { get { return _Sted; } set { Set(ref _Sted, value); } }

        private string _Bem;
        public string Bem { get { return _Bem; } set { Set(ref _Bem, value); } }

        private int _Point1;
        public int Point1 { get { return _Point1; } set { Set(ref _Point1, value); } }

        private int _Point2;
        public int Point2 { get { return _Point2; } set { Set(ref _Point2, value); } }

        private int _Point3;
        public int Point3 { get { return _Point3; } set { Set(ref _Point3, value); } }

        private int _Point4;
        public int Point4 { get { return _Point4; } set { Set(ref _Point4, value); } }

        private string _Spiller1;
        public string Spiller1 { get { return _Spiller1; } set { Set(ref _Spiller1, value); } }

        private string _Spiller2;
        public string Spiller2 { get { return _Spiller2; } set { Set(ref _Spiller2, value); } }

        private string _Spiller3;
        public string Spiller3 { get { return _Spiller3; } set { Set(ref _Spiller3, value); } }

        private string _Spiller4;
        public string Spiller4 { get { return _Spiller4; } set { Set(ref _Spiller4, value); } }

        private int _PuljeId;
        public int PuljeId { get { return _PuljeId; } set { Set(ref _PuljeId, value); } }


    }
}

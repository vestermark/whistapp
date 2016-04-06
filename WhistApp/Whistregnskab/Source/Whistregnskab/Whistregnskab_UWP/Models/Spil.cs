using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Whistregnskab_UWP.Models
{
    public class Spil : BindableBase
    {
        private int _SpilId;
        public int SpilId { get { return _SpilId; } set { Set(ref _SpilId, value); } }

        private DateTime _Tidspunkt;
        public DateTime Tidspunkt { get { return _Tidspunkt; } set { Set(ref _Tidspunkt, value); } }

        private int _Melder;
        public int Melder { get { return _Melder; } set { Set(ref _Melder, value); } }

        private int _Melding;
        public int Melding { get { return _Melding; } set { Set(ref _Melding, value); } }

        private int _Makker;
        public int Makker { get { return _Makker; } set { Set(ref _Makker, value); } }

        private int _Stik;
        public int Stik { get { return _Stik; } set { Set(ref _Stik, value); } }

        private int _Point1;
        public int Point1 { get { return _Point1; } set { Set(ref _Point1, value); } }

        private int _Point2;
        public int Point2 { get { return _Point2; } set { Set(ref _Point2, value); } }

        private int _Point3;
        public int Point3 { get { return _Point3; } set { Set(ref _Point3, value); } }

        private int _Point4;
        public int Point4 { get { return _Point4; } set { Set(ref _Point4, value); } }

        private int _RundeId;
        public int RundeId { get { return _RundeId; } set { Set(ref _RundeId, value); } }



    }
}

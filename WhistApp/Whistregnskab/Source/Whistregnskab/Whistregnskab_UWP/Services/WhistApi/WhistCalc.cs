using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whistregnskab_UWP.Services.WhistApi
{
    public class WhistCalc
    {

        public static int[] BeregnPoint(int _Melder, int _Melding, int _Stik, int _Makker)
        {
            //      Definition      Melding     MinStik/MaxStik     Point
            //      ---------------------------------------------------------                
            //      Bordlægger     -1           0                   200
            //      Nol             0           0                   100
            //      Sol             1           1                   50
            //      7               3           7                   10
            //      8               4           8                   20
            //      9               5           9                   40
            //      10              6          10                   80
            //      11              7          11                  160 
            //      12              8          12                  320
            //      13              9          13                  640
            //
            //      Skæve                               Værdi       point
            //      -----------------------------------------------------                
            //      Halve           Makker melder       10          x 2
            //      Vip             Vip trumf           20          x 2
            //      Sans            uden trumf          30          x 2
            //      Gode            Klør er trumf       40          x 2
            //
            //      Gå ned/op       faktor
            //      ------------------------------------------------------
            //      1 stik          x 2
            //      2 stik          x 3
            //      3 stik          x 4
            //      4 stik          x 5
            //      5 stik          x 6
            //      6 stik          x 7
            //
            //      ------------------------------------------------------

            int[] point = new int[4];
            int skæve = (_Melding > 9 ? 2 : 1);
            int melding = _Melding;
            int resultat = 0;
            int faktor = 1;

            if (_Melding > 1)
            {
                melding = Convert.ToInt32(_Melding.ToString().Substring(1 * skæve - 1, 1)) + 4;
                if (melding > _Stik)
                {
                    faktor = (_Stik - melding - 1);
                }
                if (melding < _Stik)
                {
                    faktor = (_Stik - melding + 1);
                }
            }

            switch (melding)
            {
                //Bordlægger
                case -1:
                    if (_Stik > 0)
                    {
                        FordelPointAlene(_Melder, -400, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, 200, ref point);
                    }

                    break;
                //nol
                case 0:
                    if (_Stik > 0)
                    {
                        FordelPointAlene(_Melder, -200, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, 100, ref point);
                    }
                    break;
                //sol
                case 1:
                    if (_Stik > 1)
                    {
                        FordelPointAlene(_Melder, -100, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, 50, ref point);
                    }
                    break;
                case 7:
                    resultat = 10 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
                case 8:
                    resultat = 20 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
                case 9:
                    resultat = 40 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
                case 10:
                    resultat = 80 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
                case 11:
                    resultat = 160 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
                case 12:
                    resultat = 320 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
                case 13:
                    resultat = 640 * skæve * faktor;
                    if (_Makker > 0)
                    {
                        FordelPointMedMakker(_Melder, _Makker, resultat, ref point);
                    }
                    else
                    {
                        FordelPointAlene(_Melder, resultat, ref point);
                    }
                    break;
            }

            return point;
        }

        public static void FordelPointAlene(int Modtager, int værdi, ref int[] point)
        {
            for (int i = 0; i < 4; i++)
            {
                if ((i + 1) == Modtager)
                {
                    point[i] = værdi * 3;
                }
                else
                {
                    point[i] = -værdi;
                }
            }
        }

        public static void FordelPointMedMakker(int Modtager, int Makker, int værdi, ref int[] point)
        {
            for (int i = 0; i < 4; i++)
            {
                if (((i + 1) == Modtager) | (i + 1) == Makker)
                {
                    point[i] = værdi;
                }
                else
                {
                    point[i] = -værdi;
                }
            }
        }

    }

}

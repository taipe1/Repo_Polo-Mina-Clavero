using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13_Billetera.Modelo
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }
        public decimal Total()
        {
            return BilletesDe10 * 10
                + BilletesDe20 * 20
                + BilletesDe50 * 50
                + BilletesDe100 * 100
                + BilletesDe200 * 200
                + BilletesDe500 * 500
                + BilletesDe1000 * 1000;
        }
        public static Billetera Combinar(Billetera miBilletera, Billetera otraBilletera, Billetera billeteraCombinada)
        {
            billeteraCombinada.BilletesDe10 = miBilletera.BilletesDe10 + otraBilletera.BilletesDe10;
            billeteraCombinada.BilletesDe20 = miBilletera.BilletesDe20 + otraBilletera.BilletesDe20;
            billeteraCombinada.BilletesDe50 = miBilletera.BilletesDe50 + otraBilletera.BilletesDe50;
            billeteraCombinada.BilletesDe100 = miBilletera.BilletesDe100 + otraBilletera.BilletesDe100;
            billeteraCombinada.BilletesDe200 = miBilletera.BilletesDe200 + otraBilletera.BilletesDe200;
            billeteraCombinada.BilletesDe500 = miBilletera.BilletesDe500 + otraBilletera.BilletesDe500;
            billeteraCombinada.BilletesDe1000 = miBilletera.BilletesDe1000 + otraBilletera.BilletesDe1000;

            miBilletera.BilletesDe10 = 0;
            miBilletera.BilletesDe20 = 0;
            miBilletera.BilletesDe50 = 0;
            miBilletera.BilletesDe100 = 0;
            miBilletera.BilletesDe200 = 0;
            miBilletera.BilletesDe500 = 0;
            miBilletera.BilletesDe1000 = 0;

            otraBilletera.BilletesDe10 = 0;
            otraBilletera.BilletesDe20 = 0;
            otraBilletera.BilletesDe50 = 0;
            otraBilletera.BilletesDe100 = 0;
            otraBilletera.BilletesDe200 = 0;
            otraBilletera.BilletesDe500 = 0;
            otraBilletera.BilletesDe1000 = 0;

            return billeteraCombinada;
        }

    }


}

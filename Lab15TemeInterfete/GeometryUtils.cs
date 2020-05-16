using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15TemeInterfete
{
    public static class GeometryUtils
    {
        //aria dreptunghiului
        public static int Suprafata (int x, int y, EnumGeom e )
        {
            if ( e == EnumGeom.Dreptunghi )
            {
                return x * y;
            } else if ( e == EnumGeom.Triunghi )
            {
                return x * y / 2;
            }
            
            return 0;
        }

        //arie trapez
        public static int Suprafata(int x, int y, int z)
        {
            return ((x + y) * z) / 2;
        }

        // aria unei sfere
        public static double Suprafata(int x)
        {
            return 3.14 * Math.Pow(x, 2);
        }

    }
}

using System;

namespace Lab15TemeInterfete
{
    class Program
    {
        static void Main(string[] args)
        {
            SegmentDreapta sd = new SegmentDreapta();
            sd.ColectiePuncte(new[]
            {
                new StructPunct(5, 8),
                new StructPunct(6, 5)
            });

            Triunghi tr = new Triunghi();
            tr.ColectiePuncte(new[]
            {
               new StructPunct(5, 8),
               new StructPunct(6, 5),
               new StructPunct(1, 4)
           });

            //aria dreptunghiului
            GeometryUtils.Suprafata(4, 5, EnumGeom.Dreptunghi);

            //aria cerc
            GeometryUtils.Suprafata(4);

            //aria triunghi
            GeometryUtils.Suprafata(3, 5, EnumGeom.Triunghi);

            //aria trapez
            GeometryUtils.Suprafata(3, 5, 7);
        }
    }
}

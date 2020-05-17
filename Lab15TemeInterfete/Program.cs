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
            Console.WriteLine("Aria Dreptungiului cu laturile de 4 si 5 este: " + GeometryUtils.Suprafata(4, 5, EnumGeom.Dreptunghi)); 

            //aria cerc
            Console.WriteLine("Aria cercului cu raza de 4 este: " + GeometryUtils.Suprafata(4).ToString());

            //aria triunghi
            Console.WriteLine("Aria tringhiului cu baza de 3 si inaltime de 5 este: " + GeometryUtils.Suprafata(3, 5, EnumGeom.Triunghi));

            //aria trapez
            Console.WriteLine("Aria trapezului cu bazele de 3, 5 si inaltime de 7 este: " + GeometryUtils.Suprafata(3, 5, 7)); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15TemeInterfete
{
    class Triunghi : IFormaGeometrica
    {
        StructPunct[] Puncte;
        public void ColectiePuncte(params StructPunct[] puncte)
        {
            if (puncte.Length != 3)
            {
                Console.WriteLine("Un Triungi trebuie sa aiba 3 puncte");
                Console.ReadLine();
            }

            this.Puncte = puncte;
        }

        public void DeplasareX(int dX)
        {
            this.Puncte[0].X += dX;
            this.Puncte[1].X += dX;
            this.Puncte[2].X += dX;
        }

        public void DeplasareY(int dY)
        {
            this.Puncte[0].Y += dY;
            this.Puncte[1].Y += dY;
            this.Puncte[2].Y += dY;
        }
    }
}

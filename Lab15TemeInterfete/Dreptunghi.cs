using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15TemeInterfete
{
    class Dreptunghi : IFormaGeometrica
    {
        int Inaltime;
        int Latime;
        StructPunct[] Puncte = new StructPunct[4];
        public Dreptunghi (int latime, int inaltime, StructPunct p)
        {
            this.ColectiePuncte(new[] { p });
            this.Inaltime = inaltime;
            this.Latime = latime;
        }

        public void ColectiePuncte(params StructPunct[] puncte)
        {
            this.Puncte = puncte; //primul punct vine din constructor
            this.Puncte[1].X = this.Puncte[0].X + this.Latime;    //al doilea punct derivat din primul
            this.Puncte[1].Y = this.Puncte[0].Y;                  //al doilea punct derivat din primul
            this.Puncte[2].X = this.Puncte[0].X;                  //al treilea punct derivat din primul
            this.Puncte[2].Y = this.Puncte[0].Y + this.Inaltime;  //al treilea punct derivat din primul
            this.Puncte[3].X = this.Puncte[1].X;                  //al treilea punct derivat din al doilea
            this.Puncte[3].Y = this.Puncte[2].Y;                  //al treilea punct derivat din al treilea
        }

        public void DeplasareX(int dX)
        {
            this.Puncte[0].X += dX;
            this.Puncte[1].X += dX;
            this.Puncte[2].X += dX;
            this.Puncte[3].X += dX;
        }

        public void DeplasareY(int dY)
        {
            this.Puncte[0].Y += dY;
            this.Puncte[1].Y += dY;
            this.Puncte[2].Y += dY;
            this.Puncte[3].Y += dY;
        }
    }
}

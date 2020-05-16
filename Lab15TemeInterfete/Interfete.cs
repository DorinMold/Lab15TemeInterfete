using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15TemeInterfete
{
    interface IDeplasareAxaX
    {
        void DeplasareX(int dX);
    }

    interface IDeplasareAxaY
    {
        void DeplasareY(int dY);
    }

    interface IFormaGeometrica : IDeplasareAxaX, IDeplasareAxaY
    {
        void ColectiePuncte(params StructPunct[] Puncte );
    }
}

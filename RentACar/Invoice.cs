using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class Invoice
    {
        internal int id;
        internal int status;
        internal int dagprijs_bij_boeking;
        internal int total_price;

        internal Reservering reservering;
        internal Car car;
    }
}

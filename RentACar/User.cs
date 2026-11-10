using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class User
    {
        internal string email { get; set; } = string.Empty;
        internal string role { get; set; } = string.Empty;
        internal string fname { get; set; } = string.Empty;
        internal string lname { get; set; } = string.Empty;
        internal string status { get; set; } = string.Empty;
        internal string street { get; set; } = string.Empty;
        internal string zipcode { get; set; } = string.Empty;
        internal string city { get; set; } = string.Empty;
        internal int user_id { get; set; }
        internal int user_address_id { get; set; }
    }
}

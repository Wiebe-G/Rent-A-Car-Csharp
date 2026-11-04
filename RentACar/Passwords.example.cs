using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class PasswordsExample
    {
        // db username
        internal protected readonly string DBusername = "";
        // db password
        internal protected readonly string DBpassword = "";
        // name of db
        internal protected readonly string DBName = "";
        // connection string
        internal protected string ConnStr;

        internal PasswordsExample()
        {
            ConnStr = $"Server=127.0.0.1;Database={DBName};Uid={DBusername};Pwd={DBpassword}";
        }
    }
}

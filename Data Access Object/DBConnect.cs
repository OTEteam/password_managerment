using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Windows;

namespace Data_Access_Object
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("server=DESKTOP-LVLR7JR;database=BookStore;uid=sa;pwd=123456789");
    }
}

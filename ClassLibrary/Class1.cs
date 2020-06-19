using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public string connectionString = "Data Source=DESKTOP-F28KLAR\\SQLEXPRESS;Initial Catalog=ShopMvideo;Integrated Security=True";
        public string sql = "SELECT [ID_Goods], [Name_of_Goods] as \"Товар\" from [dbo].[Goods]";
    }
}

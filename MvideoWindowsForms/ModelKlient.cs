using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvideoWindowsForms
{
    public class ModelKlient
    {
        public int ID_Klient { get; set; }
        public string First_Name_Klient { get; set; }
        public string Name_Klient { get; set; }
        public string Middle_Name_Klient { get; set; }
        public string Klient_Login { get; set; }
        public string Klient_Password { get; set; }
        public bool Klient_Logical_Delete { get; set; }

        public ModelKlient(int iD_Klient, string first_Name_Klient, string name_Klient, string middle_Name_Klient, string klient_Login, string klient_Password, bool klient_Logical_Delete)
        {
            ID_Klient = iD_Klient;
            First_Name_Klient = first_Name_Klient;
            Name_Klient = name_Klient;
            Middle_Name_Klient = middle_Name_Klient;
            Klient_Login = klient_Login;
            Klient_Password = klient_Password;
            Klient_Logical_Delete = klient_Logical_Delete;
        }

        public void Update()
        {
            var qwertyLOGPASKlient = $"SELECT * FROM dbo.Klient WHERE ID_Klient = {ID_Klient}";
            var ProverkaKlient = new Table_Class(qwertyLOGPASKlient);

            ID_Klient = Convert.ToInt32(ProverkaKlient.table.Rows[0][0]);
            First_Name_Klient = Convert.ToString(ProverkaKlient.table.Rows[0][1]);
            Name_Klient = Convert.ToString(ProverkaKlient.table.Rows[0][2]);
            Middle_Name_Klient = Convert.ToString(ProverkaKlient.table.Rows[0][3]);
            Klient_Login = Convert.ToString(ProverkaKlient.table.Rows[0][4]);
            Klient_Password = Convert.ToString(ProverkaKlient.table.Rows[0][5]);
            Klient_Logical_Delete = Convert.ToBoolean(ProverkaKlient.table.Rows[0][6]);
        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace Gestion_Auberge.DataBusiness
{
    class Login
    {
        public DataTable login(string username, string password)
        {
            Dataaccesslayer.DataAccessLayer dal = new Dataaccesslayer.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar, 50);
            param[0].Value = username;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = password;
            dal.Open();
            DataTable ta = new DataTable();
            ta = dal.SelectData("proc_Login", param);
            return ta;
            dal.Close();
        }
    }
}

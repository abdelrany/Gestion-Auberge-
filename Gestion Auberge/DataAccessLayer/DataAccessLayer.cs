using System.Data;
using System.Data.SqlClient;

namespace Gestion_Auberge.Dataaccesslayer
{
    class DataAccessLayer
    {
        SqlConnection con;

        public DataAccessLayer()
        {
            con = new SqlConnection(@"data source = .\sqlexpress ; initial catalog = hostel ; integrated security = yes");
        }

        public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable SelectData(string storedproc, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedproc;
            cmd.Connection = con;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ta = new DataTable();
            da.Fill(ta);
            return ta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.POP.Function
{
    class MS_DBClass
    {
        //static string ConnectionString = "Data Source=db3.coever.co.kr;Initial Catalog=DTISFILEDB;User ID=sa; Password=Codb89897788@$^;";
        static string ConnectionString = "Data Source=192.168.123.252;Initial Catalog=DTISFILEDB;User ID=pmo; Password=semids1357!;";
        
        // con = new SqlConnection("Data Source=192.168.123.252;Initial Catalog=DTISDB;User ID=pmo; Password=semids1357!;");
        public static System.Data.DataTable USP_POP_FILE(string code)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(ConnectionString);
                SqlCommand cmd;
                cmd = new SqlCommand();
                cmd.CommandText = "USP_POP_FILE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DOCNO", SqlDbType.VarChar, 50));

                // 값할당
                cmd.Parameters["@DOCNO"].Value = code;


                SqlDataReader dr;
                DataTable dt;
                dt = new DataTable();
                con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

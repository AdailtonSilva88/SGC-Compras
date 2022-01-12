using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao() 
        {
            con.ConnectionString = @"Data Source=DESKTOP-75NR56H\SQL2012;Initial Catalog=SGC_DB;Integrated Security=True";
        }

        public SqlConnection conectar() 
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }    
            return con;

        }
        public void desconectar() 
        {
            con.Close();
        }


    }
}

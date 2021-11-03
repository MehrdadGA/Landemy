using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Manage Close And Open DataBase Coonection
/// </summary>

public class SqlCon
{
    private String Strcon;
    private SqlConnection con;

    public SqlConnection Open()
    {
        Strcon = "Password=mehrdad123;Persist Security Info=True;User ID=sa;Initial Catalog=Db_ZabanSara;Data Source=me-ghafari";
        con = new SqlConnection(Strcon);
        con.Open();
        return con;
    }

    public void Close()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }
}

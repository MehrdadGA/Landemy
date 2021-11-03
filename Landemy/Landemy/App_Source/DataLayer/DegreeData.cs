using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// DataLayer for connect and work with Connection class
/// </summary>
public class DegreeData
{
    public DataTable GetDegreeListData()
    {
        SqlCon sqlCon = new SqlCon();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_GetDegreeList", sqlCon.Open());
        DataTable dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        return dataTable;
    }

    public int InsertDegreeData(string Title)
    {
        SqlCon sqlCon = new SqlCon();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "sp_InsertDegree";
        sqlCommand.Parameters.AddWithValue("@Title", Title);
        sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
        sqlCommand.Connection = sqlCon.Open();
        sqlCommand.ExecuteNonQuery();
        int Result = int.Parse(sqlCommand.Parameters["@ID"].Value.ToString());
        sqlCon.Close();
        return Result;
    }

    public int UpdateDegreeData(int Id, string Title)
    {
        SqlCon sqlCon = new SqlCon();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "sp_UpdateDegree";
        sqlCommand.Parameters.AddWithValue("@ID", Id);
        sqlCommand.Parameters.AddWithValue("@Title", Title);
        sqlCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
        sqlCommand.Connection = sqlCon.Open();
        sqlCommand.ExecuteNonQuery();
        int Result = int.Parse(sqlCommand.Parameters["Result"].Value.ToString());
        sqlCon.Close();
        return Result;
    }
}


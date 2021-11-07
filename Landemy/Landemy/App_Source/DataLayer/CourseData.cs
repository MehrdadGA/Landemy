using System.Data;
using System.Data.SqlClient;

     public class CourseData
     {

	 public int DataInsertCourse(int ID ,string Title ,byte LevelCount ,string Tuition )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertCourse";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@Title",Title);
		Sqlcom.Parameters.AddWithValue("@LevelCount",LevelCount);
		Sqlcom.Parameters.AddWithValue("@Tuition",Tuition);
		Sqlcom.Connection = Scon.Open();
		int R=0;
		Sqlcom.ExecuteNonQuery();
		R = int.Parse(Sqlcom.Parameters["@ID"].Value.ToString());
		Scon.Close();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public int DataDeleteCourse(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteCourse";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public int DataUpdateCourse(int ID ,string Title ,byte LevelCount ,string Tuition )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateCourse";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@Title",Title);
		Sqlcom.Parameters.AddWithValue("@LevelCount",LevelCount);
		Sqlcom.Parameters.AddWithValue("@Tuition",Tuition);
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public DataTable DataGetListCourse()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListCourse",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsCourse(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsCourse",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldCourse(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldCourse",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public int DataDeleteByFieldCourse(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldCourse";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
	}

     }// End Class


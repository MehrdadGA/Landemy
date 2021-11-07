using System.Data;
using System.Data.SqlClient;

     public class StudentData
     {

	 public int DataInsertStudent(int ID ,string NationalCode ,string Name ,string LastName ,int FK_DegreeID ,byte Sex ,string DateOfBirth ,string Address ,string Phone ,string Image )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertStudent";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@NationalCode",NationalCode);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@LastName",LastName);
		Sqlcom.Parameters.AddWithValue("@FK_DegreeID",FK_DegreeID);
		Sqlcom.Parameters.AddWithValue("@Sex",Sex);
		Sqlcom.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
		Sqlcom.Parameters.AddWithValue("@Address",Address);
		Sqlcom.Parameters.AddWithValue("@Phone",Phone);
		Sqlcom.Parameters.AddWithValue("@Image",Image);
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

	 public int DataDeleteStudent(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteStudent";
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

	 public int DataUpdateStudent(int ID ,string NationalCode ,string Name ,string LastName ,int FK_DegreeID ,byte Sex ,string DateOfBirth ,string Address ,string Phone ,string Image )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateStudent";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@NationalCode",NationalCode);
		Sqlcom.Parameters.AddWithValue("@Name",Name);
		Sqlcom.Parameters.AddWithValue("@LastName",LastName);
		Sqlcom.Parameters.AddWithValue("@FK_DegreeID",FK_DegreeID);
		Sqlcom.Parameters.AddWithValue("@Sex",Sex);
		Sqlcom.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
		Sqlcom.Parameters.AddWithValue("@Address",Address);
		Sqlcom.Parameters.AddWithValue("@Phone",Phone);
		Sqlcom.Parameters.AddWithValue("@Image",Image);
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

	 public DataTable DataGetListStudent()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListStudent",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsStudent(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsStudent",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldStudent(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldStudent",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public int DataDeleteByFieldStudent(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldStudent";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
	}

     }// End Class


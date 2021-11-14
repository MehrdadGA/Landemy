using System.Data;
using System.Data.SqlClient;

     public class CourseGroupData
     {

	 public int DataInsertCourseGroup(int ID ,int Year ,byte Term ,byte LevelCourse ,string Tuition ,string WeekPlan ,byte ClassNumber ,int FK_TeacherID ,int FK_CourseID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertCourseGroup";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@Year",Year);
		Sqlcom.Parameters.AddWithValue("@Term",Term);
		Sqlcom.Parameters.AddWithValue("@LevelCourse",LevelCourse);
		Sqlcom.Parameters.AddWithValue("@Tuition",Tuition);
		Sqlcom.Parameters.AddWithValue("@WeekPlan",WeekPlan);
		Sqlcom.Parameters.AddWithValue("@ClassNumber",ClassNumber);
		Sqlcom.Parameters.AddWithValue("@FK_TeacherID",FK_TeacherID);
		Sqlcom.Parameters.AddWithValue("@FK_CourseID",FK_CourseID);
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

	 public int DataDeleteCourseGroup(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteCourseGroup";
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

	 public int DataUpdateCourseGroup(int ID ,int Year ,byte Term ,byte LevelCourse ,string Tuition ,string WeekPlan ,byte ClassNumber ,int FK_TeacherID ,int FK_CourseID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdateCourseGroup";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@Year",Year);
		Sqlcom.Parameters.AddWithValue("@Term",Term);
		Sqlcom.Parameters.AddWithValue("@LevelCourse",LevelCourse);
		Sqlcom.Parameters.AddWithValue("@Tuition",Tuition);
		Sqlcom.Parameters.AddWithValue("@WeekPlan",WeekPlan);
		Sqlcom.Parameters.AddWithValue("@ClassNumber",ClassNumber);
		Sqlcom.Parameters.AddWithValue("@FK_TeacherID",FK_TeacherID);
		Sqlcom.Parameters.AddWithValue("@FK_CourseID",FK_CourseID);
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

	 public DataTable DataGetListCourseGroup()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListCourseGroup",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsCourseGroup(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsCourseGroup",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldCourseGroup(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldCourseGroup",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public int DataDeleteByFieldCourseGroup(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldCourseGroup";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
	}

     }// End Class


using System.Data;
using System.Data.SqlClient;

     public class PaymentData
     {

	 public int DataInsertPayment(int ID ,string TracingID ,string Amount ,string PaymentDate ,string DocNumber ,int FK_PayTypeID ,int FK_BankID ,int FK_StudentID ,string Description )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spInsertPayment";
		Sqlcom.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
		Sqlcom.Parameters.AddWithValue("@TracingID",TracingID);
		Sqlcom.Parameters.AddWithValue("@Amount",Amount);
		Sqlcom.Parameters.AddWithValue("@PaymentDate",PaymentDate);
		Sqlcom.Parameters.AddWithValue("@DocNumber",DocNumber);
		Sqlcom.Parameters.AddWithValue("@FK_PayTypeID",FK_PayTypeID);
		Sqlcom.Parameters.AddWithValue("@FK_BankID",FK_BankID);
		Sqlcom.Parameters.AddWithValue("@FK_StudentID",FK_StudentID);
		Sqlcom.Parameters.AddWithValue("@Description",Description);
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

	 public int DataDeletePayment(int ID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeletePayment";
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

	 public int DataUpdatePayment(int ID ,string TracingID ,string Amount ,string PaymentDate ,string DocNumber ,int FK_PayTypeID ,int FK_BankID ,int FK_StudentID ,string Description )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spUpdatePayment";
		Sqlcom.Parameters.AddWithValue("@ID",ID);
		Sqlcom.Parameters.AddWithValue("@TracingID",TracingID);
		Sqlcom.Parameters.AddWithValue("@Amount",Amount);
		Sqlcom.Parameters.AddWithValue("@PaymentDate",PaymentDate);
		Sqlcom.Parameters.AddWithValue("@DocNumber",DocNumber);
		Sqlcom.Parameters.AddWithValue("@FK_PayTypeID",FK_PayTypeID);
		Sqlcom.Parameters.AddWithValue("@FK_BankID",FK_BankID);
		Sqlcom.Parameters.AddWithValue("@FK_StudentID",FK_StudentID);
		Sqlcom.Parameters.AddWithValue("@Description",Description);
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

	 public DataTable DataGetListPayment()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListPayment",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsPayment(int ID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsPayment",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ID",ID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DataDetailsByFieldPayment(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldPayment",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public int DataDeleteByFieldPayment(string FieldName,string  value)
	{
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="spDeleteByFieldPayment";
		SqlCon Scon = new SqlCon();
		Sqlcom.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlcom.Parameters.AddWithValue("@Value", value );
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
	}

     }// End Class


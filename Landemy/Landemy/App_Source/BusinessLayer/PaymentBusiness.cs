
using System.Data;


     public class PaymentBusiness
     {

	public int Insert(Payment  objPayment) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataInsertPayment(  objPayment.ID , objPayment.TracingID , objPayment.Amount , objPayment.PaymentDate , objPayment.DocNumber , objPayment.FK_PayTypeID , objPayment.FK_BankID , objPayment.FK_StudentID , objPayment.Description );
	}


	public int Update(Payment  objPayment) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataUpdatePayment(  objPayment.ID , objPayment.TracingID , objPayment.Amount , objPayment.PaymentDate , objPayment.DocNumber , objPayment.FK_PayTypeID , objPayment.FK_BankID , objPayment.FK_StudentID , objPayment.Description );
	}


	public int Delete(Payment  objPayment) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataDeletePayment( objPayment.ID );
	}


	public  DataTable GetList( ) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataGetListPayment();
	}

	public  DataTable Details(Payment  objPayment) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataDetailsPayment( objPayment.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataDetailsByFieldPayment(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		PaymentData  objData = new PaymentData();
		return  objData.DataDeleteByFieldPayment(FieldName,value);
	}

     }// End Class


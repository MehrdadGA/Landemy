
using System.Data;


     public class BankBusiness
     {

	public int Insert(Bank  objBank) 
	{
		BankData  objData = new BankData();
		return  objData.DataInsertBank(  objBank.ID , objBank.Name );
	}


	public int Update(Bank  objBank) 
	{
		BankData  objData = new BankData();
		return  objData.DataUpdateBank(  objBank.ID , objBank.Name );
	}


	public int Delete(Bank  objBank) 
	{
		BankData  objData = new BankData();
		return  objData.DataDeleteBank( objBank.ID );
	}


	public  DataTable GetList( ) 
	{
		BankData  objData = new BankData();
		return  objData.DataGetListBank();
	}

	public  DataTable Details(Bank  objBank) 
	{
		BankData  objData = new BankData();
		return  objData.DataDetailsBank( objBank.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		BankData  objData = new BankData();
		return  objData.DataDetailsByFieldBank(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		BankData  objData = new BankData();
		return  objData.DataDeleteByFieldBank(FieldName,value);
	}

     }// End Class


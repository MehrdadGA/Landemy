
using System.Data;


     public class UsersBusiness
     {

	public int Insert(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataInsertUsers(  objUsers.ID , objUsers.Name , objUsers.LastName , objUsers.UserName , objUsers.Password , objUsers.FK_PermissionID , objUsers.FK_SecurityQuestionID , objUsers.Answer );
	}


	public int Update(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataUpdateUsers(  objUsers.ID , objUsers.Name , objUsers.LastName , objUsers.UserName , objUsers.Password , objUsers.FK_PermissionID , objUsers.FK_SecurityQuestionID , objUsers.Answer );
	}


	public int Delete(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDeleteUsers( objUsers.ID );
	}


	public  DataTable GetList( ) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataGetListUsers();
	}

	public  DataTable Details(Users  objUsers) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDetailsUsers( objUsers.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDetailsByFieldUsers(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		UsersData  objData = new UsersData();
		return  objData.DataDeleteByFieldUsers(FieldName,value);
	}

     }// End Class


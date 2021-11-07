
using System.Data;


     public class TeacherBusiness
     {

	public int Insert(Teacher  objTeacher) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataInsertTeacher(  objTeacher.ID , objTeacher.NationalCode , objTeacher.Name , objTeacher.LastName , objTeacher.FK_DegreeID , objTeacher.DateOfBirth , objTeacher.Sex , objTeacher.Phone , objTeacher.Address );
	}


	public int Update(Teacher  objTeacher) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataUpdateTeacher(  objTeacher.ID , objTeacher.NationalCode , objTeacher.Name , objTeacher.LastName , objTeacher.FK_DegreeID , objTeacher.DateOfBirth , objTeacher.Sex , objTeacher.Phone , objTeacher.Address );
	}


	public int Delete(Teacher  objTeacher) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataDeleteTeacher( objTeacher.ID );
	}


	public  DataTable GetList( ) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataGetListTeacher();
	}

	public  DataTable Details(Teacher  objTeacher) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataDetailsTeacher( objTeacher.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataDetailsByFieldTeacher(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		TeacherData  objData = new TeacherData();
		return  objData.DataDeleteByFieldTeacher(FieldName,value);
	}

     }// End Class


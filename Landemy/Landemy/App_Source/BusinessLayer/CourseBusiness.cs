
using System.Data;


     public class CourseBusiness
     {

	public int Insert(Course  objCourse) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataInsertCourse(  objCourse.ID , objCourse.Title , objCourse.LevelCount , objCourse.Tuition );
	}


	public int Update(Course  objCourse) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataUpdateCourse(  objCourse.ID , objCourse.Title , objCourse.LevelCount , objCourse.Tuition );
	}


	public int Delete(Course  objCourse) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataDeleteCourse( objCourse.ID );
	}


	public  DataTable GetList( ) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataGetListCourse();
	}

	public  DataTable Details(Course  objCourse) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataDetailsCourse( objCourse.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataDetailsByFieldCourse(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		CourseData  objData = new CourseData();
		return  objData.DataDeleteByFieldCourse(FieldName,value);
	}

     }// End Class


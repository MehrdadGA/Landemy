
using System.Data;


     public class CourseSelectBusiness
     {

	public int Insert(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataInsertCourseSelect(  objCourseSelect.ID , objCourseSelect.ActivityScore , objCourseSelect.FinalScore , objCourseSelect.AttendScore , objCourseSelect.FK_CourseGroupID , objCourseSelect.FK_StudentID );
	}


	public int Update(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataUpdateCourseSelect(  objCourseSelect.ID , objCourseSelect.ActivityScore , objCourseSelect.FinalScore , objCourseSelect.AttendScore , objCourseSelect.FK_CourseGroupID , objCourseSelect.FK_StudentID );
	}


	public int Delete(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDeleteCourseSelect( objCourseSelect.ID );
	}


	public  DataTable GetList( ) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataGetListCourseSelect();
	}

	public  DataTable Details(CourseSelect  objCourseSelect) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDetailsCourseSelect( objCourseSelect.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDetailsByFieldCourseSelect(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		CourseSelectData  objData = new CourseSelectData();
		return  objData.DataDeleteByFieldCourseSelect(FieldName,value);
	}

     }// End Class


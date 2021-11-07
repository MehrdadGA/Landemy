
using System.Data;


     public class CourseGroupBusiness
     {

	public int Insert(CourseGroup  objCourseGroup) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataInsertCourseGroup(  objCourseGroup.ID , objCourseGroup.Year , objCourseGroup.Term , objCourseGroup.LevelCourse , objCourseGroup.Tuition , objCourseGroup.WeekPlan , objCourseGroup.ClassNumber , objCourseGroup.FK_TeacherID , objCourseGroup.FK_CourseID );
	}


	public int Update(CourseGroup  objCourseGroup) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataUpdateCourseGroup(  objCourseGroup.ID , objCourseGroup.Year , objCourseGroup.Term , objCourseGroup.LevelCourse , objCourseGroup.Tuition , objCourseGroup.WeekPlan , objCourseGroup.ClassNumber , objCourseGroup.FK_TeacherID , objCourseGroup.FK_CourseID );
	}


	public int Delete(CourseGroup  objCourseGroup) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataDeleteCourseGroup( objCourseGroup.ID );
	}


	public  DataTable GetList( ) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataGetListCourseGroup();
	}

	public  DataTable Details(CourseGroup  objCourseGroup) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataDetailsCourseGroup( objCourseGroup.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataDetailsByFieldCourseGroup(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		CourseGroupData  objData = new CourseGroupData();
		return  objData.DataDeleteByFieldCourseGroup(FieldName,value);
	}

     }// End Class


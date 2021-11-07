
     public class CourseGroup
     {

	 private   int  _ID ;   
	 private   byte  _Year ;   
	 private   byte  _Term ;   
	 private   byte  _LevelCourse ;   
	 private   string  _Tuition ;   
	 private   string  _WeekPlan ;   
	 private   byte  _ClassNumber ;   
	 private   int  _FK_TeacherID ;   
	 private   int  _FK_CourseID ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  byte   Year {
		 get{  return _Year; }
		 set{_Year=  value;}
	}

 
	 public  byte   Term {
		 get{  return _Term; }
		 set{_Term=  value;}
	}

 
	 public  byte   LevelCourse {
		 get{  return _LevelCourse; }
		 set{_LevelCourse=  value;}
	}

 
	 public  string   Tuition {
		 get{  return _Tuition; }
		 set{_Tuition=  value;}
	}

 
	 public  string   WeekPlan {
		 get{  return _WeekPlan; }
		 set{_WeekPlan=  value;}
	}

 
	 public  byte   ClassNumber {
		 get{  return _ClassNumber; }
		 set{_ClassNumber=  value;}
	}

 
	 public  int   FK_TeacherID {
		 get{  return _FK_TeacherID; }
		 set{_FK_TeacherID=  value;}
	}

 
	 public  int   FK_CourseID {
		 get{  return _FK_CourseID; }
		 set{_FK_CourseID=  value;}
	}


     }// End Class


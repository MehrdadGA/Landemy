
     public class CourseSelect
     {

	 private   int  _ID ;   
	 private   decimal  _ActivityScore ;   
	 private   decimal  _FinalScore ;   
	 private   decimal  _AttendScore ;   
	 private   int  _FK_CourseGroupID ;   
	 private   int  _FK_StudentID ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  decimal   ActivityScore {
		 get{  return _ActivityScore; }
		 set{_ActivityScore=  value;}
	}

 
	 public  decimal   FinalScore {
		 get{  return _FinalScore; }
		 set{_FinalScore=  value;}
	}

 
	 public  decimal   AttendScore {
		 get{  return _AttendScore; }
		 set{_AttendScore=  value;}
	}

 
	 public  int   FK_CourseGroupID {
		 get{  return _FK_CourseGroupID; }
		 set{_FK_CourseGroupID=  value;}
	}

 
	 public  int   FK_StudentID {
		 get{  return _FK_StudentID; }
		 set{_FK_StudentID=  value;}
	}


     }// End Class


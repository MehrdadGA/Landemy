
     public class Users
     {

	 private   int  _ID ;   
	 private   string  _Name ;   
	 private   string  _LastName ;   
	 private   string  _UserName ;   
	 private   string  _Password ;   
	 private   int  _FK_PermissionID ;   
	 private   int  _FK_SecurityQuestionID ;   
	 private   string  _Answer ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  string   Name {
		 get{  return _Name; }
		 set{_Name=  value;}
	}

 
	 public  string   LastName {
		 get{  return _LastName; }
		 set{_LastName=  value;}
	}

 
	 public  string   UserName {
		 get{  return _UserName; }
		 set{_UserName=  value;}
	}

 
	 public  string   Password {
		 get{  return _Password; }
		 set{_Password=  value;}
	}

 
	 public  int   FK_PermissionID {
		 get{  return _FK_PermissionID; }
		 set{_FK_PermissionID=  value;}
	}

 
	 public  int   FK_SecurityQuestionID {
		 get{  return _FK_SecurityQuestionID; }
		 set{_FK_SecurityQuestionID=  value;}
	}

 
	 public  string   Answer {
		 get{  return _Answer; }
		 set{_Answer=  value;}
	}


     }// End Class


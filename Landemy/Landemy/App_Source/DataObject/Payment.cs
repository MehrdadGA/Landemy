
     public class Payment
     {

	 private   int  _ID ;   
	 private   string  _TracingID ;   
	 private   string  _Amount ;   
	 private   string  _PaymentDate ;   
	 private   string  _DocNumber ;   
	 private   int  _FK_PayTypeID ;   
	 private   int  _FK_BankID ;   
	 private   int  _FK_StudentID ;   
	 private   string  _Description ;   


 
	 public  int   ID {
		 get{  return _ID; }
		 set{_ID=  value;}
	}

 
	 public  string   TracingID {
		 get{  return _TracingID; }
		 set{_TracingID=  value;}
	}

 
	 public  string   Amount {
		 get{  return _Amount; }
		 set{_Amount=  value;}
	}

 
	 public  string   PaymentDate {
		 get{  return _PaymentDate; }
		 set{_PaymentDate=  value;}
	}

 
	 public  string   DocNumber {
		 get{  return _DocNumber; }
		 set{_DocNumber=  value;}
	}

 
	 public  int   FK_PayTypeID {
		 get{  return _FK_PayTypeID; }
		 set{_FK_PayTypeID=  value;}
	}

 
	 public  int   FK_BankID {
		 get{  return _FK_BankID; }
		 set{_FK_BankID=  value;}
	}

 
	 public  int   FK_StudentID {
		 get{  return _FK_StudentID; }
		 set{_FK_StudentID=  value;}
	}

 
	 public  string   Description {
		 get{  return _Description; }
		 set{_Description=  value;}
	}


     }// End Class


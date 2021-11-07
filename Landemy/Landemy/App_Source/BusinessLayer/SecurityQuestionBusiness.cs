﻿
using System.Data;


     public class SecurityQuestionBusiness
     {

	public int Insert(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataInsertSecurityQuestion(  objSecurityQuestion.ID , objSecurityQuestion.Question , objSecurityQuestion.Description );
	}


	public int Update(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataUpdateSecurityQuestion(  objSecurityQuestion.ID , objSecurityQuestion.Question , objSecurityQuestion.Description );
	}


	public int Delete(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDeleteSecurityQuestion( objSecurityQuestion.ID );
	}


	public  DataTable GetList( ) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataGetListSecurityQuestion();
	}

	public  DataTable Details(SecurityQuestion  objSecurityQuestion) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDetailsSecurityQuestion( objSecurityQuestion.ID );
	}


	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDetailsByFieldSecurityQuestion(FieldName,value);
	}

	public  int DeleteByField(string FieldName,string  value) 
	{
		SecurityQuestionData  objData = new SecurityQuestionData();
		return  objData.DataDeleteByFieldSecurityQuestion(FieldName,value);
	}

     }// End Class


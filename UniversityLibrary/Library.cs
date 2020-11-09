using System;
namespace UniversityLibrary
{
    public  class Library : IDefaulters
    {
        public Students StudentDetails{get;set;}
        public Book BookDetails{get;set;}
        public string DateIssue{get;set;}
        public string DateReturned{get;set;}
        public string StudentName { get; set; }
        public string StudentID { get; set; }
        public string YearStudy { get; set; }

        public int issueDate;
        public int returnDate;
        public double DaysReturn;
     
      
      


        public Library(Students studentdetails, Book bookdetails, string dateissue, string datereturn, string studentname, string studentid, string yearstudy)
        {
            StudentDetails = studentdetails;
            BookDetails = bookdetails;
            DateIssue = dateissue;
            DateReturned = datereturn;
             StudentName = studentname;
            StudentID = studentid;
            YearStudy = yearstudy;
        }
        
        public string GetName()
        {
            return $"Student Name : {StudentDetails.StudentName}";
        }

        public string GetYear()
        {
            return $"Student Year : {StudentDetails.YearStudy}";
        }

        public string GetBook()
        {
           return $"Book Name: {BookDetails.BookName}\nBook ID:{BookDetails.BookID}";
        }

        public string GetDateReturn()
        {
            
                
            System.DateTime issueDate = Convert.ToDateTime(DateIssue);
            System.DateTime returnDate = issueDate.AddDays(+14);
            TimeSpan DateDifferent = returnDate - issueDate;
            double Days = DateDifferent.TotalDays;
            System.DateTime returnedDate = Convert.ToDateTime(DateReturned);
            TimeSpan DateReturnedDifferent = returnedDate - issueDate;
            DaysReturn = DateReturnedDifferent.TotalDays;
            return  $"The expected return date is: {returnDate}";
        }

        public string GetDefaulter()
        {GetDateReturn();
             if(DaysReturn > 14){
                return $"{GetName()} is a defaulter,hasn't returned.\n{GetBook()}\n ";
            }
            return $"{GetName()} Is not a defaulter";
        }

         public override string ToString()
        {
            return $"{GetDefaulter()}";
        }

    }
}
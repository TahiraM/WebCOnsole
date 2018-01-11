using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace DevelopedWeb
{
    public class CStudentDetails
    {
          
 
        public string studentname;
 
        public int[] studentmarks = new int[5];
 
        public int totalmarks;
 
    
    }
    class CStudents 
    { 
 
        public List<CStudentDetails> studList = new List<CStudentDetails>(); 
 
        //This list contains the student list 
 
        public int MaxStudents; 
 
 
 #region "Function that adds record"  
        //This Function Adds the Record 
        public int AddRecord(string name, int[] marks) 
        { 
 
            CStudentDetails stud = new CStudentDetails(); 
 
            stud.studentname = name; 
 
            stud.studentmarks = marks; 
 
            stud.totalmarks = 0; 
 
            for (int i = 0; i < 5; i++) 
 
                stud.totalmarks += stud.studentmarks[i]; 
 
            studList.Add(stud); 
 
            MaxStudents = studList.Count; 
 
            return 1; 
 
        } 
#endregion 
 
    } 
}
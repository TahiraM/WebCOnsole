using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DevelopedWeb
{
    public class Program
    {
        private static CStudents theStudents = new CStudents();

        internal static CStudents TheStudents { get => theStudents; set => theStudents = value; }

        static public void ViewRecords() 
{ 
 
 
 
    Console.WriteLine("_______________________________________________________________"); 
 
 
 
    Console.WriteLine("SNo Student Name        ENG   MATH   PHY    CHE    BIO     Total"); 
 
    Console.WriteLine("_______________________________________________________________"); 
 
 
 
    for (int i = 0; i < TheStudents.MaxStudents; i++) 
    { 
 
        Console.Write("{0, -5}", i + 1); 
 
        Console.Write("{0, -19}", TheStudents.studList[i].studentname); 
 
        Console.Write("{0, -7}", TheStudents.studList[i].studentmarks[0]); 
 
        Console.Write("{0, -7}", TheStudents.studList[i].studentmarks[1]); 
 
        Console.Write("{0, -7}", TheStudents.studList[i].studentmarks[2]); 
 
        Console.Write("{0, -7}", TheStudents.studList[i].studentmarks[3]); 
 
        Console.Write("{0, -7}", TheStudents.studList[i].studentmarks[4]); 
 
        Console.Write("{0, -7}", TheStudents.studList[i].totalmarks); 
 
        Console.WriteLine(); 
 
    } 
    
    Console.WriteLine("_______________________________________________________________"); 
 
} 
 
 
static public void InputRecords() 
 
{    
 
      Console.Write("Student Name: "); 
 
      string name; 
 
      int[] marks = new int[5]; 
 
      name = Console.ReadLine(); 
 
  
 
      for(int i = 1; i <= 5; i++) 
 
      { 
 
            Console.Write("Sub " + i.ToString() + " Mark: "); 
 
            marks[i-1] = Convert.ToInt32(Console.ReadLine()); 
 
      } 
 
      TheStudents.AddRecord(name, marks); 
 
}
        public static void Main(string[] args)
        {
 Console.WriteLine("Student MarkList Application"); 
 
      Console.Write("Enter the Total number  of students: "); 
 
      int numStudents = -1; 
 
      string s = Console.ReadLine(); 
 
      numStudents = Convert.ToInt32(s); 
 
  
 
      for (int i = 1; i <= numStudents; i++) 
 
      { 
 
            Console.WriteLine("\nEnter " + i.ToString() + " Student Information\n"); 
 
            InputRecords(); 
 
      } 
 
      ViewRecords(); 
 
      char ch = Console.ReadKey().KeyChar; 
 
} 
         }

    }


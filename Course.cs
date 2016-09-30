using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Course
/// </summary>
public class Course
{
    public string courseNme { get; set; }
    public string courseNumber { get; set; }
  public List<Students> studentList { get; set; }
    public bool IsEmpty { get { return studentList.Count == 0; } }



    public Course(string courseNme, string courseNumber)
    {
        this.courseNme = courseNme;
        this.courseNumber = courseNumber;
        this.studentList = new List<Students>();
    }
    public void AddStudents(Students student)
    {
        studentList.Add(student);
    }
    public Course(List<Students> students) {

        this.studentList = students;
    }
    public override string ToString()
    {
        return
            courseNme + " " + courseNumber;
    }

}

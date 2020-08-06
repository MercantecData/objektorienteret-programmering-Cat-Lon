using System;
using System.Collections.Generic;
using SchoolSystem;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("Mercantec");
            school.AddTeam();
            school.AddStudent("William :)");
            List<Students> students = school.GetStudents();
            List<Teachers> teachers = school.GetTeachers();
            List<Teams> teams = school.GetTeams();

            students[0].RemoveFromTeam();
            teachers[0].AddToTeam(teams[0],teachers[0]);
            teams[0].GetStudents();
        }
    }
}

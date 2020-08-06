using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class School
    {
        private List<Students> studentsList;
        private List<Teachers> teachersList;
        private List<Teams> teamList;
        private int teamNumber = 1;
        private string name;
        public School(string name)
        {
            this.name = name;
            this.studentsList = new List<Students>();
            this.teachersList = new List<Teachers>();
            this.teamList = new List<Teams>();
        }
        public List<Teachers> GetTeachers()
        {
            return teachersList;
        }
        public List<Students> GetStudents()
        {
            return studentsList;
        }
        public List<Teams> GetTeams()
        {
            return teamList;
        }
        public void AddStudent(string name, Teams team)
        {
            var student = new Students(name, team);
            studentsList.Add(student);
        }
        public void AddStudent(string name)
        {
            var student =  new Students(name);
            studentsList.Add(student);
        }
        public void AddTeacher(string name, Teams team)
        {
            var teacher = new Teachers(name, team);
            teachersList.Add(teacher);
        }
        public void AddTeacher(string name)
        {
            var teacher = new Teachers(name);
            teachersList.Add(teacher);
        }
        public void AddTeam()
        {
            var team = new Teams(teamNumber);
            teamList.Add(team);
            teamNumber++;
        }
    }
}

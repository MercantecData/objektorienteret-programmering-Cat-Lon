using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SchoolSystem
{
    public class Teams
    {
        private int teamNumber;
        private List<Students> studentsMemberList;
        private List<Teachers> teachersMemberList;
        private int i = 0;
        private bool bRemoved;

        public Teams(int teamNumber)
        {
            this.teamNumber = teamNumber;
            this.studentsMemberList = new List<Students>();
            this.teachersMemberList = new List<Teachers>();
        }
        public int GetThisTeamNumber()
        {
            return teamNumber;
        }
        public void MakeMember(Students student)
        {
            studentsMemberList.Add(student);
        }
        public void MakeMember(Teachers teachers)
        {
            teachersMemberList.Add(teachers);
        }
        public bool RemoveMember(Students student)
        {
            bRemoved = false;
            foreach(Students element in studentsMemberList)
            {
                if(studentsMemberList[i] == student)
                {
                    studentsMemberList.RemoveAt(i);
                    bRemoved = true;
                    return true;
                }
                i++;
            }
            if (!bRemoved)
            {
                Console.WriteLine("Student not in team");
                return false;
            }
            else { return true; }
        }
        public bool RemoveMember(Teachers teachers)
        {
            bRemoved = false;
            foreach (Teachers element in teachersMemberList)
            {
                if (teachersMemberList[i] == teachers)
                {
                    teachersMemberList.RemoveAt(i);
                    bRemoved = true;
                    return true;
                }
                i++;
            }
            if (!bRemoved)
            {
                Console.WriteLine("Student not in team");
                return false;
            }
            else { return true; }
        }
        public List<Students> GetStudents()
        {
            return studentsMemberList;
        }
        public List<Teachers> GetTeachers()
        {
            return teachersMemberList;
        }
    }
}

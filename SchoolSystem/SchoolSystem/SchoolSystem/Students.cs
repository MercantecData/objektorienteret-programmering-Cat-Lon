using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class Students
    {
        private string name;
        private Teams team;

        public Students(string name, Teams team)
        {
            this.name = name;
            this.team = team;
        }

        public Students(string name)
        {
            this.name = name;
            this.team = null;
        }
        public void AddToTeam(Teams team, Students student)
        {
            if(this.team != null)
            {
                this.team.RemoveMember(student);
            }
            this.team = team;
        }
        public void RemoveFromTeam()
        {
            this.team = null;
        }
    }
}

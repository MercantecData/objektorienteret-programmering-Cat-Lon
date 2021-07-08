using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class Teachers
    {
        private string name;
        private bool bHasBeenPaid;
        private Teams team;
        private Teachers teachers;
        public Teachers(string name)
        {
            this.name = name;
            this.bHasBeenPaid = false;
        }
        public Teachers(string name, Teams teams)
        {
            this.name = name;
            this.team = teams;
            this.bHasBeenPaid = false;
        }
        public void AddToTeam(Teams team)
        { 
            if(this.team != null) { this.team.RemoveMember(teachers); }
            this.team = team;
        }
        public void RemoveFromTeam()
        {
            this.team = null;
        }
        public int GetNumber()
        {
            return team.GetThisTeamNumber();
        }
        public bool HasBeenPaid()
        {
            return bHasBeenPaid;
        }
    }
}

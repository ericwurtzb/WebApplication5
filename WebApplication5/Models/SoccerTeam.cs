using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class SoccerTeam : Team
    {
        public int draw { get; set; }
        public int goalsfor { get; set; }
        public int goalsAgainst { get; set; }
        public int differential { get; set; }
        public int points { get; set; }

        public SoccerTeam()
        {

        }
        public SoccerTeam(string sName, int iPoints)
        {
            base.teamName = sName;
            base.teamPoints = iPoints;
        }
    }
}
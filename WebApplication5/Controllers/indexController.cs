using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class IndexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            List<SoccerTeam> listSoccerTeams = new List<SoccerTeam>();
            List<SoccerTeam> listSorted = new List<SoccerTeam>();
            int iTeamRank = 0;

            //Load Data

            listSoccerTeams.Add(new SoccerTeam("RSL", 35));
            listSoccerTeams.Add(new SoccerTeam("Colorado", 24));
            listSoccerTeams.Add(new SoccerTeam("FC Dallas", 42));
            listSoccerTeams.Add(new SoccerTeam("Sporting KC", 39));
            listSoccerTeams.Add(new SoccerTeam("San Jose", 16));
            listSoccerTeams.Add(new SoccerTeam("Houston", 27));
            listSoccerTeams.Add(new SoccerTeam("Seattle", 32));
            listSoccerTeams.Add(new SoccerTeam("Vancouver", 33));
            listSoccerTeams.Add(new SoccerTeam("Minnesota", 28));
            listSoccerTeams.Add(new SoccerTeam("Portland", 37));
            listSoccerTeams.Add(new SoccerTeam("LA Galaxy", 37));
            listSoccerTeams.Add(new SoccerTeam("LAFC", 39));

            listSorted = listSoccerTeams.OrderByDescending(oTeam => oTeam.teamPoints).ToList();

            ViewBag.teamNames = listSorted;

            return View();
        }
    }
}
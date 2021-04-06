using BowlingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingApp.Components
{
    public class TeamNameViewComponent : ViewComponent
    {
        private BowlingLeagueContext context; 
        public TeamNameViewComponent (BowlingLeagueContext con)
        {
            context = con;
        }
        public IViewComponentResult Invoke()
        {
            
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

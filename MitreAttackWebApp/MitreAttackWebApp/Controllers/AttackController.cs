using MitreAttackWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MitreAttackWebApp.Controllers
{
    public class AttackController : Controller
    {
        private AttackDbContext db = new AttackDbContext();

        // GET: Attack/T1518
        public ActionResult T1518(DateTime? filterDate)
        {
            var attacksT1518 = db.Attacks.Where(a => a.AttackCode == "T1518");

            if (filterDate.HasValue)
            {
                DateTime filterDateValue = filterDate.Value.Date;
                attacksT1518 = attacksT1518.Where(a => DbFunctions.TruncateTime(a.AttackDate) == filterDateValue);
            }

            var filteredAttacks = attacksT1518.ToList();

            foreach (var attack in filteredAttacks)
            {
                string searchString = "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Internet Explorer svcVersion       REG_SZ    ";
                int startIndex = searchString.Length;
                attack.AttackResult = "Internet Explorer " + attack.AttackResult.Substring(startIndex);
            }

            return View(filteredAttacks);
        }



        // GET: Attack/T1614
        public ActionResult T1614(DateTime? filterDate)
        {
            var attacksT1614 = db.Attacks.Where(a => a.AttackCode == "T1614");

            if (filterDate.HasValue)
            {
                DateTime filterDateValue = filterDate.Value.Date;
                attacksT1614 = attacksT1614.Where(a => DbFunctions.TruncateTime(a.AttackDate) == filterDateValue);
            }

            foreach (var attack in attacksT1614)
            {
                string searchString = "REG_MULTI_SZ    ";
                int index = attack.AttackResult.IndexOf(searchString) + searchString.Length;
                int endIndex = attack.AttackResult.IndexOf(" ", index);
                if (endIndex == -1) 
                    endIndex = attack.AttackResult.Length;
                attack.AttackResult = attack.AttackResult.Substring(index, endIndex - index);
            }

            return View(attacksT1614.ToList());
        }


    }
}

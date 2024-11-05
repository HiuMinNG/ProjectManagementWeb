using ProjectManagementWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagementWeb.Controllers
{
    public class XemTienDoUserController : Controller
    {

        QL_DAEntities database = new QL_DAEntities();
        // GET: XemTienDoUser
        public ActionResult XemTienDoUser()
        {
            return View(database.DuAn.ToList());
        }

        public ActionResult TaoTienDoUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TaoTienDoUser(DuAn duan)
        {
            database.DuAn.Add(duan);
            database.SaveChanges();
            return RedirectToAction("XemTienDoUser");
        }
        public ActionResult DetailsUser(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        public ActionResult EditUser(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult EditUser(int id, DuAn duAn)
        {
            database.Entry(duAn).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("XemTienDoUser");

        }
        
    }
}
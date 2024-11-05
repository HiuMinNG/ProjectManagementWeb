using ProjectManagementWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagementWeb.Controllers
{
    public class AdminController : Controller
    {
        QL_DAEntities database = new QL_DAEntities();
        // GET: Admin
        public ActionResult HomeAdmin()
        {
            return View();
        }
        public ActionResult XemTienDo()
        {
            return View(database.DuAn.ToList());
        }

        public ActionResult TaoTienDo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TaoTienDo(DuAn duan)
        {
            database.DuAn.Add(duan);
            database.SaveChanges();
            return RedirectToAction("XemTienDo");
        }
        public ActionResult Details(int id)
        {
            return View(database.DuAn.Where(s =>s.DuAnID == id ).FirstOrDefault());
        }
        public ActionResult Edit(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id,DuAn duAn)
        {
            database.Entry(duAn).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("XemTienDo");

        }
        public ActionResult Delete(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, DuAn duAn)
        {
            duAn = database.DuAn.Where((s) => s.DuAnID == id).FirstOrDefault();
            database.DuAn.Remove(duAn);
            database.SaveChanges();
            return RedirectToAction("XemTienDo");

        }
        public ActionResult TheoDoiSprint()
        {
            return View(database.Sprint.ToList());
        }
        public ActionResult TaoSprint()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TaoSprint(Sprint sprint)
        {
            database.Sprint.Add(sprint);
            database.SaveChanges();
            return RedirectToAction("TheoDoiSprint");
        }
        public ActionResult XoaSprint(int id)
        {
            return View(database.Sprint.Where(s => s.SprintID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult XoaSprint(int id, Sprint sprint)
        {
            sprint = database.Sprint.Where((s) => s.SprintID == id).FirstOrDefault();
            database.Sprint.Remove(sprint);
            database.SaveChanges();
            return RedirectToAction("TheoDoiSprint");

        }
        public ActionResult ThongTinSprint(int id)
        {
            return View(database.Sprint.Where(s => s.SprintID == id).FirstOrDefault());
        }

        public ActionResult SuaSprint(int id)
        {
            return View(database.Sprint.Where(s => s.SprintID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult SuaSprint(int id, Sprint sprint)
        {
            database.Entry(sprint).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("TheoDoiSprint");

        }

    }
}
using ProjectManagementWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagementWeb.Controllers
{
    public class UserController : Controller
    {
        QL_DAEntities database = new QL_DAEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
      
        
        public ActionResult DuAn()
        {
            return View();
        }
        public ActionResult TaoDuAn()
        {
            return View();
        }
        public ActionResult XemDuAn()
        {
            return View(database.DuAn.ToList());
        }
        [HttpPost]
        public ActionResult TaoDuAn(DuAn duan)
        {
            database.DuAn.Add(duan);
            database.SaveChanges();
            return RedirectToAction("DuAn");
        }

        public ActionResult ThanhVien()
        {
            return View();
        }
        public ActionResult NhiemVu()
        {
            return View();
        }
        public ActionResult Lich()
        {
            return View();
        }


//Xem tiến độ
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
            return RedirectToAction("XemTienDo");
        }
        public ActionResult ThongTinTienDoUser(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        public ActionResult SuaTienDoUser(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult SuaTienDoUser(int id, DuAn duAn)
        {
            database.Entry(duAn).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("XemTienDo");

        }
        public ActionResult XoaTienDoUser(int id)
        {
            return View(database.DuAn.Where(s => s.DuAnID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult XoaTienDoUser(int id, DuAn duAn)
        {
            duAn = database.DuAn.Where((s) => s.DuAnID == id).FirstOrDefault();
            database.DuAn.Remove(duAn);
            database.SaveChanges();
            return RedirectToAction("XemTienDo");

        }
//Sprint User
        public ActionResult SprintUser()
        {
            return View(database.Sprint.ToList());
        }
        public ActionResult TaoSprintUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TaoSprintUser(Sprint sprint)
        {
            database.Sprint.Add(sprint);
            database.SaveChanges();
            return RedirectToAction("TheoDoiSprint");
        }
        public ActionResult XoaSprintUser(int id)
        {
            return View(database.Sprint.Where(s => s.SprintID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult XoaSprintUser(int id, Sprint sprint)
        {
            sprint = database.Sprint.Where((s) => s.SprintID == id).FirstOrDefault();
            database.Sprint.Remove(sprint);
            database.SaveChanges();
            return RedirectToAction("TheoDoiSprint");

        }
        public ActionResult ThongTinSprintUser(int id)
        {
            return View(database.Sprint.Where(s => s.SprintID == id).FirstOrDefault());
        }

        public ActionResult SuaSprintUser(int id)
        {
            return View(database.Sprint.Where(s => s.SprintID == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult SuaSprintUser(int id, Sprint sprint)
        {
            database.Entry(sprint).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("TheoDoiSprint");

        }
    }
}
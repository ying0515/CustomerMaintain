using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerMaintain.Models.Main;

namespace CustomerMaintain.Controllers
{
    public class 客戶資料狀況Controller : Controller
    {
        //private 客戶資料Entities db = new 客戶資料Entities();
        private 客戶資料狀況Repository rep = RepositoryHelper.Get客戶資料狀況Repository();

        // GET: 客戶資料狀況
        public ActionResult Index()
        {
            //return View(db.客戶資料狀況.ToList());
            return View(rep.All().ToList());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ((客戶資料Entities)rep.UnitOfWork.Context).Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

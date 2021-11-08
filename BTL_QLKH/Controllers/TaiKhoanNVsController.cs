using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_QLKH.Models;

namespace BTL_QLKH.Controllers
{
    public class TaiKhoanNVsController : Controller
    {
        private QLKHDbcontext db = new QLKHDbcontext();

        // GET: TaiKhoanNVs
        public ActionResult Index()
        {
            return View(db.TaiKhoanNVs.ToList());
        }

        // GET: TaiKhoanNVs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoanNV taiKhoanNV = db.TaiKhoanNVs.Find(id);
            if (taiKhoanNV == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoanNV);
        }

        // GET: TaiKhoanNVs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoanNVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,HoTenNV,TenTK,MatKhau,SDT")] TaiKhoanNV taiKhoanNV)
        {
            if (ModelState.IsValid)
            {
                db.TaiKhoanNVs.Add(taiKhoanNV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taiKhoanNV);
        }

        // GET: TaiKhoanNVs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoanNV taiKhoanNV = db.TaiKhoanNVs.Find(id);
            if (taiKhoanNV == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoanNV);
        }

        // POST: TaiKhoanNVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,HoTenNV,TenTK,MatKhau,SDT")] TaiKhoanNV taiKhoanNV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taiKhoanNV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taiKhoanNV);
        }

        // GET: TaiKhoanNVs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoanNV taiKhoanNV = db.TaiKhoanNVs.Find(id);
            if (taiKhoanNV == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoanNV);
        }

        // POST: TaiKhoanNVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TaiKhoanNV taiKhoanNV = db.TaiKhoanNVs.Find(id);
            db.TaiKhoanNVs.Remove(taiKhoanNV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

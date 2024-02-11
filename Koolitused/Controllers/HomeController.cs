using Koolitused.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koolitused.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        KoolitusContext db = new KoolitusContext();

        //Koolitus

        public ActionResult Koolitused()
        {
            IEnumerable<Koolitus> koolituss = db.Koolitus;
            return View(koolituss);
        }

        [HttpGet]
        public ActionResult koolitus_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult koolitus_Create(Koolitus koolituss)
        {
            db.Koolitus.Add(koolituss);
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }

        [HttpGet]
        public ActionResult koolitus_Delete(int id)
        {
            Koolitus koolituss = db.Koolitus.Find(id);
            if (koolituss == null)
            {
                return HttpNotFound();
            }
            return View(koolituss);
        }

        [HttpPost, ActionName("koolitus_Delete")]
        public ActionResult koolitus_DeleteConfirmed(int id)
        {
            Koolitus koolituss = db.Koolitus.Find(id);
            if (koolituss == null)
            {
                return HttpNotFound();
            }
            db.Koolitus.Remove(koolituss);
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }

        [HttpGet]
        public ActionResult koolitus_Edit(int? id)
        {
            Koolitus koolituss = db.Koolitus.Find(id);
            if (koolituss == null)
            {
                return HttpNotFound();
            }
            return View(koolituss);
        }

        [HttpPost, ActionName("koolitus_Edit")]
        public ActionResult koolitus_EditConfirmed(Koolitus koolituss)
        {
            db.Entry(koolituss).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }

        //Laps

        public ActionResult Laps()
        {
            IEnumerable<Laps> laps = db.Lapss;
            return View(laps);
        }

        [HttpGet]
        public ActionResult laps_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult laps_Create(Laps laps)
        {
            db.Lapss.Add(laps);
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        [HttpGet]
        public ActionResult laps_Delete(int id)
        {
            Laps laps = db.Lapss.Find(id);
            if (laps == null)
            {
                return HttpNotFound();
            }
            return View(laps);
        }

        [HttpPost, ActionName("laps_Delete")]
        public ActionResult laps_DeleteConfirmed(int id)
        {
            Laps laps = db.Lapss.Find(id);
            if (laps == null)
            {
                return HttpNotFound();
            }
            db.Lapss.Remove(laps);
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        [HttpGet]
        public ActionResult laps_Edit(int? id)
        {
            Laps laps = db.Lapss.Find(id);
            if (laps == null)
            {
                return HttpNotFound();
            }
            return View(laps);
        }

        [HttpPost, ActionName("laps_Edit")]
        public ActionResult laps_EditConfirmed(Laps laps)
        {
            db.Entry(laps).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        //Opetaja

        public ActionResult Opetaja()
        {
            IEnumerable<Opetaja> opetajas = db.Opetajas;
            return View(opetajas);
        }

        [HttpGet]
        public ActionResult opetaja_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult opetaja_Create(Opetaja opetajas)
        {
            db.Opetajas.Add(opetajas);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        [HttpGet]
        public ActionResult opetaja_Delete(int id)
        {
            Opetaja opetajas = db.Opetajas.Find(id);
            if (opetajas == null)
            {
                return HttpNotFound();
            }
            return View(opetajas);
        }

        [HttpPost, ActionName("opetaja_Delete")]
        public ActionResult opetaja_DeleteConfirmed(int id)
        {
            Opetaja opetajas = db.Opetajas.Find(id);
            if (opetajas == null)
            {
                return HttpNotFound();
            }
            db.Opetajas.Remove(opetajas);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        [HttpGet]
        public ActionResult opetaja_Edit(int? id)
        {
            Opetaja opetajas = db.Opetajas.Find(id);
            if (opetajas == null)
            {
                return HttpNotFound();
            }
            return View(opetajas);
        }

        [HttpPost, ActionName("opetaja_Edit")]
        public ActionResult opetaja_EditConfirmed(Opetaja opetajas)
        {
            db.Entry(opetajas).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        //Kursus

        public ActionResult Kursus()
        {
            IEnumerable<Kursus> kursus = db.Kursus;
            return View(kursus);
        }

        [HttpGet]
        public ActionResult kursus_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult kursus_Create(Kursus kursus)
        {
            db.Kursus.Add(kursus);
            db.SaveChanges();
            return RedirectToAction("Kursus");
        }

        [HttpGet]
        public ActionResult kursus_Delete(int id)
        {
            Kursus kursus = db.Kursus.Find(id);
            if (kursus == null)
            {
                return HttpNotFound();
            }
            return View(kursus);
        }

        [HttpPost, ActionName("kursus_Delete")]
        public ActionResult kursus_DeleteConfirmed(int id)
        {
            Kursus kursus = db.Kursus.Find(id);
            if (kursus == null)
            {
                return HttpNotFound();
            }
            db.Kursus.Remove(kursus);
            db.SaveChanges();
            return RedirectToAction("Kursus");
        }

        [HttpGet]
        public ActionResult kursus_Edit(int? id)
        {
            Kursus kursus = db.Kursus.Find(id);
            if (kursus == null)
            {
                return HttpNotFound();
            }
            return View(kursus);
        }

        [HttpPost, ActionName("kursus_Edit")]
        public ActionResult kursus_EditConfirmed(Kursus kursus)
        {
            db.Entry(kursus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Kursus");
        }
    }
}
using System.Net;
using System.Web.Mvc;
using GamisignmentDll;
using GamisignmentDll.Entities;

namespace GamiSignmentAdmin.Controllers
{
    public class RepeatsController : Controller
    {
        private readonly IManager<Repeat> _rm = new DllFacade().GetRepeatManager();

        // GET: Repeats
        public ActionResult Index()
        {
            return View(_rm.Read());
        }

        // GET: Repeats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repeat = _rm.Read(id.Value);
            if (repeat == null)
            {
                return HttpNotFound();
            }
            return View(repeat);
        }

        // GET: Repeats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repeats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TimesPrWeek,TimesPrUser")] Repeat repeat)
        {
            if (ModelState.IsValid)
            {
                _rm.Create(repeat);
                return RedirectToAction("Index");
            }

            return View(repeat);
        }

        // GET: Repeats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repeat = _rm.Read(id.Value);
            if (repeat == null)
            {
                return HttpNotFound();
            }
            return View(repeat);
        }

        // POST: Repeats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TimesPrWeek,TimesPrUser")] Repeat repeat)
        {
            if (ModelState.IsValid)
            {
                _rm.Update(repeat);
                return RedirectToAction("Index");
            }
            return View(repeat);
        }

        // GET: Repeats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repeat = _rm.Read(id.Value);
            if (repeat == null)
            {
                return HttpNotFound();
            }
            return View(repeat);
        }

        // POST: Repeats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _rm.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VartasFront1.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        /*  prWarrantyData, prIsStorageProductData, prSaldoPositiveData are booleans, but marked as strings so Exceptions won't be thrown.
         *  If the variable has a value of true (checkbox checked), returns "on" - if false, returns null. */
        [HttpPost]
        public ActionResult FormOne(string prNameData, string prEANData, string prCodeData, string prManufacturerData, string prCategoryData,
                            decimal prPriceData, string prWarrantyData, int prWarMonthData, string prIsStorageProductData, string prSaldoPositiveData, int prSaldoData)
        {
            return RedirectToAction("Redirect");
        }

        // Called by FormOne
        public ActionResult Redirect()
        {
            return View();
        }
    }



   

}
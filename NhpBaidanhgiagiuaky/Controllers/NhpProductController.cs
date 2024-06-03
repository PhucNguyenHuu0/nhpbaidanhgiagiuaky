using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhpBaidanhgiagiuaky.Models;

namespace NhpBaidanhgiagiuaky.Controllers
{
    public class NhpProductController : Controller
    {
        private static List<NhpProductController> NhpProducts = new List<NhpProductController>()
{
             new NhpProductController{nhpId=204, nhpName="Banh Bao", nhpImage="../Images/Anhbanhbao.png", nhpQuantity=24,nhpPrice=10000,nhpIsActive=true},
             new NhpProductController{nhpId=202, nhpName="Banh Ca", nhpImage="../Images/Anhbanhca.png", nhpQuantity=14,nhpPrice=12000,nhpIsActive=true}
};
        // GET: NhpProduct
        public ActionResult Index()
        {
            return View();
        }
        //Get: Create Products
        public ActionResult NhpCreate()
        {
            var NhpProduct = new NhpProductController ();
            return View(NhpProduct);
        }

        //Post: Create Products
        [HttpPost]
        public ActionResult NhpCreate(NhpProductController NhpProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(NhpProduct);
            }

            NhpProduct.Add(NhpProduct);
            return RedirectToAction("Index");
        }
    }
}
using NhpBaidanhgiagiuaky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NhpBaidanhgiagiuaky.Controllers
{
    public class NhpProductController : Controller
    {
        private static List<NhpProduct> NhpProducts = new List<NhpProduct>()
{
             new NhpProduct{nhpId=204, nhpName="Banh Bao", nhpImage="../Images/Anhbanhbao.png", nhpQuantity=24,nhpPrice=10000,nhpIsActive=true},
             new NhpProduct{nhpId=202, nhpName="Banh Ca", nhpImage="../Images/Anhbanhca.png", nhpQuantity=14,nhpPrice=12000,nhpIsActive=true}
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
        public ActionResult NhpCreate(NhpProduct nhpProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(nhpProduct);
            }

            NhpProducts.Add(nhpProduct);
            return RedirectToAction("Index");
        }
    }
}
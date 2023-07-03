using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restorent_MVC.Models;

namespace Restorent_MVC.Repositores
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDBEntites;
        public PaymentTypeRepository ()
            {
            objRestaurantDBEntites = new RestaurantDBEntities();
            }
        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDBEntites.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentType1,
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}
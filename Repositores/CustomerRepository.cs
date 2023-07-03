﻿using Restorent_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restorent_MVC.Repositores
{
    public class CustomerRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public CustomerRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();

        }
        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDBEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}
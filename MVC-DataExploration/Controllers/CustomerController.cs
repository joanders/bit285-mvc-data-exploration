﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext db = new MyDbContext();

        //POST: Customer
        [HttpPost]
        public ActionResult Create()
        {
           // Pass the Create() method a Customer object, called customer
            Customer customer = new Customer();
            //Use the db.Customers Add() method to add the passed Customer to the model
            db.Customers.Add(customer);
            //Use the db.SaveChanges() method to update the Database (the first time run, this will create the database too)
            db.SaveChanges();
            //Send the user back an updated Index page by returning an Index view with the db.Customers model, return View("Index",db.Customers)
            return View("Index", db.Customers);
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers);
        }
    }
}
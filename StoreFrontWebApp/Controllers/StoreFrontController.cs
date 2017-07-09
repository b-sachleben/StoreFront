using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreFrontShared.Models;
using StoreFrontShared.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using Dapper;
using StoreFrontShared.ViewModels;

namespace StoreFrontWebApp.Controllers
{
    public class StoreFrontController : Controller // controller is a coordinator - inherits from base class System.Web.Mvc.Controller - creates folder inside site root named "StoreFront"
    {
        private Context _context = null;

        protected Repository Repository { get; private set; }

        public StoreFrontController()
        {
            _context = new Context();
            Repository = new Repository(_context);
        }



        //static StoreFrontRepository _storeFrontRepository = new StoreFrontRepository();

        //public ActionResult Example() // <-- creates page inside "StoreFront" named "Example"
        //{
        //    // contents of "AddToCart" page (below)

        //    return View();  // <-- returns "AddToCart" view
        //}

        


        public ActionResult Shop(/*Item item, ItemDetails itemdetails*/)
        {
            ViewBag.Title = "Shop";

            //var itemList = _context.Items
            //    .Include(i => i.ItemDetails)
            //    .ToList(); // For one to many (item : itemDetails) relationship

            List<Item> itemList = Repository.GetItems();

            return View("Shop", itemList);
        }

        public ActionResult AddItem()
        {
            ViewBag.Title = "Add Item";

            List<Item> itemList = Repository.GetItems();

            return View("AddItem", itemList);
        }

        [HttpPost]
        public ActionResult AddItem(Item item/*string name, string price, string category, string image, string numberAvailable, string description*/) // mvc's model binding function searches for attributes of the same name as these parameters in form fields
        {
            ViewBag.Title = "Add Item";

            Repository.AddItem(item);

            //ViewBag.Name = name;
            //ViewBag.Price = price;
            //ViewBag.Category = category;
            //ViewBag.Image = image;
            //ViewBag.NumberAvailable = numberAvailable;
            //ViewBag.Description = description;

            List<Item> itemList = Repository.GetItems();

            return View("ViewDetails", itemList);
        }

        public ActionResult ViewDetails()
        {
            ViewBag.Title = "Item Details";

            return View();
        }

        public ActionResult EditItem(int? id)
        {
            ViewBag.Title = "Edit Item";

            return View();
        }

        public ActionResult Delete(int? id)
        {
            ViewBag.Title = "Delete Item";

            return null;
        }

        private bool _disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;
            
            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }
    }

    public class StoreFrontRepository
    {
        //private List<Item> _items = new List<Item>();

        public void AddItem(Item item, ItemDetails itemDetails)
        {
            using (var connection = CreateConnection())
            {
                connection.Execute("INSERT INTO Items (Name, Category, Image, Description) VALUES (@Name, @Category, @Image, @Description)", new { Name = item.Name, Category = item.Category, Image = item.Image, Description = item.Description });
                //Fix item below - "itemdetails" Id is passed a null value
                //connection.Execute("INSERT INTO ItemDetails (Price, Quantity, NumberAvailable) VALUES (@Price, @Quantity, @NumberAvailable)", new { Price = itemDetails.Price, Quantity = itemDetails.Quantity, NumberAvailable = itemDetails.NumberAvailable });
            }
        }

        //public List<StoreFrontBaseViewModel> StoreFrontBaseViewModel
        //{
        //    get
        //    {
        //        using (var connection = CreateConnection())
        //        {
        //            return connection.Query<Item>("SELECT * FROM Items").ToList();
        //        }
        //    }
        //}

        public List<Item> Items
        {
            get
            {
                using (var connection = CreateConnection())
                {
                    return connection.Query<Item>("SELECT * FROM Items").ToList();
                }
            }
        }

        //public List<ItemDetails> ItemDetails
        //{
        //    get
        //    {
        //        using (var connection = CreateConnection())
        //        {
        //            return connection.Query<ItemDetails>("SELECT * FROM ItemDetails").ToList();
        //        }
        //    }
        //}

        private IDbConnection CreateConnection()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=StoreFront;Trusted_Connection=true");
        }
    }
}
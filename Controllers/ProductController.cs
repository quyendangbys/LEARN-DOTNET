using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product> {
                new Product {
                    ProductId = 1,
                    ProductName = "1",
                    ProductDesc = ""
                },
                  new Product {
                    ProductId = 1,
                    ProductName = "1",
                    ProductDesc = "des1"
                }
            };
        }
    }
}
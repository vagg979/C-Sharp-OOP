﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //Code that retrieves the defined product

            return new Product();
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public Product Retrieve()
        {
            //Code that retrieves all products

            return new Product();
        }

        /// <summary>
        /// Save product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined product

            return true;
        }

        /// <summary>
        /// Validate values
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}

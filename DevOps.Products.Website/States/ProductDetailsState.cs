﻿using System.Collections.Generic;
using DevOps.Products.Website.Models.ViewModels;
using DevOps.Products.Website.Models.ViewModels.ProductDetails;

namespace DevOps.Products.Website.States
{
    public class ProductDetailsState
    {
        public ProductDetailsState(ProductViewModel product, IEnumerable<ReviewViewModel> reviews, CustomerViewModel customer)
        {
            Product = product;
            Reviews = reviews;
            Customer = customer;
        }

        public ProductViewModel Product { get; set; }
        public IEnumerable<ReviewViewModel> Reviews { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
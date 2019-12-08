﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DevOps.Products.Website.Models.DTOs;
using DevOps.Products.Website.Services.Interfaces;
using DevOps.Products.Website.Services.Interfaces.Facades;
using Flurl.Http;

namespace DevOps.Products.Website.Services.Implementations.Facades
{
    public class CategoryFacadeService : ICategoryFacadeService
    {
        private const string API_URL = "https://team-f.azurewebsites.net/api/product-management/categories";

        public async Task<IEnumerable<CategoryDTO>> GetCategoryCollection()
        {
            HttpResponseMessage response = await API_URL.GetAsync();

            IEnumerable<CategoryDTO> categories = await response.Content.ReadAsAsync<IEnumerable<CategoryDTO>>();

            return categories;
        }
    }
}

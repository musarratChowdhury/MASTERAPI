﻿using MASTERAPI.Model;

namespace MASTERAPI.Services
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(Product product);
    }
}
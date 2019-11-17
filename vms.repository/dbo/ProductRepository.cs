using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using vms.entity.models;
using System.Data.SqlClient;
using vms.entity.viewModels;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Linq;
using static Dapper.SqlMapper;
using URF.Core.EF.Trackable;
using System.Reflection.Metadata;

namespace vms.repository.dbo
{
    
    public interface IProductRepository : IRepositoryBase<Product>
    {
        vmProduct GetProductAutoComplete();
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly DbContext _context;

        public ProductRepository(DbContext context) : base(context)
        {
            this._context = context;
        }

        public vmProduct GetProductAutoComplete()
        {
            var objectType = new vmProduct
            {
                ProductId = 1,
                Name="Test",
                //Amount = 50,
                MeasurementUnitId = 1
                
            };
            new vmProduct
            {
                ProductId = 2,
                Name="av",
                //Amount = 500,
                MeasurementUnitId = 1
            };
            new vmProduct
            {

            };
            return null;
        }


    }
}

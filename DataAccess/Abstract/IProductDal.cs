using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
//DAL > Data Access Layer > 
//DAO > Data Access Object > 
namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
       
        
    }
}

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFCarDal : EFEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             join a in context.Colors
                             on p.ColorId equals a.Id
                             select new CarDetailDto { ColorName = a.ColorName, BrandName = c.BrandName };
                return result.ToList();
            }
          
        }
    }
}

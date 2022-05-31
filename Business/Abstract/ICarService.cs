﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);

        List<Car> GetAllByCategoryId(int id);

        List<Car> GetByUnitPrice(decimal min, decimal max);

        List<CarDetailDto> GetCarDetails();

    }
}

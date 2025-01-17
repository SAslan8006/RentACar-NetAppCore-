﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService : IService<Brand>
    {
        IDataResult<Brand> GetByBrandId(int brandId);
        IDataResult<Brand> GetById(int brandId);
    }
}

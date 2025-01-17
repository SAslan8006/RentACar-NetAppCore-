﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IService<Rental>
    {
        IDataResult<List<Rental>> GetByRentalId(int rentalId);
        IDataResult<List<RentalDetailDto>> GetRentalsDetails();
        IResult IsCarAvaible(int carId);
        List<int> CalculateTotalPrice(DateTime rentDate, DateTime returnDate, int carId);

    }
}

﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {

        IRentalService _rentalService;

            public RentalsController(IRentalService rentalService)
            {
                _rentalService = rentalService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _rentalService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
       

            [HttpGet("getbyrentalid")]
            public IActionResult GetByRentalId(int rentalId)
            {
                var result = _rentalService.GetByRentalId(rentalId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("add")]
            public IActionResult Add(Rental rental)
            {
                var result = _rentalService.Add(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("update")]
            public IActionResult Update(Rental rental)
            {
                var result = _rentalService.Update(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpDelete("delete")]
            public IActionResult Delete(Rental rental)
            {
                var result = _rentalService.Delete(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getrentalsdetails")]
            public IActionResult GetRentalsDetails()
            {
                var result = _rentalService.GetRentalsDetails();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

        [HttpGet("iscaravaible")]
            public IActionResult IsCarAvaible(int cardId)
            {
                var result = _rentalService.IsCarAvaible(cardId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


            [HttpGet("totalprice")]
            public IActionResult TotalPrice(object totalAmountInfo)
            {            
                return Ok();           
            }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
namespace _3_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string? number)
        {
            //1.�Y�S��number:
            if (number==null) return BadRequest("Lack of Parameter");

            //2.�Y�������O�Ʀr(�qstring�L�k�নint)�B�������O�����:
            //   TryParse() return bool�Aif true�Athe result will store in the second para.
            if (!int.TryParse(number, out var parsedNumber) || parsedNumber < 1) return BadRequest("Wrong Parameter");
            
            //3.�Y�����ѼƨS���A�p��:
            int result = CalculateSum(parsedNumber);

            return Ok(result);
        }

        private int CalculateSum(int number)
        {
            return number * (number + 1) / 2;
        }
    }
}
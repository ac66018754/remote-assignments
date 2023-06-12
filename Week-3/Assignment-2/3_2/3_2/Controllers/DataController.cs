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
            //1.若沒給number:
            if (number==null) return BadRequest("Lack of Parameter");

            //2.若給的不是數字(從string無法轉成int)、給的不是正整數:
            //   TryParse() return bool，if true，the result will store in the second para.
            if (!int.TryParse(number, out var parsedNumber) || parsedNumber < 1) return BadRequest("Wrong Parameter");
            
            //3.若給的參數沒錯，計算:
            int result = CalculateSum(parsedNumber);

            return Ok(result);
        }

        private int CalculateSum(int number)
        {
            return number * (number + 1) / 2;
        }
    }
}
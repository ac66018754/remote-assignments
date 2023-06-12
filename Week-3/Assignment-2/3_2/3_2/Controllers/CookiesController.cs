using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace _3_2.Controllers
{
    [ApiController]
    public class CookiesController : ControllerBase
    {
        [HttpGet("myName")]
        public IActionResult GetUserName()
        {
            //1.如果cookie內有username
            if (Request.Cookies.TryGetValue("username", out var username))
            {
                return Content($"Hello, {username}!");
            }
            //2.如果沒有，則return一個連結到/trackName 的表單，將name的值帶過去
            else
            {
                var content = new StringBuilder();
                content.AppendLine("<form method='get' action='trackName'>");
                content.AppendLine("<label for='name'>Enter your name:</label>");
                content.AppendLine("<input type='text' id='name' name='name'>");
                content.AppendLine("<input type='submit' value='Submit'>");
                content.AppendLine("</form>");

                return Content(content.ToString(), "text/html");
            }
        }

        [HttpGet("trackName")]
        public IActionResult TrackUserName(string name)
        {
            //3.設置cookie:  username : name
            Response.Cookies.Append("username", name, new CookieOptions { Expires = DateTimeOffset.Now.AddDays(1) });

            //4.回到/myName ，且cookie內已有username
            return RedirectToAction("GetUserName");
        }
    }
}

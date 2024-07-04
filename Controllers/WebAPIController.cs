using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/WebAPI")]
    [ApiController]
    public class WebAPIController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            
            return new List<Villa>
            {
                new Villa{Id=1,Name="Pool View"},
                new Villa{Id=2,Name="Beach View"}
            };
        }
    }
}

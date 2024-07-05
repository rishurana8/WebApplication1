using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Dto;

namespace WebApplication1.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController: ControllerBase
    {
        [HttpGet]
        // http end point to get all the villas 
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {

            return Ok(VillaStore.villaList);
        }
        
        [HttpGet("{id:int}")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            // addding authentication
            if (id == 0)
            {
                return BadRequest();
            }
            var  villa = (VillaStore.villaList.FirstOrDefault(u =>u.Id == id));

            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa); 
        }
    }
}

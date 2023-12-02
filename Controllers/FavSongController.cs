using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FavSongController : ControllerBase
    {


        private readonly ILogger<FavSongController> _logger;
        private readonly IFavSongsContextDOA _context;

        public FavSongController(ILogger<FavSongController> logger, IFavSongsContextDOA context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllInfo());
        }

        [HttpGet("id")]
        public IActionResult GetbyId(int? id)
        {
            if (id == 0 || id == null)
            {
                return Ok(_context.GetAllInfo().GetRange(0, 5));
            }

            var info = _context.GetInfo((int)id);
            if (info == null) { return NotFound(id); }
            return Ok(info);

        }


        [HttpDelete("id")]
        public IActionResult DeleteById(int id)
        {


            var info = _context.RemoveInfoById(id);
            if (info == null) { return NotFound(id); }

            return Ok();
        }

        [HttpPut]
        public IActionResult PutById(FavSong info)
        {
            var result = _context.UpdateInfo(info);

            if (result == null) { return NotFound(info.iD); }
            if (result == 0) { return StatusCode(500, "An Error occured while processing your request"); }
            return Ok();

        }


        [HttpPost]
        public IActionResult Post(FavSong info)
        {

            var result = _context.Add(info);

            if (result == null) { return StatusCode(500, "Entry already exists"); }

            if (result == 0) { return StatusCode(500, "An error occured while processing your request"); }
            return Ok();
        }


    }



}


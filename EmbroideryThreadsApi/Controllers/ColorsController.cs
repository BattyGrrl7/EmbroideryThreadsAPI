using EmbroideryThreadsApi.Data;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace EmbroideryThreadsApi.Controllers
{
    //api/colors

    [ApiController]
    [Route("api/[controller]")]
    public class ColorsController : ControllerBase
    {
        private readonly IColorsRepo _repository;

        public ColorsController(IColorsRepo colorsRepo)
        {
            _repository = colorsRepo;
        }

        //GET api/colors/5
        [HttpGet("{id}")]
        public ActionResult <Color> GetById(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }

            var result = _repository.GetColorById(id);

            return Ok(result);
        }

        //GET api/colors
        [HttpGet]
        public ActionResult <IEnumerable<Color>> GetAllColors()
        {
            var colors = _repository.GetAllColors();

            return Ok(colors);
        }
    }
}


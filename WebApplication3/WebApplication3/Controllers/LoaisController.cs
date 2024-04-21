using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication3.data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoaisController(MyDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsloai = _context.Loais.ToList();
            return Ok(dsloai);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id )
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.Maloai == id );
            if (loai != null)
            {
                return Ok(loai);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult CreateNew(LoaiModel model)
        {
            try {
                var loai = new Loai
                {
                    Name = model.Name
                };
                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }catch
            {
                return BadRequest(0);

            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateLoaibyID(int id, LoaiModel model)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.Maloai == id);
            if (loai != null)
            {
                loai.Name = model.Name;
                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

    }
}

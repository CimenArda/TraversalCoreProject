using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalApi.DAL.Context;
using TraversalApi.DAL.Entities;

namespace TraversalApi.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {

        [HttpGet]
        public IActionResult VisitorList()
        {
            using (var c =new VisitorContext())
            {
                var values = c.Visitors.ToList();
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult VisitorAdd(Visitor visitor)
        {
            using (var c =new VisitorContext())
            {
                c.Visitors.Add(visitor);
                c.SaveChanges();
                return Ok();
            }
        }


        [HttpGet("{id}")]
        public IActionResult VisitorGetById(int id)
        {
            using (var c =new VisitorContext())
            {
                var values = c.Visitors.Find(id);
                if (values==null)
                {
                    return NotFound();

                }
                else
                {
                    return Ok(values);
                }
            }

        }

        [HttpDelete("{id}")]
        public IActionResult VisitorRemove(int id)
        {
            using (var c = new VisitorContext())
            {
                var values = c.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();

                }
                else
                {
                    c.Visitors.Remove(values);
                    c.SaveChanges();
                    return Ok();    
                }
            }
        }

        [HttpPut]
        public IActionResult VisitorUpdate (Visitor visitor)
        {
            using (var c =new VisitorContext())
            {
                var values = c.Visitors.Find(visitor.VisitorID);
                values.Name = visitor.Name;
                values.Surname = visitor.Surname;
                values.Mail = visitor.Mail;
                values.City = visitor.City;
                values.Country = visitor.Country;

                c.Update(values);
                c.SaveChanges();
                return Ok();
            }
        }






        }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using webApiMediaMarkt.Data;
using webApiMediaMarkt.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApiMediaMarkt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly MediamarktContext context;
        public ProductoController(MediamarktContext context)
        {
            this.context = context;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                //return Ok("hola");
                return Ok(context.Producto.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProductoController>
        [HttpGet("{nombreODescripcion}", Name = "GetProducto")] // El nombre es porque la petición se va a reutilizar.
        public ActionResult Get(string nombreODescripcion)
        {
            try
            {
                var gestor = from g in context.Producto
                             where g.Nombre == nombreODescripcion || g.Descripcion.Contains(nombreODescripcion)
                             select g;
                                        
                return Ok(gestor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ProductoController>
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            try
            {
                
                context.Producto.Add(producto);
                
                context.SaveChanges();
                return CreatedAtRoute("GetProducto", new { nombreODescripcion = producto.Nombre}, producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Producto producto) //Similar al POST con la difrencia que se busca por id el registro que se quiere modificar
        {
            try
            {
                if (producto.ID == id)
                {
                    context.Entry(producto).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetProducto", new { id = producto.ID }, producto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var producto = context.Producto.FirstOrDefault(g => g.ID == id);
                if (producto != null)
                {
                    context.Producto.Remove(producto);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

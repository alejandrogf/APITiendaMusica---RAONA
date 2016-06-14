using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioAPI.Model;
using RepositorioAPI.ViewModel;

namespace APITiendaMusica.Controllers
{
    public class CategoriasController : ApiController
    {
        [Dependency]
        public IRepositorio<Categorias, CategoriaViewModel> Repositorio { get; set; }

        public ICollection<CategoriaViewModel> GetCategorias()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof(CategoriaViewModel))]
        public IHttpActionResult GetCategorias(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        [ResponseType(typeof(CategoriaViewModel))]
        public IHttpActionResult AddCategoria(CategoriaViewModel modelo)
        {
            var data = Repositorio.Add(modelo);
            if (data == null)
            {
                return BadRequest("Error en la creación de una nueva categoria");
            }
            modelo.ID = data.ID;
            return Created("Categoría Creada", data);

        }

        [HttpDelete]
        [ResponseType(typeof(CategoriaViewModel))]
        public IHttpActionResult DeleteCategoria(CategoriaViewModel modelo)
        {
            var data = Repositorio.Borrar(modelo);
            if (data == 0)
            {
                return BadRequest("No se ha eliminado el registro.");
            }
            return Ok(data);

        }

        [HttpPut]
        [ResponseType(typeof(CategoriaViewModel))]
        public IHttpActionResult ModificarCategoria(CategoriaViewModel modelo)
        {
            var data = Repositorio.Actualizar(modelo);
            if (data == 0)
            {
                return BadRequest("Error en la actualización.");
            }
            return Ok(data);

        }


    }

}
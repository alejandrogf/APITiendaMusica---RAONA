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
    public class ComponentesController : ApiController
    {
        [Dependency]
        public IRepositorio<Componentes, ComponenteViewModel> Repositorio { get; set; }

        public ICollection<ComponenteViewModel> GetComponentes()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof(ComponenteViewModel))]
        public IHttpActionResult GetComponentes(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]
        [ResponseType(typeof(ComponenteViewModel))]
        public IHttpActionResult AddComponente(ComponenteViewModel modelo)
        {
            var data = Repositorio.Add(modelo);
            if (data == null)
            {
                return BadRequest("Error en la creación de un nuevo componente");
            }
            modelo.ID = data.ID;
            return Created("Componente Creado", data);

        }

        [HttpDelete]
        [ResponseType(typeof(ComponenteViewModel))]
        public IHttpActionResult DeleteComponente(ComponenteViewModel modelo)
        {
            var data = Repositorio.Borrar(modelo);
            if (data == 0)
            {
                return BadRequest("No se ha eliminado el registro.");
            }
            return Ok(data);

        }

        [HttpPut]
        [ResponseType(typeof(ComponenteViewModel))]
        public IHttpActionResult ModificarComponente(ComponenteViewModel modelo)
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
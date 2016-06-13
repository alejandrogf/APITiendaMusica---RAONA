using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositorioAPI.Model;
using BaseRepositorio.ViewModel;

namespace RepositorioAPI.ViewModel
{
    public class CategoriaViewModel:IViewModel<Categorias>
    {

        public int ID { get; set; }
        public string Nombre { get; set; }

        public Categorias ToBaseDatos()
        {
            var categoria = new Categorias()
            {
                ID=ID,
                Nombre = Nombre
            };
            return categoria;
        }

        public void FromBaseDatos(Categorias modelo)
        {
            ID = modelo.ID;
            Nombre = modelo.Nombre;
        }

        public void UpdateBaseDatos(Categorias modelo)
        {
            modelo.ID = ID;
            modelo.Nombre = Nombre;
        }

        public object[] GetKeys()
        {
            return new object[] {ID};
        }
    }
}
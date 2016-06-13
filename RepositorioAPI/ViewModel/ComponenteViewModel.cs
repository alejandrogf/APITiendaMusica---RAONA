using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseRepositorio.ViewModel;
using RepositorioAPI.Model;

namespace RepositorioAPI.ViewModel
{
    public class ComponenteViewModel:IViewModel<Componentes>
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBruto { get; set; }
        public int IVA { get; set; }
        public decimal PrecioNeto { get; set; }
        public int Categoria { get; set; }
        public Componentes ToBaseDatos()
        {
            var componente = new Componentes()
            {
                ID = ID,
                Nombre = Nombre,
                Descripcion = Descripcion,
                PrecioBruto = PrecioBruto,
                IVA = IVA,
                PrecioNeto = PrecioNeto,
                Categoria = Categoria
            };
            return componente;
        }

        public void FromBaseDatos(Componentes modelo)
        {
            ID = modelo.ID;
            Nombre = modelo.Nombre;
            Descripcion = modelo.Descripcion;
            PrecioBruto = modelo.PrecioBruto;
            IVA = modelo.IVA;
            PrecioNeto = modelo.PrecioNeto;
            Categoria = modelo.Categoria;
        }

        public void UpdateBaseDatos(Componentes modelo)
        {
            modelo.ID = ID;
            modelo.Nombre = Nombre;
            modelo.Descripcion = Descripcion;
            modelo.PrecioBruto = PrecioBruto;
            modelo.IVA = IVA;
            modelo.PrecioNeto = PrecioNeto;
            modelo.Categoria = Categoria;
        }

        public object[] GetKeys()
        {
            return new object[] {ID};
        }
    }
}
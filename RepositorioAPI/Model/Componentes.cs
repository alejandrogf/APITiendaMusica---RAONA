//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositorioAPI.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Componentes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBruto { get; set; }
        public int IVA { get; set; }
        public decimal PrecioNeto { get; set; }
        public int Categoria { get; set; }
    
        public virtual Categorias Categorias { get; set; }
    }
}
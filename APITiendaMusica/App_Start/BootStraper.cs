using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioAPI.Model;
using RepositorioAPI.ViewModel;

namespace APITiendaMusica.App_Start
{
    public class BootStraper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext, TiendaMusicaEntities>();

            container.RegisterType<IRepositorio<Componentes, ComponenteViewModel>,
                                   RepositorioEntity<Componentes, ComponenteViewModel>>();
            container.RegisterType<IRepositorio<Categorias, CategoriaViewModel>,
                       RepositorioEntity<Categorias, CategoriaViewModel>>();


        }
    }
}

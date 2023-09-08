using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Maer.Common.IoC;
using Maer.Domain;
using Maer.Domain.Browser;
using Maer.Domain.General;
using Web.Support;
using Maer.Services;
using Maer.DataTransferObjects.General.Reportes;
using System.Linq;
using Maer.Domain.MaestrosEmpresas;
using System;

namespace Web.Controllers
{
    [EntityName("Empleado", "la")]
    public class EmpleadoController : EntityServiceController<IEmpleadoServices, Empleado, EmpleadoDTO>
    {


        public EmpleadoController(IEmpleadoServices empleadoServices)
        {
        }



        public virtual ActionResult GetAllDTOByEmpresaLogueada()
        {
            var empresas = new List<Empresa> { this.EmpresaLogueada };
            var objetos = Services.GetAllByEmpresas(empresas).ToList();

            var viewModel = Mapper.Map<IEnumerable<Empleado>, IEnumerable<EmpleadoDTO>>(objetos);



            return Data(viewModel);
        }

        //public ActionResult GetByDescripcion(string descripcion)
        //{
        //    var objeto = Services.GetByDescripcion(descripcion);
        //    var viewModel = Mapper.Map<Oficina, OficinaDTO>(objeto);
        //    return Data(viewModel);
        //}





        public ActionResult GetCotizacionByMonedaId(int empleadoId)
        {
            var objeto = Services.Get(empleadoId);
            var viewModel = Mapper.Map<Empleado, EmpleadoDTO>(objeto);
            return Data(viewModel);

        }

    }
}

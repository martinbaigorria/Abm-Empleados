
using System.Collections.Generic;
using Maer.DataTransferObjects.General.Reportes;
using Maer.Domain;
using Maer.Domain.General;
using System;
using System.Collections;
using System.Collections.Generic;
using Maer.DataTransferObjects.Articulos.Reportes.Parametros;
using Maer.DataTransferObjects.Compras;
using Maer.DataTransferObjects.Compras.Reportes;
using Maer.Domain.Articulos;
using Maer.Domain.Compras;
using Maer.Domain;
using System.IO;
using DevExpress.XtraReports.UI;

namespace Maer.Services
{
    public interface IEmpleadoServices: ISigaServices<Empleado>
    {

        IEnumerable<Empleado> GetEmpleados();


    }

}
//string Nombre, string Apellido, string Genero, DateTime FechaNacimiento, string NumeroInterno,
//            string Observacion, int EmpresaId, int OficinaId  
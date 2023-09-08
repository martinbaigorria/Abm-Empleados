using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maer.Common.IoC;
using Maer.Data.Queries;
using Maer.DataTransferObjects.General;
using Maer.Domain;
using Maer.Domain.Exceptions;
using Maer.Domain.General;
using Maer.Services.Support;
using Maer.Services.Interfaces;

using Maer.Data.Queries.General;


namespace Maer.Services
{
    public class EmpleadoServices : SigaServices<Empleado>, IEmpleadoServices
    {


        public IEnumerable<Empleado> GetEmpleados()
        {
            var list = Repository.Query(new GetEmpleados()).List().ToList();
            var listResult = new List<Empleado>();

            foreach (var objectse in list)
            {
                var empleado = new Empleado()
                {
                    Id = objectse[0] == null ? 0 : (int)objectse[0],
                    Nombre = objectse[1] == null ? "" : (string)objectse[1],
                    Apellido = objectse[2] == null ? "" : (string)objectse[2],
                    Genero = objectse[3] == null ? "" : (string)objectse[3],
                    FechaNacimiento = objectse[4] == null ? (DateTime?)null : (DateTime)objectse[4],
                    NumeroInterno = objectse[5] == null ? "" : (string)objectse[5],
                    Observacion = objectse[6] == null ? "" : (string)objectse[6],
                    EmpresaId = objectse[7] == null ? 0 : (int)objectse[7],
                    OficinaId = objectse[8] == null ? 0 : (int)objectse[8],
                };

                listResult.Add(empleado);
            }

            return listResult;
        }


    }


   
}

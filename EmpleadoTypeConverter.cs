using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Maer.Common.Extensions;
using Maer.Common.IoC;
using Maer.DataTransferObjects.Articulos;
using Maer.DataTransferObjects.General;
using Maer.DataTransferObjects.Seguridad;
using Maer.DataTransferObjects.Tarjetas;
using Maer.DataTransferObjects.Ventas;
using Maer.Domain;
using Maer.Domain.Contabilidad;
using Maer.Domain.Tarjetas;
using Maer.Services;
using Maer.Services.Support.TypeConverters;
using Maer.DataTransferObjects.General.Reportes;


namespace Web.Support.TypeConverters
{
    public class EmpleadoTypeConverter : TypeConverter<Empleado, EmpleadoDTO>
    {
        protected override EmpleadoDTO ConvertCore(Empleado source)
        {
            var empleado = new EmpleadoDTO
            {
                Id = source.Id,
                Nombre = source.Nombre,
                Apellido = source.Apellido,
                Genero = source.Genero,
                FechaNacimiento = source.FechaNacimiento,
                NumeroInterno = source.NumeroInterno,
                Observacion = source.Observacion,
                OficinaId = source.OficinaId,
                EmpresaId = source.EmpresaId,
        
            };

            foreach (var emp in source.DatosxEmpresa)
            {
                var e = new EmpleadoEmpresaDTO
                {
                    Id = emp.Id,
                    EmpresaId = emp.Empresa.Id
                };
            
            }

            return empleado;
        }
    }
}





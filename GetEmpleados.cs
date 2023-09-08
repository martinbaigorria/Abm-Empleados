using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maer.Common.DataAccess;
using Maer.Domain;
using Maer.Domain.Articulos;
using NHibernate;
using NHibernate.Linq;
using System;

namespace Maer.Data.Queries.General
{
    public class GetEmpleados : IQuery<object[]>
    {
        //private readonly bool IgnorarFechas;
        //private readonly int EmpresaId;

        public GetEmpleados()
        {
            //this.IgnorarFechas = ignorarFechas;
            //this.EmpresaId = empresaId;
        }

        public IQueryResult<object[]> Execute(ISession session)
        {
            var sb = new StringBuilder();

            sb.AppendLine("SELECT");
            sb.AppendLine("E.Id AS EmpleadoId, ");
            sb.AppendLine("E.Nombre, ");
            sb.AppendLine("E.Apellido, ");
            sb.AppendLine("E.Genero, ");
            sb.AppendLine("E.FechaNacimiento, ");
            sb.AppendLine("O.Observacion AS NombreOficina, ");
            sb.AppendLine("E.EmpresaId, ");
            sb.AppendLine("E.OficinaID");
            
            sb.AppendLine("FROM");
            
            sb.AppendLine("Empleados AS E");
            
            sb.AppendLine("JOIN");
            
            sb.AppendLine("Oficinas AS O ON E.OficinaId = O.Id");
            
            sb.AppendLine("WHERE");
            
            sb.AppendLine("(@Oficinas IS NULL OR E.OficinaId IN(SELECT O.Id FROM Oficinas))");
            sb.AppendLine("AND(@Genero IS NULL OR E.Genero = @Genero)");
            sb.AppendLine("AND(@FechaNacimientoDesde IS NULL OR E.FechaNacimiento >= @FechaNacimientoDesde)");
            sb.AppendLine("AND(@FechaNacimientoHasta IS NULL OR E.FechaNacimiento <= @FechaNacimientoHasta)");




            var query = session.CreateSQLQuery(sb.ToString());


            return new LinqResultFromQuery<object[]>(query);

        }
    }
}


//string Nombre, string Apellido, string Genero, DateTime FechaNacimiento, string NumeroInterno,
//            string Observacion, int EmpresaId, int OficinaId
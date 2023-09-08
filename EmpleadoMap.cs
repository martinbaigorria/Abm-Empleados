using FluentNHibernate.Mapping;
using Maer.Domain;

namespace Maer.Data.Mappings
{
    public sealed class EmpleadoMap : ClassMap<Empleado>
    {
        public EmpleadoMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nombre);
            Map(x => x.Apellido);
            HasMany(x => x.DatosxEmpresa).AsBag().Cascade.AllDeleteOrphan();
            Map(x => x.Genero);
            Map(x => x.FechaNacimiento);
            Map(x => x.NumeroInterno);
            Map(x => x.Observacion);
            Map(x => x.EmpresaId);
            Map(x => x.OficinaId);



        }
    }
}






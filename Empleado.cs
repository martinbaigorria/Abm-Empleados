using System;
using System.Collections.Generic;
using Maer.Domain.Attributes;
using Maer.Domain.Browser;
using Maer.Domain.MaestrosEmpresas;

namespace  Maer.Domain
{
    [Numerador(TipoNumerador.Secuencial, Descripcion ="Empleado")]
    public class Empleado : IIdentifiable, IMaestro<EmpleadoEmpresa>,  IInterfazSiga
    {
        public virtual int Id { get; set; }
        [Ignorar]

        public virtual int EmpresaId { get; set; }
        [Ignorar]


        public virtual int OficinaId { get; set; }

        [Ignorar]
        public virtual int IdSiga { get; set; }
        [Ignorar]
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public virtual string NumeroInterno { get; set; }


        public virtual string Observacion { get; set; }
        [Label("Observacion"), NotAllowBlank]


        [Ignorar]
        public virtual IList<EmpleadoEmpresa> DatosxEmpresa { get; set; }


        public Empleado()
        {
            DatosxEmpresa = new List<EmpleadoEmpresa>();
        }

       

      

        #region Equals y HashCode
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var empleado = obj as Empleado;
            if (empleado == null) return false;

            if (!this.Observacion.ToLower().Equals(empleado.Observacion.ToLower())) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return this.Observacion.ToLower().GetHashCode();
        }
        #endregion
    }
}
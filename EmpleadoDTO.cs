using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maer.DataTransferObjects.General.Reportes
{
    public class EmpleadoDTO : EntityDTO
    {
        public List<int> EmpresasSeleccionadas { get; set; }
        public List<int> Empresas { get; set; }


        public virtual int Id { get; set; }

        public virtual int EmpresaId { get; set; }


        public virtual int OficinaId { get; set; }

        public virtual int IdSiga { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public virtual int NumeroInterno { get; set; }


        public virtual string Observacion { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminEmpleadosEntidades
{
    public class Empleado
    {
        [Key]
        public int? EmpleadoId { get; set; }
     
        public string? Dni { get; set; }

        [MaxLength(100)]
        public string? Nombre { get; set; }

        [MaxLength(500)]
        public string? Direccion { get; set; }
        
        public DateTime? FechaIngreso { get; set; }        

        [Column(TypeName="decimal(8,2)")]
        public decimal? Salario { get; set; }

        [ForeignKey("Departamento")] //EF
        public int? dpto_id { get; set; }

        public Departamento? Departamento { get; set; }

        [NotMapped] //EF

        public string? NombreDepartamento
        {
            get
            {
                if (Departamento != null)
                    return Departamento.Nombre;
                else
                    return null;
            }
        }

        public bool anulado { get; set; } = false; //Agregamos el campo anulado en C# es Bool y en SQL Bit
    }
}

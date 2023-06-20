using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Models
{
    public class Consulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Motivo { get; set; }
        public string Fecha { get; set; }
        public Veterinario VetAsignado { get; set; }
        public Usuario UsuarioEnTurno { get; set; }
    }
}

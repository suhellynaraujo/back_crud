using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_crud.Models
{
    public class Entrar 
    {
        [Key]
        public int Id_Entrar { get; set; }
        
        public string Email { get; set; }
        [ForeignKey("Cadastro")]
        [Required]
        public int Senha { get; set; }
        [Required]
        public int Id_Cadastro{ get; set; }

    }
}

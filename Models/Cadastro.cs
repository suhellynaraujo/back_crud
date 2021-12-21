using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_crud.Models
{
    public class Cadastro
    {
        [Key]
        public int Id_Cadastro { get; set; }
        public string Nome { get; set; }
        [Required]
        [ForeignKey("Entrar")]
        public string Email { get; set; }
        [Required]

        public int Senha { get; set; }
       
     
        



        
    }
}

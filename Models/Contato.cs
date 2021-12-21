using System.ComponentModel.DataAnnotations;

namespace back_crud.Models
{
    public class Contato
    {
        [Key]
        public int Id_Contato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }   
        public string Mensagem { get; set; }
    }
}

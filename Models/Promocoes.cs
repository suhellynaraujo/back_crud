using System.ComponentModel.DataAnnotations;

namespace back_crud.Models
{
    public class Promocoes
    {
        [Key]
        public int Id { get; set; }
        public int Id_Destino { get; set; }
        public string Nome { get; set; }
        public string Ida { get; set; }
        public string Volta { get; set; }
        public float Valor { get; set; }

    }
}

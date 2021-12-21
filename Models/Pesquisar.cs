using back_crud.Models;
using System.ComponentModel.DataAnnotations;

namespace back_crud.Models
{
    public class Pesquisar
    {
        [Key]
        public int Id_Pesquisar { get; set; }
        public string Nome_Destino { get; set; }

        public DateTime Ida { get; set; }

        public DateTime Volta { get; set; }
        public int Id_Destino { get; set; }
        public virtual List<Destino> Destino { get; set; }

    }
}

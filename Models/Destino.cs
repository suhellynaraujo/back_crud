using back_crud.Models;
using System.ComponentModel.DataAnnotations;

namespace back_crud.Models
{
    public class Destino
    {
        [Key]
        public int Id_Destino { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Descricao { get; set; }
        public virtual Pesquisar Pesquisar { get; set; }

    }
}

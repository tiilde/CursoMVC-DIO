using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_DIO.Models {
    public class Categoria {

        // id será a chave primária no banco de dados
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo descrição é obrigatório")]
        public string Descricao { get; set; }
        
    }
}

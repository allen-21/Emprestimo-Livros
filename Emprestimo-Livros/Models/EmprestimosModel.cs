using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Emprestimo_Livros.Models
{
    public class EmprestimosModel
    {
        //A tabela

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// defini a chave primaria
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do recebedor!")]
        [StringLength(50)]
        public string Recebedor { get; set;}

        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        [StringLength(50)]
        public string Fornecedor { get; set;}
        [Required(ErrorMessage = "Digite o nome do livro!")]
        [StringLength(50)]
        public string LivroEmprestado { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}

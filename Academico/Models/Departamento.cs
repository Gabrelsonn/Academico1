using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }
        [Display(Name = ("Dados cadastrais que usam seu e-mail"))]
        public string Email { get; set;}
        [Display(Name =("Instituicao"))]

        public int InstituicaoId { get; set; }

        public Instituicao? InstituicaoOrigem { get; set; }

        public string NomeCoordenador { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ProjV2.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        [Display(Name="Tempo estimadoclar em horas")]
        public int TempoEstimado { get; set; }
        public int Valor{ get; set; }
        public string Descricao { get; set; }
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionarios { get; set; }
    }
}
using System.Collections.Generic;

 namespace ProjV2.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Funcao { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
    }
}
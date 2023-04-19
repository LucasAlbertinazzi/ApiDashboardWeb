namespace ApiServicesWebChamados.Classes
{
    public class Chamado
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public int TempoDesenvolvimento { get; set; }
        public string Setor { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public string Prioridade { get; set; }
        public string UsuarioAbertura { get; set; }
        public string UsuarioAtual { get; set; }
    }
}

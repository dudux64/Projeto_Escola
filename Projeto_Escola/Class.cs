namespace Projeto_Escola
{
    public class Professor
    {
        public string Nome { get; set; } = string.Empty;
        public string Disciplina { get; set; } = string.Empty;
        public int ExperienciaAnos { get; set; } // Anos de experiência
        public string Email { get; set; } = string.Empty;
        public string FotoUrl { get; set; } = string.Empty; // URL da foto do professor
        public string Biografia { get; set; } = string.Empty; // Biografia do professor
    }
}

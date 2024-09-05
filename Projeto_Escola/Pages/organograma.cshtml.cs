using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto_Escola.Pages
{
	public class ProfessoresModel : PageModel
	{
		public List<Professor> Professores { get; set; } = new List<Professor>();

		public void OnGet()
		{
			Professores = new List<Professor>
			{
				new Professor
				{
					Nome = "Dr. Ana Silva",
					Disciplina = "Matemática",
					ExperienciaAnos = 10,
					Email = "ana.silva@exemplo.com",
					FotoUrl = "/images/professor1.jpg",
					Biografia = "Dr. Ana Silva é uma professora de Matemática com 10 anos de experiência no ensino de cálculos avançados e teoria dos números. Ela possui uma paixão por ajudar os alunos a desenvolverem suas habilidades analíticas."
				},
				new Professor
				{
					Nome = "Prof. Carlos Souza",
					Disciplina = "História",
					ExperienciaAnos = 15,
					Email = "carlos.souza@exemplo.com",
					FotoUrl = "/images/professor2.jpg",
					Biografia = "Prof. Carlos Souza é especialista em História Antiga e Medieval. Com 15 anos de experiência, ele se dedica a ensinar e compartilhar o conhecimento sobre as civilizações que moldaram o mundo moderno."
				},
				new Professor
				{
					Nome = "Dr. Mariana Costa",
					Disciplina = "Química",
					ExperienciaAnos = 8,
					Email = "mariana.costa@exemplo.com",
					FotoUrl = "/images/professor3.jpg",
					Biografia = "Dr. Mariana Costa tem 8 anos de experiência no campo da Química Orgânica e Inorgânica. Ela é conhecida por suas aulas práticas envolventes e por sua habilidade em tornar conceitos complexos acessíveis."
				}
			};
		}
	}
}

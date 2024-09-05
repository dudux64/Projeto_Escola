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
					Disciplina = "Matem�tica",
					ExperienciaAnos = 10,
					Email = "ana.silva@exemplo.com",
					FotoUrl = "/images/professor1.jpg",
					Biografia = "Dr. Ana Silva � uma professora de Matem�tica com 10 anos de experi�ncia no ensino de c�lculos avan�ados e teoria dos n�meros. Ela possui uma paix�o por ajudar os alunos a desenvolverem suas habilidades anal�ticas."
				},
				new Professor
				{
					Nome = "Prof. Carlos Souza",
					Disciplina = "Hist�ria",
					ExperienciaAnos = 15,
					Email = "carlos.souza@exemplo.com",
					FotoUrl = "/images/professor2.jpg",
					Biografia = "Prof. Carlos Souza � especialista em Hist�ria Antiga e Medieval. Com 15 anos de experi�ncia, ele se dedica a ensinar e compartilhar o conhecimento sobre as civiliza��es que moldaram o mundo moderno."
				},
				new Professor
				{
					Nome = "Dr. Mariana Costa",
					Disciplina = "Qu�mica",
					ExperienciaAnos = 8,
					Email = "mariana.costa@exemplo.com",
					FotoUrl = "/images/professor3.jpg",
					Biografia = "Dr. Mariana Costa tem 8 anos de experi�ncia no campo da Qu�mica Org�nica e Inorg�nica. Ela � conhecida por suas aulas pr�ticas envolventes e por sua habilidade em tornar conceitos complexos acess�veis."
				}
			};
		}
	}
}

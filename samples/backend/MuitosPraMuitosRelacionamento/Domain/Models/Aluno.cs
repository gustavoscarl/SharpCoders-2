namespace MuitosPraMuitosRelacionamento.Domain.Models;

public class Aluno : Entity
{
   public string Nome { get; set; }
   public string Email { get; set; }

   public List<Matricula> Matriculas { get; set; } = new();

}

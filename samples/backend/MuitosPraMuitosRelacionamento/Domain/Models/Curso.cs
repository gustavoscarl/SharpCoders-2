namespace MuitosPraMuitosRelacionamento.Domain.Models;

public class Curso : Entity
{
  public string Nome { get; set; }   
  public string Descricao { get; set; }   

  public List<Matricula> Matriculas { get; set; } = new();
}
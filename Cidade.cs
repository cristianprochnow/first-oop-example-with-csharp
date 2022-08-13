class Cidade
{
  private string nome;
  private int populacao;
  private double area;
  private string estado;

  public Cidade(
    string nome,
    int populacao,
    double area,
    string estado
  ) {
    this.nome = nome;
    this.populacao = populacao;
    this.area = area;
    this.estado = estado;
  }

  private string buscarDados()
  {
    string mensagem;

    mensagem = "A cidade de "+this.nome
               +" fica no estado de "+this.estado
               +". Possui uma população de "+this.populacao
               +" habitantes, espalhados por uma área de "+this.area+" km².";

    return mensagem;
  }

  public void mostrarDados()
  {
    string mensagem = this.buscarDados();

    Console.WriteLine(mensagem);
  }
}
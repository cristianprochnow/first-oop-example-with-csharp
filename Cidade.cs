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

  public Cidade() {
    this.nome = "";
    this.populacao = 0;
    this.area = 0;
    this.estado = "";
  }

  private string getCidadeText()
  {
    return "A cidade de "+this.nome+" fica no estado de "+this.estado;
  }

  private string getHabitantesText()
  {
    return "Possui população de "+this.populacao+" habitantes.";
  }

  private string getAreaText()
  {
    return "Espalhados por uma área de "+this.area+" km².";
  }

  private string getDensidadeText()
  {
    
    double densidade = this.area / this.populacao;
    return "A densidade demográfica é de "+Convert.ToString(densidade)+" habitantes/km².";
  }

  public string buscarDados()
  {
    string mensagem;

    mensagem = "A cidade de "+this.nome
               +" fica no estado de "+this.estado
               +". Possui uma população de "+this.populacao
               +" habitantes, espalhados por uma área de "+this.area+" km².";

    return mensagem;
  }

  /*
    T - tudo
    H - adiciona habitantes
    A - adiciona área
    D - adiciona densidade
  */
  public string buscarDados(string flgQualConteudo)
  {
    string mensagem;
    string cidade = this.getCidadeText();
    string habitantes = this.getHabitantesText();
    string area = this.getAreaText();
    string densidade = this.getDensidadeText();
    string[] content = {};

    switch (flgQualConteudo) {
      case "H":
        content.Append(habitantes);
        content.Append(area);
        break;

      case "A":
        content.Append(area);
        break;

      case "D":
        content.Append(densidade);
        break;

      case "T": default:
        content.Append(cidade);
        content.Append(habitantes);
        content.Append(area);
        break;
    }

    mensagem = this.construirMensagem(content);

    return mensagem;
  }

  private string construirMensagem(string[] content)
  {
    string message = "";

    foreach (string text in content)
    {
      if (message != "") {
        message += " ";
      }

      message += text;
    }

    return message;
  }

  public void mostrarDados()
  {
    string mensagem = this.buscarDados();

    Console.WriteLine(mensagem);
  }
}
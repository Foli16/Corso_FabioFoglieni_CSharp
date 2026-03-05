public class Docente
{
    private string? nome, materia;

    public Docente(string nome, string materia)
    {
        this.nome = nome;
        this.materia = materia;
    }

    public string? Nome
    {
        get
        {
            return nome;
        }
        set => nome = value;
    }
    public string? Materia
    {
        get
        {
            return materia;
        }
        set => materia = value;
    }
}
namespace Elenco.Models;

public class AtoresPost
{
    public string Nome { get; set; }
    public DateOnly Nascimento { get; set; }
    public DateOnly Morte { get; set; }
    public string Genero { get; set; }
    public string Nacionalidade { get; set; }
}

public class Atores
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly Nascimento { get; set; }
    public DateOnly Morte { get; set; }
    public string Genero { get; set; }
    public string Nacionalidade { get; set; }

    public static Atores DtoToCusto(AtoresPost dto) 
    {
        return new Atores()
        {
            Nome = dto.Nome,
            Nascimento = dto.Nascimento,
            Morte = dto.Morte,
            Genero = dto.Genero,
            Nacionalidade = dto.Nacionalidade
        };
    }

    public static void Update(Atores ator, AtoresPost dto)
    {
        ator.Nome = dto.Nome;
        ator.Nascimento = dto.Nascimento;
        ator.Morte = dto.Morte;
        ator.Genero = dto.Genero;
        ator.Nacionalidade = dto.Nacionalidade;
    }
}
using Gestao.Infra;

namespace Gestao.Models;

public class FilmePost
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateOnly Data { get; set; }
}

public class FilmeGet 
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateOnly Data { get; set; }
    public int Nota { get; set; }
    public int Lucro { get; set; }
    public List<Atores> Elenco { get; set; }
}

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateOnly Data { get; set; }
    public int Nota { get; set; }

    public static Filme DtoToFilme(FilmePost dto) 
    {
        return new Filme()
        {
            Titulo = dto.Titulo,
            Autor = dto.Autor,
            Data = dto.Data,
        };
    }

    public static FilmeGet FilmeToDto(Filme filme)
    {
        return new FilmeGet()
        {
            Id = filme.Id,
            Titulo = filme.Titulo,
            Autor = filme.Autor,
            Data = filme.Data,
            Nota = filme.Nota
        };
    }

    public static void Update(Filme filme, FilmePost dto)
    {
        filme.Titulo = dto.Titulo;
        filme.Autor = dto.Autor;
        filme.Data = dto.Data;
    }
}
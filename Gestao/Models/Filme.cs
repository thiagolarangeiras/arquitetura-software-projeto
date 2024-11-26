namespace Gestao.Models;

public class FilmePost
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateOnly Data { get; set; }
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

    public static void Update(Filme filme, FilmePost dto)
    {
        filme.Titulo = dto.Titulo;
        filme.Autor = dto.Autor;
        filme.Data = dto.Data;
    }
}
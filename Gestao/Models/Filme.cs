namespace Gestao.Models;

public class FilmePost
{
    public string Titulo;
    public string Autor;
    public DateOnly Data;
}

public class Filme
{
    public int Id;
    public string Titulo;
    public string Autor;
    public DateOnly Data;

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
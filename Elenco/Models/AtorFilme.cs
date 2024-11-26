namespace Elenco.Models;

public class AtorFilmePost
{
    public int IdAtor { get; set; }
    public int IdFilme { get; set; }
    public string Papel { get; set; }
}

public class AtorFilme
{
    public int Id { get; set; }
    public int IdAtor { get; set; }
    public int IdFilme { get; set; }
    public string Papel { get; set; }

    public static AtorFilme DtoToCusto(AtorFilmePost dto)
    {
        return new AtorFilme()
        {
            IdAtor = dto.IdAtor,
            IdFilme = dto.IdFilme,
            Papel = dto.Papel
        };
    }

    public static void Update(AtorFilme atorFilme, AtorFilmePost dto)
    {
        atorFilme.IdAtor = dto.IdAtor;
        atorFilme.IdFilme = dto.IdFilme;
        atorFilme.Papel = dto.Papel;
    }
}
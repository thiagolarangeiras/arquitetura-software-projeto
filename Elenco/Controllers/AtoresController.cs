using Elenco.Models;
using Elenco.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Custos.Controllers;

[ApiController]
[Route("[controller]")]
public class AtoresController : Controller
{
    private DataContext _dataContext;
    public AtoresController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpPost]
    public ActionResult<object> Post([FromBody] AtoresPost dto)
    {
        Atores ator = Atores.DtoToCusto(dto);
        _dataContext.Add(ator);
        _dataContext.SaveChanges();
        return ator;
    }

    [HttpGet("{id}")]
    public ActionResult<object> GetById([FromRoute()] int id)
    {
        Atores ator = _dataContext.Atores.Where(x => x.Id == id).SingleOrDefault();
        return ator;
    }

    [HttpGet]
    public ActionResult<object> Get(
        [FromQuery(Name = "page")] int page,
        [FromQuery(Name = "count")] int count,
        [AllowNull][FromQuery(Name = "movie-id")] int movieId
    )
    {
        if (movieId != null && movieId != 0)
        {
            List<Atores> atores = 
            ( 
                from a in _dataContext.Atores
                join b in _dataContext.AtorFilme on a.Id equals b.IdAtor
                where b.IdFilme == movieId
                select a
            ).ToList();
            return atores;
        } 
        {
            int skip;
            if (page != 0)
            {
                skip = count * page;
            }
            else 
            {
                skip = 0;
            }
            

            List<Atores> atores = _dataContext.Atores
            .OrderBy(b => b.Id)
            .Skip(skip)
            .Take(count)
            .ToList();
            return atores;
        }
    }

    [HttpPatch("{id}")]
    public ActionResult<object> Patch([FromRoute] int id, [FromBody] AtoresPost dto)
    {
        Atores ator = _dataContext.Atores.Where(x => x.Id == id).SingleOrDefault();
        Atores.Update(ator, dto);
        _dataContext.SaveChanges();
        return ator;
    }

    [HttpDelete("{id}")]
    public ActionResult<object> Delete([FromRoute] int id)
    {
        Atores ator = _dataContext.Atores.Where(x => x.Id == id).SingleOrDefault();
        _dataContext.Atores.Remove(ator);
        _dataContext.SaveChanges();
        return ator;
    }
}
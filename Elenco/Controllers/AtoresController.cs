using Elenco.Models;
using Elenco.Repo;
using Microsoft.AspNetCore.Mvc;

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
using Custos.Models;
using Custos.Repo;
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
    public ActionResult<object> Post([FromBody] CustoPost dto)
    {
        Atores custo = Atores.DtoToCusto(dto);
        _dataContext.Add(custo);
        _dataContext.SaveChanges();
        return custo;
    }

    [HttpGet("{id}")]
    public ActionResult<object> GetById([FromRoute()] int id)
    {
        Atores custo = _dataContext.Custos.Where(x => x.Id == id).SingleOrDefault();
        return custo;
    }

    [HttpPatch("{id}")]
    public ActionResult<object> Patch([FromRoute] int id, [FromBody] CustoPost dto)
    {
        Atores custo = _dataContext.Custos.Where(x => x.Id == id).SingleOrDefault();
        Atores.Update(custo, dto);
        _dataContext.SaveChanges();
        return custo;
    }

    [HttpDelete("{id}")]
    public ActionResult<object> Delete([FromRoute] int id)
    {
        Atores custo = _dataContext.Custos.Where(x => x.Id == id).SingleOrDefault();
        _dataContext.Custos.Remove(custo);
        _dataContext.SaveChanges();
        return custo;
    }
}
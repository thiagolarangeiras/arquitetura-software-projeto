using Custos.Models;
using Custos.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Custos.Controllers;

[ApiController]
[Route("[controller]")]
public class CustoController : Controller
{
    private DataContext _dataContext;
    public CustoController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpPost]
    public ActionResult<object> Post([FromBody] CustoPost dto)
    {
        Custo custo = Custo.DtoToCusto(dto);
        _dataContext.Add(custo);
        _dataContext.SaveChanges();
        return custo;
    }

    [HttpGet("{id}")]
    public ActionResult<object> GetById([FromRoute()] int id)
    {
        Custo custo = _dataContext.Custos.Where(x => x.Id == id).SingleOrDefault();
        return custo;
    }

    [HttpPatch("{id}")]
    public ActionResult<object> Patch([FromRoute] int id, [FromBody] CustoPost dto)
    {
        Custo custo = _dataContext.Custos.Where(x => x.Id == id).SingleOrDefault();
        Custo.Update(custo, dto);
        _dataContext.SaveChanges();
        return custo;
    }

    [HttpDelete("{id}")]
    public ActionResult<object> Delete([FromRoute] int id)
    {
        Custo custo = _dataContext.Custos.Where(x => x.Id == id).SingleOrDefault();
        _dataContext.Custos.Remove(custo);
        _dataContext.SaveChanges();
        return custo;
    }
}
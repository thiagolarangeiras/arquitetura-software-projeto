using Elenco.Infra;
using Elenco.Models;
using Elenco.Repo;
using Microsoft.AspNetCore.Mvc;
using static Elenco.Infra.Filme;

namespace Custos.Controllers;

[ApiController]
[Route("[controller]")]
public class AtorFilmeController : Controller
{
    private DataContext _dataContext;
    public AtorFilmeController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpPost]
    public ActionResult<object> Post([FromBody] AtorFilmePost dto)
    {
        AtorFilme atorFilme = AtorFilme.DtoToCusto(dto);
        try
        {
            Filme resultado = GestaoInfra.GetMovie(atorFilme.IdFilme);
            if(resultado.Id != atorFilme.IdFilme)
                return Ok();
        } catch (Exception e) 
        {
            return Ok();
        }            
        _dataContext.Add(atorFilme);
        _dataContext.SaveChanges();
        return atorFilme;
    }

    [HttpGet("{id}")]
    public ActionResult<object> GetById([FromRoute()] int id)
    {
        AtorFilme atorFilme = _dataContext.AtorFilme.Where(x => x.Id == id).SingleOrDefault();
        return atorFilme;
    }

    [HttpGet]
    public ActionResult<object> Get()
    {
        List<AtorFilme> atorFilme = _dataContext.AtorFilme.Where(x => x.Id != 0).ToList();
        return atorFilme;
    }

    //[HttpPatch("{id}")]
    //public ActionResult<object> Patch([FromRoute] int id, [FromBody] AtorFilmePost dto)
    //{
    //    AtorFilme atorFilme = _dataContext.AtorFilme.Where(x => x.Id == id).SingleOrDefault();
    //    AtorFilme.Update(atorFilme, dto);
    //    _dataContext.SaveChanges();
    //    return atorFilme;
    //}

    [HttpDelete("{id}")]
    public ActionResult<object> Delete([FromRoute] int id)
    {
        AtorFilme atorFilme = _dataContext.AtorFilme.Where(x => x.Id == id).SingleOrDefault();
        _dataContext.AtorFilme.Remove(atorFilme);
        _dataContext.SaveChanges();
        return atorFilme;
    }
}
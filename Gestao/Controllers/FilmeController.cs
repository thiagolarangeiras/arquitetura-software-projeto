using Gestao.Infra;
using Gestao.Models;
using Gestao.Repo;
using Gestao.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : Controller
{
    private DataContext _dataContext;
    private FilmeService _filmeService;
    public FilmeController(DataContext dataContext)//, FilmeService filmeService)
    {
        _dataContext = dataContext;
        //_filmeService = filmeService;
    }

    [HttpPost]
    public ActionResult<Object> Post([FromBody] FilmePost dto)
    {
        Filme filme = Filme.DtoToFilme(dto);
        _dataContext.Add(filme);
        _dataContext.SaveChanges();
        return filme;
    }

    [HttpGet("{id}")]
    public ActionResult<Object> GetById([FromRoute()] int id)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        return filme;
    }

    [HttpGet]
    public ActionResult<Object> Get([FromQuery(Name = "id")] int id, [FromQuery(Name = "elenco")] bool elenco)
    {
        if (elenco)
        {
            Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
            FilmeGet dto = Filme.FilmeToDto(filme);
            dto.Elenco = ElencoInfra.Get(dto.Id);
            return dto;
        }
        {
            Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
            return filme;
        }
    }

    [HttpPatch("{id}")]
    public ActionResult<Object> Patch([FromRoute] int id, [FromBody] FilmePatch dto)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        Filme.Update(filme, dto);
        _dataContext.SaveChanges();
        return filme;
    }

    [HttpPatch("{id}/custo")]
    public ActionResult<Object> PatchCusto([FromRoute] int id, [FromBody] FilmePatchCusto dto)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        Filme.UpdateValores(filme, dto);
        _dataContext.SaveChanges();
        return filme;
    }

    [HttpDelete("{id}")]
    public ActionResult<Object> Delete([FromRoute] int id)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        _dataContext.Filme.Remove(filme);
        _dataContext.SaveChanges();
        return filme;
    }
}
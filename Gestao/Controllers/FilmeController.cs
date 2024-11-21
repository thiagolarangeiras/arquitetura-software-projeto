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
    public FilmeController(DataContext dataContext, FilmeService filmeService)
    {
        _dataContext = dataContext;
        _filmeService = filmeService;
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
    public ActionResult<Object> GetById([FromRoute() ] int id)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        return filme;
    }

    [HttpPatch("{id}")]
    public ActionResult<Object> Patch([FromRoute] int id, [FromBody] FilmePost dto)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        Filme.Update(filme, dto);
        _dataContext.SaveChanges();
        return filme;
    }

    [HttpDelete]
    public ActionResult<Object> Delete([FromRoute] int id)
    {
        Filme filme = _dataContext.Filme.Where(x => x.Id == id).SingleOrDefault();
        _dataContext.Filme.Remove(filme);
        _dataContext.SaveChanges();
        return filme;
    }
}
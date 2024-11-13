using Gestao.Models;
using Gestao.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Controllers;

[ApiController]
[Route("[controller]")]
public class TesteController : ControllerBase
{
    private DataContext _dataContext;
    public TesteController(DataContext dataContext) 
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public ActionResult<Teste> Create()
    {
        var a = new Teste()
        {
            Id = 1,
            Texto = "awd"
        };
        _dataContext.Add(a);
        _dataContext.SaveChanges();
        return a;
    }
}

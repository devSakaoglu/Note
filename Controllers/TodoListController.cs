using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Note.Models;
public class TodoListController : Controller
{
    [HttpPost]
    public IActionResult Create([ModelBinder]Todo todo )
    {


        return View();
    }
 
}
using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller
{
    private readonly LabManagerContext _context;

    public ComputerController(LabManagerContext context)
    {
        _context = context;
    }

    

    public IActionResult Index()
    {
        return View(_context.Computers);
    }

    public IActionResult Show(int id)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound();
        }
        else
        {
            return View(computer);
        }
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Creating([FromForm] Computer computerViewModel) 
    {
        Computer computer = new Computer(computerViewModel.Id, computerViewModel.Ram, computerViewModel.Processor);
        _context.Computers.Add(computer);
        _context.SaveChanges();
        return View("Index");
    }

    public IActionResult Update(int id) 
    {
        Computer computer = _context.Computers.Find(id);

        if(!ModelState.IsValid)
        {
            return Content("Computador não existe");
        }
        else
        {
            return View(computer);
        }
    }

    public IActionResult Updating([FromForm] Computer computerViewModel)
    {
        Computer computer = _context.Computers.Find(computerViewModel.Id);

        if(!ModelState.IsValid)
        {
            return Content("Computer com Id não encontrado");
        }
        else
        {
            computer.Ram = computerViewModel.Ram;
            computer.Processor = computerViewModel.Processor;
            _context.Computers.Update(computer);
            _context.SaveChanges();
            return View("Index");
        }
    }

    public IActionResult Delete(int id)
    {
        _context.Computers.Remove(_context.Computers.Find(id));
        _context.SaveChanges();
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class LabController : Controller
{
    private readonly LabManagerContext _context;

    public LabController (LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Labs);
    }

    public IActionResult Show(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound();
        }
        else
        {
            return View(lab);
        }
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Creating([FromForm] Lab labViewModel) 
    {
        Lab lab = new Lab(labViewModel.Id, labViewModel.Number, labViewModel.Name, labViewModel.Sector);
        _context.Labs.Add(lab);
        _context.SaveChanges();
        return View("Index");
    }

    public IActionResult Update(int id) 
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return Content("Computador não existe");
        }
        else
        {
            return View(lab);
        }
    }

    public IActionResult Updating([FromForm] Lab labViewModel)
    {
        Lab lab = _context.Labs.Find(labViewModel.Id);

        if(lab == null)
        {
            return Content("Lab com Id não encontrado");
        }
        else
        {
            lab.Number = labViewModel.Number;
            lab.Name = labViewModel.Name;
            lab.Sector = labViewModel.Sector;
            _context.Labs.Update(lab);
            _context.SaveChanges();
            return View("Index");
        }
    }

    public IActionResult Delete(int id)
    {
        _context.Labs.Remove(_context.Labs.Find(id));
        _context.SaveChanges();
        return View();
    }
}

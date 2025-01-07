
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SimpleToDoList.Data;
using SimpleToDoList.Models;

namespace SimpleToDoList.Controllers;

public class ToDoController : Controller {

    private readonly ApplicationDBContext _db;

    public ToDoController(ApplicationDBContext db){
        _db = db;
    }
    public IActionResult Index(){
        var objToDoList = _db.ToDos.ToList();
        return View(objToDoList);
    }

    // GET : Create
    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ToDo obj){
        if (ModelState.IsValid){
            _db.ToDos.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "ToDo created successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    // GET : Edit
    public IActionResult Edit(int? id){
        if(id == null || id == 0){
            return NotFound();
        }
        var todoFromDb = _db.ToDos.Find(id);
        if (todoFromDb == null){
            return NotFound();
        }
        
        return View(todoFromDb);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(ToDo obj){
        if (ModelState.IsValid){
            _db.ToDos.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "ToDo edited successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    // GET : Delete
    public IActionResult Delete(int? id){
        if(id == null || id == 0){
            return NotFound();
        }
        var todoFromDb = _db.ToDos.Find(id);
        if (todoFromDb == null){
            return NotFound();
        }
        DeleteViewModel dvm = new DeleteViewModel();
        dvm.TD = todoFromDb;
        return View(dvm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(DeleteViewModel dvm){
        if(ModelState.IsValid){
            _db.ToDos.Remove(dvm.TD);
            _db.SaveChanges();
            TempData["success"] = "ToDo deleted successfully";
            return RedirectToAction("Index");
        }
        return View(dvm);
    }
}

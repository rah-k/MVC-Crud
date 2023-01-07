using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudOperations.Models;

namespace CrudOperations.Controllers
{
    public class HomeController : Controller
    {
        
private readonly SampleCrudContext _sampleCrud = null;

        public HomeController(SampleCrudContext sampleCrud)
        {
            _sampleCrud = sampleCrud;
        }


        public IActionResult Index()
        {
             
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        //Crud Operations
        [HttpGet]
        public IActionResult Home()//Getting All Details from DataBase 
        {
            var stdlist = _sampleCrud.StudentData.ToList();
            return View(stdlist);
        }

     
        public async Task<IActionResult>Create(StudentModel student) // Post Method For Adding new data
        {
            if (student.Name != null)
            {
                _sampleCrud.StudentData.Add(student);
                await _sampleCrud.SaveChangesAsync();
            }

            return RedirectToAction("Home");
        }

      
        public async Task<IActionResult>DeleteStd(int id)// Delete Method For Removing data from Database 
        {
            var std = await _sampleCrud.StudentData.FindAsync(id);
            _sampleCrud.StudentData.Remove(std);
            await _sampleCrud.SaveChangesAsync();

            return RedirectToAction("Home");
        }
       
        public async Task<IActionResult>Edit(StudentModel stdEdit)// For Mdification 
        {
            StudentModel obj = new StudentModel();
            if (ModelState.IsValid)
            {
                obj.Id =stdEdit.Id;
                obj.Name = stdEdit.Name;
                obj.Standard = stdEdit.Standard;
                obj.Age = stdEdit.Age;
            }

            _sampleCrud.Entry(obj).State = EntityState.Modified;
            await _sampleCrud.SaveChangesAsync();

            return RedirectToAction("Home");
        }
        
    }
}

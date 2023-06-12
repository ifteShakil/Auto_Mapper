using AutoMapper;
using AutoMapperCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AutoMapperCore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly myContext _context;
        private readonly IMapper mapper;

        public EmployeeController(myContext my, IMapper m)
        {
            _context = my;
            mapper = m;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmpVM emp)
        {
            if(ModelState.IsValid)
            {
                var model = mapper.Map<Employee>(emp);

                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Edit(int?id)
        {
           
            return View(_context.Employees.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(EmpVM emp)
        {
                var model = mapper.Map<Employee>(emp);

                _context.Employees.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var d = _context.Employees.Find(id);
            return View(d);
        }
        [HttpPost]
        public IActionResult Delete(EmpVM emp)
        {
            //var d = _context.Employees.Find(id);
            if (ModelState.IsValid)
            {
                var model = mapper.Map<Employee>(emp);

                _context.Remove(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            var d = _context.Employees.Find(id);
            return View(d);
        }
    }
}

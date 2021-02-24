using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace EmployeeMgmt.Controllers
{
    public class BookController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var context = new EmployeeMgmtContext())
            {
                var model = await context.Department.Include(a => a.Employees).AsNoTracking().ToListAsync();
                return View(model);
            }
            
        }  
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using(var context = new EmployeeMgmtContext())
            {
                var department = await context.Department.Select(a => new SelectListItem {
                    Value = a.Id.ToString(), 
                    Text = $"{a.Name} {a.Location}"
                }).ToListAsync();
                ViewBag.Department = department;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Id")] Employees employee)
        {
            using (var context = new EmployeeMgmtContext())
            {
                context.Employees.Add(employee);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
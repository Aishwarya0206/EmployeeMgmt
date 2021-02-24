using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace EmployeeMgmt.Controllers
{
    public class DepartmentController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var context = new EmployeeMgmtContext())
            {
                var model = await context.Department.AsNoTracking().ToListAsync();
                return View(model);
            }
            
        }  
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Location")] Department department)
        {
            using (var context = new EmployeeMgmtContext())
            {
                context.Add(department);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
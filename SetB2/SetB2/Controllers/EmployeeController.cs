using Microsoft.AspNetCore.Mvc;
using SetB2.Models;
using SetB2.Repository;
using System.Data.SqlClient;

namespace SetB2.Controllers
{
    public class EmployeeController : Controller
    {
        EmpRepo e1=new EmpRepo();
        public IActionResult form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form(Employees emp)
        {
            try
            {
                e1.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            catch (SqlException ex)
            {
                return Content(ex.Message);
            }
        }
        public IActionResult Index()
        {
            IEnumerable<Employees> datas = e1.FetchData();
            return View(datas);
        }
    }
}

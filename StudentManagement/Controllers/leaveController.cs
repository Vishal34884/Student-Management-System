using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models.Domain;
using StudentManagement.Models.DTO;
using System.Security.Cryptography;

namespace StudentManagement.Controllers
{
    public class leaveController : Controller
    {
        /*private readonly DatabaseContext _context; 
        public leaveController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult SaveUser(string lid,string StudentId, string StudentName, string Department, int NoOfDays, string Reason)
        {
            var l = new leave { lid = lid };
            var s = new leave { StudentId = StudentId };
            var Sn = new leave { StudentName = StudentName };
            var Dep = new leave { Department = Department };
            var Nd = new leave { NoOfDays = NoOfDays };
            var rea = new leave { Reason = Reason };
            _context.Users.Add(l);
            _context.Users.Add(s);
            _context.Users.Add(Sn);
            _context.Users.Add(Dep);
            _context.Users.Add(Nd);
            _context.Users.Add(rea);
            _context.SaveChanges();
            return View();
        }*/


        private readonly DatabaseContext _context; public leaveController(DatabaseContext context)
        {
            _context = context;
        }     // Leave request form action
        public IActionResult Leave()
        {
            return View();
        }     // Processing leave request form action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Leave(leave leaveRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Leave.Add(leaveRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaveRequest);
        }     // Admin panel action
        public async Task<IActionResult> Index()
        {
            var leaveRequests = await _context.Leave.ToListAsync();
            return View(leaveRequests);
        }

    }
}


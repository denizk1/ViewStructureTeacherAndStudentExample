using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher{ID=1,Name="Deniz",Gender="woman"},
            new Teacher{ID=2,Name="Ayse",Gender="woman"},
            new Teacher{ID=3,Name="Yavuz",Gender="man"}
        };
        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }
        public IActionResult DeleteTeacher(int id)
        {
            Teacher teacher = teachers.Find(t => t.ID == id);
            return View(teacher);
        }
    }
}

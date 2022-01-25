using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewStructure.Models.ViewComponents
{
    public class WorkChartViewComponent:ViewComponent
    {
        List<WorkChart> workCharts = new List<WorkChart>()
        {
            new WorkChart("Deniz",new List<bool>{true,false,true,false,true}),
            new WorkChart("Ayse",new List<bool>{true,true,true,false,true}),
            new WorkChart("Yavuz",new List<bool>{true,false,false,false,true})
        };
        public IViewComponentResult Invoke()
        {
            return View(workCharts);
        }
    }
}

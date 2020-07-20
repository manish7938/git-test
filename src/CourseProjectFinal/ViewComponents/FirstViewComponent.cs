using CourseProjectFinal.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.ViewComponents
{
    public class FirstViewComponent:ViewComponent
    {
        private IMyInjectedService myService;

        public FirstViewComponent(IMyInjectedService service)
        {
            myService = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var myItem = await GetGuid();
            return View("Default",myItem);
        }

        private async Task<IMyInjectedService> GetGuid()
        {

            return await Task.FromResult<IMyInjectedService>(myService);

        }
    }
}

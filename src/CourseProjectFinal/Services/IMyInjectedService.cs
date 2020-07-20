using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Services
{
    public interface IMyInjectedService
    {
        Guid MyGuid { get; set; }
    }

    public class MyInjectedService: IMyInjectedService
    {
        public Guid MyGuid { get; set; }

        public MyInjectedService()
        {
            this.MyGuid = Guid.NewGuid();
        }

       


    }
}

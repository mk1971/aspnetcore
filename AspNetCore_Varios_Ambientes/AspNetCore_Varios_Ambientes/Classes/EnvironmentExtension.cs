using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Varios_Ambientes.Classes
{
    public static class EnvironmentExtension
    {
        [Obsolete]
        public static bool IsTest(this IHostingEnvironment env)
        {
            return env.IsEnvironment(StandardEnvironment.Test);
        }

        public static bool IsTestExt(this IHostingEnvironment env) => env.IsEnvironment(StandardEnvironment.TestExt);

    }
}

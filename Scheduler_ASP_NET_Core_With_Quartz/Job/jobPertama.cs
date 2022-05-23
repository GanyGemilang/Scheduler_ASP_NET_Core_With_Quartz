using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler_ASP_NET_Core_With_Quartz.Job
{
    [DisallowConcurrentExecution]
    public class jobPertama : IJob
    {
        private readonly ILogger Log;
        public jobPertama(ILogger<jobPertama> Log)
        {
            this.Log = Log;
        }
        public Task Execute(IJobExecutionContext context)
        {
            Log.LogWarning($"Job Berhasil Dijalankan {DateTime.Now:U}");
            Console.WriteLine($"Job Berhasil Dijalankan {DateTime.Now:U}");
            return Task.CompletedTask;
        }
    }
}

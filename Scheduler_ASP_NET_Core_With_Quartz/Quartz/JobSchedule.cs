using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler_ASP_NET_Core_With_Quartz.Quartz
{
    public class JobSchedule
    {
        public Type JobType { get; }
        public string CronExpression { get; }
        public JobSchedule(Type jobType, string cronExpression)
        {
            JobType = jobType;
            CronExpression = cronExpression;
        }
    }
}

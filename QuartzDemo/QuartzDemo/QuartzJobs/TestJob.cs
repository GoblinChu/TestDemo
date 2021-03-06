﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using log4net;

namespace QuartzDemo.QuartzJobs
{
    public sealed class TestJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));
        public void Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("TestJob测试");
        }
    }
}

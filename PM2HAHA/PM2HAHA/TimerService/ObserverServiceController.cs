using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using PM2HAHA.Controllers;

namespace PM2HAHA.TimerService
{
    public class ObserverService : IHostedService, IDisposable
    {
        private int testcount;
        private Timer _timer;
        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                //TimeSpan.FromMinutes(5));
                TimeSpan.FromSeconds(20));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
           try
            {

                testcount++;
                ApiController test = new ApiController();
            }
            catch (Exception ex)
            {

            }

        }

            public Task StopAsync(CancellationToken cancellationToken)
        {
           

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
    }
   
}
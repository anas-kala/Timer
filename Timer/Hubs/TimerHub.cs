using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Timer.Hubs
{
    public class TimerHub :Hub
    {
        public async Task SendMessage()
        {
            while (true)
            {
                var year = DateTime.Now.Year;
                var month = DateTime.Now.Month;
                var day = DateTime.Now.Day;                
                var hour = DateTime.Now.Hour;
                var minute = DateTime.Now.Minute;
                var second = DateTime.Now.Second;
                await Clients.All.SendAsync("ReceiveMessage", year,month,day,hour,minute,second);
                Thread.Sleep(1000);
            }
        }
    }
}

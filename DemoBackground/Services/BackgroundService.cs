using System;
using System.Threading.Tasks;
using Matcha.BackgroundService;

namespace DemoBackground.Services
{
    public class BackgroundService : IPeriodicTask
    {
        public TimeSpan Interval { get; set; }

        public BackgroundService(int seconds)
        {
            Interval = TimeSpan.FromSeconds(seconds);
        }

        public async Task<bool> StartJob()
        {
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));

            //Return true para continuar
            return true;

            //Return false para parar
            //return false;
        }
    }
}
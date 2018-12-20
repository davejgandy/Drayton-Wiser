using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wiser;
using System.IO;
using System.Threading;

namespace TempRecorder
{
    class Program
    {
        static WiserConnection wiserConnection;   
        static void Main(string[] args)
        {
            wiserConnection = new WiserConnection();
            ThreadPool.QueueUserWorkItem((o) => { RecordData(); });
            Console.ReadKey();
        }

        static void RecordData()
        {
            while (true)
            {
                string outputString = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                var heatHub = wiserConnection.GetData();

                foreach (var room in heatHub.Room)
                {
                    outputString += string.Format(",{0}", (float)room.CalculatedTemperature/10);
                }

                outputString += "\n";
                Console.Write(outputString);

                var file = GetOutputPath();
                File.AppendAllText(GetOutputPath(), outputString);

                Thread.Sleep(10*60*1000);
            }
        }

        static string GetOutputPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WiserTemps.csv");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp
{
    public static class AdditionalSystemInfo
    {
        private const string CpuTemperatureFilePath =
#if DEBUG
            @"D:\Projects\Others\R-Pi\DotNetCore\TestWebApp\FakeCpuTemperatureFile.txt";
#else
            "/sys/class/thermal/thermal_zone0/temp";
#endif

        private const string RaspberryModelInfoFilePath =
#if DEBUG
            @"D:\Projects\Others\R-Pi\DotNetCore\TestWebApp\FakeRaspberryModelInfoFile.txt";
#else
            "/proc/device-tree/model";
#endif

        public static double GetCpuTemperature()
        {
            if (File.Exists(CpuTemperatureFilePath))
            {
                var content = File.ReadAllLines(CpuTemperatureFilePath);
                if (content.Length > 0 && int.TryParse(content[0], out int value))
                {
                    double result = value / 1000d;
                    return (Math.Round(result, 1));
                }
            }

            return (0);
        }

        // var output = ProcessRunner.GetProcessOutputAsync(command, ...).Result;

        public static string GetModelInfo()
        {
            if (File.Exists(RaspberryModelInfoFilePath))
            {
                var content = File.ReadAllLines(RaspberryModelInfoFilePath);
                if (content.Length > 0)
                {
                    var result = content[0];
                    result = result.TrimEnd('\0'); 
                    return (result.Replace("\n", string.Empty).Trim());
                }
            }

            return ("Unknown");
        }
    }
}

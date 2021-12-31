using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows;

namespace Info.Classes
{
    /// <summary>
    /// Данные о текущем компе
    /// </summary>
    internal static class Hardware
    {
        public static string OperationSystem { get; }
        public static string Drives { get; }
        public static string RAM { get; }
        public static string CPU { get; }
        public static string Motherboard { get; }
        public static string GPU { get; }
        public static string Monitor { get; }

        static Hardware()
        {
            OperationSystem = new Func<string>(() =>
            {
                try
                {
                    var caption = GetComponent("Win32_OperatingSystem", "Caption");
                    var architecture = GetComponent("Win32_OperatingSystem", "OSArchitecture");
                    return $"{caption} {architecture}";
                }
                catch (Exception) { return ""; }
            })();
            Drives = new Func<string>(() =>
            {
                try
                {
                    var allDrives = DriveInfo.GetDrives();
                    string text = "";
                    foreach (var drive in allDrives)
                    {
                        var textVolumeLabel = drive.VolumeLabel == "" ? "¯\\_(ツ)_//¯" : drive.VolumeLabel;
                        text += $"{drive.Name.Remove(drive.Name.Length - 1)} ({textVolumeLabel}, {drive.DriveFormat}) " +
                                $"[{Sizer(drive.AvailableFreeSpace)}/{Sizer(drive.TotalSize)}]\n";
                    }
                    return text;
                }
                catch (Exception) { return ""; }
            })();
            RAM = new Func<string>(() =>
            {
                try
                {
                    return $"{Sizer(Convert.ToDouble(GetComponent("Win32_ComputerSystem", "TotalPhysicalMemory")))}";
                }
                catch (Exception) { return ""; }
            })();
            CPU = new Func<string>(() =>
            {
                try
                {
                    var name = new StringBuilder(GetComponent("Win32_Processor", "Name"));
                    return $"{name}";
                }
                catch (Exception) { return ""; }
            })();
            Motherboard = new Func<string>(() =>
            {
                try
                {
                    var manufacturer = GetComponent("Win32_BaseBoard", "Manufacturer");
                    var product = GetComponent("Win32_BaseBoard", "Product");
                    return $"{manufacturer} {product}";
                }
                catch (Exception) { return ""; }
            })();
            GPU = new Func<string>(() =>
            {
                try
                {
                    var name = GetComponent("Win32_VideoController", "Name");
                    var adapterram = Convert.ToInt32(GetComponent("Win32_VideoController", "AdapterRAM"));
                    return $"{name}, {Sizer(adapterram)}";
                }
                catch (Exception) { return ""; }
            })();
            Monitor = new Func<string>(() =>
            {
                try
                {
                    var name = GetComponent("Win32_DesktopMonitor", "Name");
                    var refreshrate = GetComponent("Win32_VideoController", "MaxRefreshRate");
                    var resolution = $"{SystemParameters.PrimaryScreenWidth} x {SystemParameters.PrimaryScreenHeight}";
                    return $"{name} @{refreshrate} ({resolution})";
                }
                catch (Exception) { return ""; }
            })();
        }

        /// <summary>
        /// Возвращает строку из поля syntax таблицы hwclass (CIMWin32 WMI Providers).
        /// </summary>
        /// <param name="hwclass"></param>
        /// <param name="syntax"></param>
        /// <returns></returns>
        private static string GetComponent(string hwclass, string syntax)
        {
            try
            {
                return string.Join("\n", new ManagementObjectSearcher($"select {syntax} from {hwclass}").Get()
                  .Cast<ManagementBaseObject>()
                  .Select(mo => mo[syntax]));
            }
            catch (Exception) { return ""; }
        }

        // Загруженность ОЗУ
        public static string UsageRAM
        {
            get
            {
                try
                {
                    var totalmem = Convert.ToDouble(GetComponent("Win32_OPeratingSystem", "TotalVisibleMemorySize")) * 1024;
                    var freemem = Convert.ToDouble(GetComponent("Win32_OPeratingSystem", "FreePhysicalMemory")) * 1024;

                    var usagemem = Math.Round(totalmem - freemem);
                    var percentusagemem = (usagemem / totalmem) * 100;

                    return $"({string.Format("{0:0.0}%", percentusagemem)}) {Sizer(usagemem)}/{Sizer(totalmem)} [Свободно: {Sizer(freemem)}]";
                }
                catch (Exception) { return ""; }
            }
        }

        // Получаем читаемый размер
        public static string Sizer(double countBytes)
        {
            string[] type = { "B", "KB", "MB", "GB" };
            if (countBytes == 0)
                return $"0 {type[0]}";

            double bytes = Math.Abs(countBytes);
            int place = (int)Math.Floor(Math.Log(bytes, 1024));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return $"{Math.Sign(countBytes) * num} {type[place]}";
        }
    }
}

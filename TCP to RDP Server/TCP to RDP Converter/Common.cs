using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_to_RDP_Converter
{
    public class Common
    {
        public static void RegisterInStartup(bool isChecked, string executablePath)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", executablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }
    }
}

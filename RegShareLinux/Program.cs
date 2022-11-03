using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegShareLinux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Lsa").SetValue("everyoneincludesanonymous", 1);
            Registry.LocalMachine.CreateSubKey(@"SYSTEM\ControlSet001\Services\LanmanServer\Parameters").SetValue("NullSessionShares", new string[] { "Common" }, RegistryValueKind.MultiString);
            Registry.LocalMachine.CreateSubKey(@"SYSTEM\ControlSet001\Control\Lsa\").SetValue("everyoneincludesanonymous", 1);
            Registry.LocalMachine.CreateSubKey(@"SYSTEM\ControlSet001\Services\LanmanServer\Parameters").SetValue("NullSessionShares", new string[] { "Common" }, RegistryValueKind.MultiString);
            
        }
    }   
}

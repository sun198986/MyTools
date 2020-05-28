using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Framework.ProcessUtil
{
    public class ConcreteProcessControl: ProcessControl
    {
        public void KillWordProcess()
        {
            Process myProcess = new Process();
            Process[] wordProcess = Process.GetProcessesByName("winword");
            foreach (Process pro in wordProcess) //这里是找到那些没有界面的Word进程
            {
                pro.Kill();
            }
        }
    }
}

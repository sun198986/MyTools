using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framwork.FileUtil.Interface
{
    public class ConcreteFileControl : FileControl
    {
        public void CreateDirectory(string directoryUrl)
        {
            if (!Directory.Exists(directoryUrl))
            {
                Directory.CreateDirectory(directoryUrl);
            }
        }
    }
}

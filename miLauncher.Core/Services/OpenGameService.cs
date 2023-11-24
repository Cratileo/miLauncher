using System;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using miLauncher.Core.Contracts.Services;

namespace miLauncher.Core.Services;
public class OpenGameService : IOpenGameService
{
    public void openGame(string gamePath)
    {
        if(File.Exists(gamePath)) 
        {
            Process.Start(gamePath);
            //TODO:对接AutoExit
            //IsAutoExit();
        }
        //TODO:无法打开弹对话框
    }
}

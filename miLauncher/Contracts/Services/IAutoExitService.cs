using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;

namespace miLauncher.Contracts.Services;
public interface IAutoExitService
{
    Task InitializeAsync();
}

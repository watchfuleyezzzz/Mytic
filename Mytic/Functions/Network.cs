using System;
using System.Diagnostics;

namespace Mytic.Functions
{
    class Network
    {
        public void OpenURL(String URL)
        {
            Process.Start(URL);
            return;
        }
    }
}

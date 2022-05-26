using System;
using System.Threading;

namespace phptravelstest
{
    public class OpenUrl
    {
        public static void GoTo(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
            Thread.Sleep(1000);

        }
    }
}
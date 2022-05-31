using System;

namespace ConsoleApp2
{
    internal class ChromeDriver
    {
        private object chomeOptions;

        public ChromeDriver()
        {
        }

        public ChromeDriver(object chomeOptions)
        {
            this.chomeOptions = chomeOptions;
        }

        internal object Manage()
        {
            throw new NotImplementedException();
        }
    }
}
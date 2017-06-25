using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Satellite
{
    public class SatelliteConsole : IDisposable
    {
        public string Title
        {
            get
            {
                return Console.Title;
            }
            set
            {
                Console.Title = value;
            }
        }

        private bool _close;

        private StreamWriter _swOut;
        private StreamReader _swIn;

        public SatelliteConsole(bool disableClose)
        {
            _close = disableClose;
        }

        public void Attach()
        {
            var hwnd = Definitions.GetConsoleWindow();

            if (hwnd == IntPtr.Zero)
            {
                Definitions.AllocConsole();
                Definitions.SetConsoleMode(hwnd, 2);

                Definitions.SetConsoleCtrlHandler(null, true);
                
                if (File.Exists(this.Title))
                    this.Title = "Satellite Console";
            }
            else
            {
                Definitions.ShowWindow(hwnd, 5);
            }

            if (_close)
                DisableClose(hwnd);

            _swIn = new StreamReader(Console.OpenStandardInput());
            _swOut = new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            };
            
            Console.SetIn(_swIn);
            Console.SetOut(_swOut);
        }

        public void Detatch()
        {
            Definitions.ShowWindow(Definitions.GetConsoleWindow(), 0);
        }

        public void Write(string s)
        {
            _swOut.Write(s);
        }

        public void WriteLine(string s)
        {
            _swOut.WriteLine(s);
        }
        
        public string ReadLine()
        {
            return _swIn.ReadLine();
        }

        private void DisableClose(IntPtr hwnd)
        {
            if (hwnd == IntPtr.Zero)
                hwnd = Definitions.GetConsoleWindow();

            if (hwnd != null)
                Definitions.DeleteMenu(Definitions.GetSystemMenu(hwnd, false), 61536, 0);
        }

        public void Dispose()
        {
            Definitions.FreeConsole();

            _swIn.Dispose();
            _swOut.Dispose();
        }
    }
}

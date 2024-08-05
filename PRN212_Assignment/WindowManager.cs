using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PRN212_Assignment
{
    public static class WindowManager
    {
        public static List<Window> OpenWindows { get; } = new List<Window>();

        public static void AddWindow(Window window)
        {
            OpenWindows.Add(window);
            window.Closed += (sender, e) => OpenWindows.Remove(window);
        }

        public static void CloseAllWindows()
        {
            foreach (var window in OpenWindows.ToList())
            {
                window.Close();
            }
            OpenWindows.Clear();
        }
    }
}

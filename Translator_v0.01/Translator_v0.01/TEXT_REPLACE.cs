using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Translator_v0._01
{
    internal class TEXT_REPLACE
    {
        internal static void Replace(string sentence)
        {
            string writeThis = sentence;
            writeThis = Regex.Unescape(writeThis);
            //Task.Delay(500);
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyDown(VirtualKeyCode.CONTROL);
            sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
            sim.Keyboard.KeyUp(VirtualKeyCode.CONTROL);
            writeThis = Regex.Unescape(writeThis);
            foreach (char c in writeThis)
            {
                SendKeys.Send(c.ToString());
            }
            

        }

        
    }
}

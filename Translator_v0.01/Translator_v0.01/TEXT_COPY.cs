using InputSimulatorStandard.Native;
using InputSimulatorStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator_v0._01
{
//copy user text
    internal class TEXT_COPY
    {
        internal static async Task CopyText(bool all)
        {
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyDown(VirtualKeyCode.CONTROL);
            await Task.Delay(1);
            if (all) //if want to select all before copy 
            {
                sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                await Task.Delay(1);
            }
            
            sim.Keyboard.KeyPress(VirtualKeyCode.VK_C);
            await Task.Delay(1);
            sim.Keyboard.KeyUp(VirtualKeyCode.CONTROL);
            await Task.Delay(1);
            return;
        }
    }
}

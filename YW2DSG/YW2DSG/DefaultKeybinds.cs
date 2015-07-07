using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace YW2DSG
{
    class DefaultKeybinds
    {

        protected void RestoreKB(KeyBinds keyBinds)
        {
            KeyBinds.Default.Exit = Keys.Escape;
        }
    }
}

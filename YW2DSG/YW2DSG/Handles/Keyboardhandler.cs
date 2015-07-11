using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace YW2DSG.Handles
{
    class Keyboardhandler
    {
        KeyboardState kb;
        string keys;
        
        public void InitializeKeyBoard()
        {
            kb = new KeyboardState();
        }

        public void UpdateKeyBoard()
        {
            kb = Keyboard.GetState();
         }

    }
}

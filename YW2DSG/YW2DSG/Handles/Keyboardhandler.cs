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
        
        public bool InitializeKeyBoard()
        {
            kb = new KeyboardState();
            return false;
        }

        public Keyboardhandler()
        {
            
        }

        public void UpdateKeyBoard()
        {
            kb = Keyboard.GetState();
         }

    }
}

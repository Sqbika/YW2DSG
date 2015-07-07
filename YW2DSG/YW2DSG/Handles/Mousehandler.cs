using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace YW2DSG.Handles
{
    class Mousehandler
    {
        MouseState ms;
        Vector2 MousePosition;

        public bool InitialzeMouseHandler()
        {
            MousePosition = new Vector2(MousePosition.X, MousePosition.Y);
            return false;
        }

        public Vector2 GetMousePos()
        {
            return MousePosition;
        }

        public Vector2 GetMousePosVectored(Vector2 MovedMap)
        {
            return MousePosition += MovedMap;
        }

        public void UpdateMS()
        {
            MousePosition = new Vector2(MousePosition.X, MousePosition.Y);
        }
    }
}

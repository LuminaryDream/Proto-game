using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Proto_game
{
    public interface IUpdate
    {
        void Update(KeyboardState new_Keyboard_Sate, KeyboardState old_Keyboard_Sate);
    }
    public interface IDraw
    {
        Texture2D texture {get;}
        void Draw();
    }
}

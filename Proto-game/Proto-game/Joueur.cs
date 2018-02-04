using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Proto_game 
{
    class Joueur : IUpdate , IDraw
    {
        Texture2D m_texture;
        public Joueur(ContentManager content)
        {
            m_texture = content.Load<Texture2D>("Joueur");
        }

        public void Update(KeyboardState new_K, KeyboardState old_K)
        {

        }
        public void Draw()
        {

        }
        public Texture2D texture
        {
            get { return m_texture; }
        }
    }
}

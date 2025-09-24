using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Screens;
using MonoPokeSharp.Screens;

namespace MonoPokeSharp.Screens
{
    public class MenuScreen : BaseScreen
    {
        public MenuScreen(Game1 game) : base(game)
        {

        }

        public override void LoadContent()
        {
            // Load menu content here
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            // Update menu logic here
            Console.WriteLine("Menu Screen Activated");
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
        }
    }
}
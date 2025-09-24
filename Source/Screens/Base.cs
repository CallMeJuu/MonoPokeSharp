using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Screens;

namespace MonoPokeSharp.Screens
{
    public abstract class BaseScreen : GameScreen
    {
        protected new Game1 Game => (Game1)base.Game;
        protected SpriteBatch SpriteBatch { get; private set; }

        protected BaseScreen(Game1 game) : base(game)
        {

        }

        public override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
        }

        public override void UnloadContent()
        {
            SpriteBatch?.Dispose();
            base.UnloadContent();
        }
    }
}
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using MonoPokeSharp.Screens;

namespace MonoPokeSharp
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private ScreenManager screenManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {
            screenManager = new ScreenManager();
            Components.Add(screenManager);
            screenManager.LoadScreen(new MenuScreen(this));
        }
    }
}
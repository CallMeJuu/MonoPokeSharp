using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoPokeSharp;

public class Game1 : Game
{
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        // 1 of all we need to clear the screen
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // 2 then we can begin our spritebatch
        spriteBatch.Begin();

        // 3 here we would draw our sprites
        //spriteBatch.Draw(...);

        // 4 finally we end our spritebatch
        spriteBatch.End();
        
        // 5 and we call the base draw method
        base.Draw(gameTime);
    }
}

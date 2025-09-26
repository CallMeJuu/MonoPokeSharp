using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Graphics;

namespace MonoPokeSharp.Entities
{
    public class Player
    {
        public Vector2 Position;
        public float Speed;
        public enum Direction
        {
            Down,
            Left,
            Right,
            Up
        }
        public enum State
        {
            Idle,
            Walking
        }
        public Texture2DAtlas PlayerTexture;
        public SpriteSheet PlayerSpriteSheet;
        public AnimatedSprite PlayerSprite;
        public Player(float x, float y)
        {
            Position.X = x;
            Position.Y = y;
            Speed = 150;
        }

        public void LoadContent()
        {

        }

        public void Update(GameTime gameTime, SpriteBatch spriteBatch)
        {

        }

        public void Draw(GameTime gameTime)
        {

        }

        public void HandleInput()
        {

        }

        public void Move()
        {
            
        }
    }
}
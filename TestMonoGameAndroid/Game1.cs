using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace TestMonoGameAndroid
{
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        Texture2D _texture;
        Color _color = Color.White;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
            _graphics.IsFullScreen = true;
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _texture = Content.Load<Texture2D>("chuck");
        }

        protected override void Update(GameTime gameTime)
        {
            var touches = TouchPanel.GetState();
            if (touches.Count > 0)
            {
                const int step = 4;
                _color.R -= step;
                _color.G -= step;
                _color.B -= step;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, Vector2.Zero, _color);
            _spriteBatch.End();
        }
    }
}
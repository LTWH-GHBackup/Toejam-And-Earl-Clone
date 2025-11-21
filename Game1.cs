using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    public class ToeJamAndEarlFirstBatch : Game
    {
        private GraphicsDeviceManager _graphics;

        DemoManager _demoManager;
        Demo activeDemo;

        public ToeJamAndEarlFirstBatch()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = 1200;
            _graphics.PreferredBackBufferWidth = 1920;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            FileManager.Create();
            InputManager.Create();

            _demoManager = new(GraphicsDevice, _graphics.PreferredBackBufferHeight, _graphics.PreferredBackBufferWidth);
            _demoManager.SetActiveDemo((int)Demo.Name.FourWayScrolling);
            activeDemo = _demoManager.GetActiveDemo();

            InputManager.SetActiveBindList((int)activeDemo.getName());
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back ==
                ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            InputManager.Update(gameTime);
            activeDemo.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            activeDemo.Draw();

            base.Draw(gameTime);
        }
    }
}

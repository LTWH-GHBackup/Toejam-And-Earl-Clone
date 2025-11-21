using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1;

namespace ToeJamAndEarlFirstBatch
{
    public class GameManager
    {
        public enum State : int
        {
            gameplay = 0,
            paused = 1,
            developer = 2,
        }

        public TextureManager textureManager;
        public RectangleManager rectangleManager;
        //public GraphicsManager graphicsManager;
        public CollisionManager collisionManager;
        public MemoryPool memoryPool;
        GamePlayState[] states = new GamePlayState[3];
        State _state;

        public GameManager(GraphicsDevice graphics, int textureManagerSize, int rectangleManagerSize)
        {
            textureManager = new(textureManagerSize, graphics);
            rectangleManager = new(rectangleManagerSize);
            collisionManager = new();
            memoryPool = new();

            states[0] = new GameState();
            states[1] = new PauseState();
            states[2] = new DeveloperState();
            _state = State.gameplay;
        }

        public static void Destroy()
        {
        }

        public void Update(GameTime gameTime)
        {
            states[(int)_state].Update(gameTime);
        }

        public void Draw()
        {
            states[((int)_state)].Draw();    
        }

        public void SetCurrentState(int state)
        {
            _state = (State)state;  
        }

        public void AttachGraphicsBatch(int state, ref GraphicsBatch batch)
        {
            states[state].AddGraphicsBatch(ref batch); 
        }

        public ref TextureManager GetTextureManager()
        {
            return ref textureManager;
        }
        public ref RectangleManager GetRectangleManager()
        {
            return ref rectangleManager;
        }
        public ref MemoryPool GetMemoryPool()
        {
            return ref memoryPool;
        }
        public ref CollisionManager GetCollisionManager()
        {
            return ref collisionManager;
        }

        public void AddObject(State state, ref GameObject refG)
        {
            states[(int)state].AddGameObject(ref refG);
        }
    }
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class ManagerList
    {
        public GameManager      gameManager;
        
        //GamePlayState[] states = new GamePlayState[3];

        public ManagerList(GraphicsDevice graphics, int textureManagerSize, int rectangleManagerSize)
        {
            //textureManager = new(textureManagerSize, graphics);
            //rectangleManager = new(rectangleManagerSize);
            //gameManager = new();
            //collisionManager = new CollisionManager();
            //memoryPool = new MemoryPool();
        }
        public void UpdateGameObject(GameTime gameTime)
        {
            gameManager.Update(gameTime);
        }
        public void ResolveCollisions(GameTime gameTime)
        {
            //collisionManager.ResolveCollisions(gameTime);
        }

        public void DrawGraphicsComponents(SpriteBatch spriteBatch)
        {
            //gameManager.Draw(spriteBatch);
        }

        internal void UpdateAI(GameTime gameTime)
        {
            
        }

        internal void UpdateGameObjects(GameTime gameTime)
        {
            gameManager.Update(gameTime);
        }

        internal void UpdateAudio(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
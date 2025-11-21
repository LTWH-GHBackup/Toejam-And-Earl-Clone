using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class GamePlayState
    {
        // If it's updatable for the game it becomes a game object
        // If its a drawable object for the game it goes into a graphics Batch
        
        protected List<GameObject> _objects;            
        protected List<GraphicsBatch> _GraphicsBatches; 

        String name;

        public GamePlayState(string name)
        {
            _objects = new();
            _GraphicsBatches = new();
            this.name = name;
        }

        public void Update(GameTime gametime)
        {
            foreach (var item in this._objects)
            {
                item.Update(gametime);
            }
        }

        public void Draw()
        {
            foreach(var batch in this._GraphicsBatches)
            {
                batch.Draw();
            }
        }

        public void AddGameObject(ref GameObject gameObject)
        {
            _objects.Add(gameObject);
        }

        public void AddGraphicsBatch(ref GraphicsBatch batch)
        {
            _GraphicsBatches.Add(batch);
        }
    }
}

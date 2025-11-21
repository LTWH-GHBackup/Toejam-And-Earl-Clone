using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch.Core
{
    public class GameObjectGraph : GameObject
    {
        List<GameObjectGraphNode> nodes;

        public GameObjectGraph(ref ComponentArrayMap map) : base(map)
        {
        }
    }
}

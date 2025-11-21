namespace ToeJamAndEarlFirstBatch
{
    public class Level : GameObject
    {
        protected TileMap tileMap;

        public Level()
            : base(new ComponentArrayMap((int)Component.TypeID.SIZE, [Component.TypeID.AI,
              Component.TypeID.Audio,
              Component.TypeID.Collision,
              Component.TypeID.Gameplay,
              Component.TypeID.Graphics,
              Component.TypeID.Physics]))
        {

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Demo
    {
        public enum Name : int
        {
            Spinning = 0,
            PerimeterRun = 1,
            ShowingSprite = 2,
            SpriteSheet = 3,
            AnimatingSprite = 4,
            TileMap = 5,
            LargeTileMap = 6,
            ButtonInput = 7,
            ControllerInput = 8,
            Chord = 9,
            Sequence = 10,
            Vector = 11,
            VectorAddition = 12,
            VectorSubtraction = 13,
            Magnitude = 14,
            UnitVector = 15,
            ScalarMultiplication = 16,
            DotProduct = 17,
            CrossProduct = 18,
            RightAngleWithDot = 19,
            Reflection = 20,
            Lerp = 21,
            MatrixMultiplication = 22,
            IdentityMatrix = 23,
            TransposeMatrix = 24,
            RowMatrixVsColMatrixTest = 25,
            FastInverseSquareRoot = 26,
            SoundEffect = 27,
            SoundWithFalloff = 28,
            SoundWithPriority = 29,
            DSP = 30,
            DopplerEffect = 31,
            SoundOcclusion = 32,
            SoundObstruction = 33,
            Fresnel = 34,
            SoundChain = 35,
            FindingExplosionPosition = 36,
            Collision = 37,
            Physics = 38,
            CollisionBoxSwitch = 39,
            BehaviorTree = 40,
            Goap = 41,
            Swarm = 42,
            DeveloperMode = 43,
            Menu = 44,
            Inventory = 45,
            StateBased = 46,
            LocalMultiplayer = 47,
            OnlineMultiplayer = 48,
            SingleAxisScrolling = 49,
            FourWayScrolling = 50,
            FrustrumCulling = 51,
            DrawingAPicture = 52,
            SandBox = 53,
            ParallaxScrolling = 54,
            ToeJamAndEarl = 55,
            SIZE = 56,
        }

        Name _name;
        public GameManager _GameMan;

        public Demo(GraphicsDevice graphics, int textureManagerSize, int rectangleManagerSize, Name name) 
        {
            _GameMan = new GameManager(graphics, textureManagerSize, rectangleManagerSize);
            _name = name;
        }

        public int getName()
        {
            return (int)_name;
        }

        public void Update(GameTime gameTime)
        {
            _GameMan.Update(gameTime);
        }

        public void Draw()
        {
            _GameMan.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class DemoManager
    {
        Demo[] demoArray;
        GraphicsDevice _device;

        public DemoManager(GraphicsDevice device, int preferredBackBufferHeight, int preferredBackBufferWidth) 
        {
            _device = device;
            demoArray = new Demo[(int)Demo.Name.SIZE];

            // Manipulating a Game Object
            // Week 1&2  
            demoArray[(int)Demo.Name.SpriteSheet]       = new SpriteSheetDemo(_device);
            demoArray[(int)Demo.Name.ShowingSprite]     = new ShowingSpriteDemo(_device);
            demoArray[(int)Demo.Name.AnimatingSprite]   = new AnimatingDemo(_device);
            demoArray[(int)Demo.Name.TileMap]           = new TileMapDemo(_device);
            demoArray[(int)Demo.Name.LargeTileMap]      = new LargeTileMapDemo(_device);
            demoArray[(int)Demo.Name.DrawingAPicture]   = new DrawingAPictureDemo(_device);
            demoArray[(int)Demo.Name.PerimeterRun]      = new PerimeterRunDemo(_device);
            demoArray[(int)Demo.Name.Spinning]          = new SpinningDemo(_device);

            // Week 3 Demo
            // Input
            demoArray[(int)Demo.Name.ButtonInput]       = new ButtonInputDemo(_device);
            demoArray[(int)Demo.Name.ControllerInput]   = new ControllerInputDemo(_device);
            demoArray[(int)Demo.Name.Chord]             = new ChordDemo(_device);
            demoArray[(int)Demo.Name.Sequence]          = new SequenceDemo(_device);

            // Week 5&6 demo
            // Game Math 
            demoArray[(int)Demo.Name.Vector]                    = new VectorDemo(_device);
            demoArray[(int)Demo.Name.VectorAddition]            = new VectorAdditionDemo(_device);
            demoArray[(int)Demo.Name.VectorSubtraction]         = new VectorSubtractionDemo(_device);
            demoArray[(int)Demo.Name.Magnitude]                 = new MagnitudeDemo(_device);
            demoArray[(int)Demo.Name.UnitVector]                = new UnitVectorDemo(_device);
            demoArray[(int)Demo.Name.ScalarMultiplication]      = new ScalarMultiplicationDemo(_device);
            demoArray[(int)Demo.Name.DotProduct]                = new DotDemo(_device);
            demoArray[(int)Demo.Name.CrossProduct]              = new CrossProductDemo(_device);
            demoArray[(int)Demo.Name.RightAngleWithDot]         = new RightAngleWithDotDemo(_device);
            demoArray[(int)Demo.Name.Reflection]                = new ReflectionDemo(_device);
            demoArray[(int)Demo.Name.Lerp]                      = new LerpDemo(_device);
            demoArray[(int)Demo.Name.MatrixMultiplication]      = new MatrixMultiplicationDemo(_device);
            demoArray[(int)Demo.Name.IdentityMatrix]            = new IdentityMatrixDemo(_device);
            demoArray[(int)Demo.Name.TransposeMatrix]           = new TransposeMatrixDemo(_device);
            demoArray[(int)Demo.Name.RowMatrixVsColMatrixTest]  = new RowMatrixVsColMatrixTestDemo(_device);
            demoArray[(int)Demo.Name.FastInverseSquareRoot]     = new FastInverseSquareRootDemo(_device);

            // Week 7 demo
            // Sound 
            demoArray[(int)Demo.Name.SoundEffect]               = new SoundEffectDemo(_device);
            demoArray[(int)Demo.Name.SoundWithFalloff]          = new SoundWithFalloffDemo(_device);
            demoArray[(int)Demo.Name.SoundWithPriority]         = new SoundWithPriorityDemo(_device);
            demoArray[(int)Demo.Name.DSP]                       = new DSPDemo(_device);
            demoArray[(int)Demo.Name.DopplerEffect]             = new DopplerEffectDemo(_device);
            demoArray[(int)Demo.Name.SoundOcclusion]            = new SoundOcclusionDemo(_device);
            demoArray[(int)Demo.Name.SoundObstruction]          = new SoundObstructionDemo(_device);
            demoArray[(int)Demo.Name.Fresnel]                   = new FresnelDemo(_device);
            demoArray[(int)Demo.Name.SoundChain]                = new SoundChainDemo(_device);
            demoArray[(int)Demo.Name.FindingExplosionPosition]  = new FindingExplosionPositionDemo(_device);

            // Week 8&9 demo
            // Collision / Physics
            demoArray[(int)Demo.Name.Collision]             = new CollisionDemo(_device);
            demoArray[(int)Demo.Name.Physics]               = new PhysicsDemo(_device);
            demoArray[(int)Demo.Name.CollisionBoxSwitch]    = new CollisionBoxSwitch(_device);
            //demoArray[(int)Demo.Name.CollisionCircle]     = new CollisionCircleDemo(_device);
            //demoArray[(int)Demo.Name.CollisionAABB]       = new AABBDemo(_device);
            //demoArray[(int)Demo.Name.CollisionCapsule]    = new CollisionCapsuleDemo(_device);
            //demoArray[(int)Demo.Name.QuadTree]            = new QuadTreeDemo(_device);
            //demoArray[(int)Demo.Name.BSP]                 = new BSPDemo(_device);
            //demoArray[(int)Demo.Name.AVBD]                = new AVBDDemo(_device);
            //demoArray[(int)Demo.Name.VerletIntegration]   = new VerletIntegrationDemo(_device);

            // Week 9&10 demo
            // AI
            demoArray[(int)Demo.Name.StateBased]    = new StateBasedDemo(_device);
            demoArray[(int)Demo.Name.BehaviorTree]  = new BehaviorTreeDemo(_device);
            demoArray[(int)Demo.Name.Goap]          = new GOAPDemo(_device);
            demoArray[(int)Demo.Name.Swarm]         = new SwarmDemo(_device);

            // Week 12
            // UI
            demoArray[(int)Demo.Name.DeveloperMode] = new DeveloperMode(_device);
            demoArray[(int)Demo.Name.Menu]          = new MenuDemo(_device);

            // Week 13
            // Camera
            demoArray[(int)Demo.Name.SingleAxisScrolling]   = new SingleAxisScrollingDemo(_device);
            demoArray[(int)Demo.Name.FourWayScrolling]      = new FourWayScrollingDemo(_device, preferredBackBufferHeight, preferredBackBufferWidth);
            demoArray[(int)Demo.Name.ParallaxScrolling]     = new ParallaxScrollingDemo(_device);
            demoArray[(int)Demo.Name.FrustrumCulling]       = new FrustrumCullingDemo(_device);

            // Week 14
            // Networking
            demoArray[(int)Demo.Name.LocalMultiplayer]  = new LocalMulltiplayerDemo(_device);
            demoArray[(int)Demo.Name.OnlineMultiplayer] = new OnlineMultiplayerDemo(_device);

            // Week 15 All
            demoArray[(int)Demo.Name.SandBox] = new SandBoxDemo(_device);

            // ToeJam And Earl 
            demoArray[(int)Demo.Name.Inventory] = new InventoryDemo(_device, preferredBackBufferHeight, preferredBackBufferWidth);
            demoArray[(int)Demo.Name.ToeJamAndEarl] = new ToeJamAndEarlDemo(_device);

            activeDemo = null;
        }

        public void AddDemo(ref Demo demo)
        {
            demos.Add(demo);
        }
        
        public Demo GetActiveDemo()
        {
            return activeDemo;
        }
        
        public void SetActiveDemo(int i)
        {
            activeDemo = demoArray[i];
        }

        Demo activeDemo;
        List<Demo> demos;
        private GraphicsDevice graphicsDevice;
        private int preferredBackBufferHeight;
        private int preferredBackBufferWidth;
    }
}

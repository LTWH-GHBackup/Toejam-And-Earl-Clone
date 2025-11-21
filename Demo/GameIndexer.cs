using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class GameIndexer
    {
        Dictionary<GameObjectType, List<int>> rectangleMap;
        Dictionary<TextureObjectType, int> textureMap;
        Dictionary<CollisionInstanceType, Tuple<int,int>> collisionMap;

        public GameIndexer(Demo.Name name)
        {
            rectangleMap = new Dictionary<GameObjectType, List<int>>();
            textureMap = new Dictionary<TextureObjectType, int>(); 
            collisionMap = new Dictionary<CollisionInstanceType, Tuple<int,int>>(); 

            switch(name)
            {
                case Demo.Name.Spinning:
                    textureMap.Add(TextureObjectType.LittleGuy, 0);
                    List<int> list = new List<int>();  
                    for(int i = 0; i < 32; i++) list.Add(i);
                    rectangleMap.Add(GameObjectType.LittleGuy, list);
                    collisionMap.Add(CollisionInstanceType.LittleGuy, new Tuple<int,int>(0, 0));
                    break;
                case Demo.Name.PerimeterRun:
                    textureMap.Add(TextureObjectType.LittleGuy, 0);
                    list = new List<int>();
                    for (int i = 0; i < 32; i++) list.Add(i);
                    rectangleMap.Add(GameObjectType.LittleGuy, list);
                    collisionMap.Add(CollisionInstanceType.LittleGuy, new Tuple<int, int>(0, 0));
                    collisionMap.Add(CollisionInstanceType.Null, new Tuple<int, int>(0, 0));
                    break;
                case Demo.Name.ShowingSprite:
                    break;
                case Demo.Name.SpriteSheet:
                    break;
                case Demo.Name.AnimatingSprite:
                    break;
                case Demo.Name.TileMap:
                    break;
                case Demo.Name.LargeTileMap:
                    break;
                case Demo.Name.ButtonInput:
                    break;
                case Demo.Name.ControllerInput:
                    break;
                case Demo.Name.Chord:
                    break;
                case Demo.Name.Sequence:
                    break;
                case Demo.Name.Vector:
                    textureMap.Add(TextureObjectType.Arrow, 0);
                    rectangleMap.Add(GameObjectType.Arrow, [0]);
                    collisionMap.Add(CollisionInstanceType.Arrow, new Tuple<int, int>(0,0));
                    collisionMap.Add(CollisionInstanceType.Null, new Tuple<int, int>(0, 0));

                    break;
                case Demo.Name.VectorAddition:
                    break;
                case Demo.Name.VectorSubtraction:
                    break;
                case Demo.Name.Magnitude:
                    break;
                case Demo.Name.UnitVector:
                    break;
                case Demo.Name.ScalarMultiplication:
                    break;
                case Demo.Name.DotProduct:
                    break;
                case Demo.Name.CrossProduct:
                    break;
                case Demo.Name.RightAngleWithDot:
                    break;
                case Demo.Name.Reflection:
                    break;
                case Demo.Name.Lerp:
                    break;
                case Demo.Name.MatrixMultiplication:
                    break;
                case Demo.Name.IdentityMatrix:
                    break;
                case Demo.Name.TransposeMatrix:
                    break;
                case Demo.Name.RowMatrixVsColMatrixTest:
                    break;
                case Demo.Name.FastInverseSquareRoot:
                    break;
                case Demo.Name.SoundEffect:
                    break;
                case Demo.Name.SoundWithFalloff:
                    break;
                case Demo.Name.SoundWithPriority:
                    break;
                case Demo.Name.DSP:
                    break;
                case Demo.Name.DopplerEffect:
                    break;
                case Demo.Name.SoundOcclusion:
                    break;
                case Demo.Name.SoundObstruction:
                    break;
                case Demo.Name.Fresnel:
                    break;
                case Demo.Name.SoundChain:
                    break;
                case Demo.Name.FindingExplosionPosition:
                    break;
                case Demo.Name.Collision:
                    break;
                case Demo.Name.Physics:
                    break;
                case Demo.Name.CollisionBoxSwitch:
                    break;
                case Demo.Name.BehaviorTree:
                    break;
                case Demo.Name.Goap:
                    break;
                case Demo.Name.Swarm:
                    break;
                case Demo.Name.DeveloperMode:
                    break;
                case Demo.Name.Menu:
                    break;
                case Demo.Name.Inventory:
                    textureMap.Add(TextureObjectType.Inventory, 0);
                    textureMap.Add(TextureObjectType.Null, 0);
                    textureMap.Add(TextureObjectType.HUD, 0);
                    rectangleMap.Add(GameObjectType.Inventory, [0]);
                    collisionMap.Add(CollisionInstanceType.Null, new Tuple<int, int>(0, 0));
                    break;
                case Demo.Name.StateBased:
                    textureMap.Add(TextureObjectType.LittleGuy, 0);
                    list = new List<int>();
                    for (int i = 0; i < 32; i++) list.Add(i);
                    rectangleMap.Add(GameObjectType.LittleGuy, list);
                    collisionMap.Add(CollisionInstanceType.LittleGuy, new Tuple<int, int>(0, 0));
                    collisionMap.Add(CollisionInstanceType.Null, new Tuple<int, int>(0, 0));
                    break;
                case Demo.Name.LocalMultiplayer:
                    break;
                case Demo.Name.OnlineMultiplayer:
                    break;
                case Demo.Name.SingleAxisScrolling:
                    break;
                case Demo.Name.FourWayScrolling:
                    textureMap.Add(TextureObjectType.LittleGuy, 0);
                    list = new List<int>();
                    for (int i = 0; i < 32; i++) list.Add(i);
                    rectangleMap.Add(GameObjectType.LittleGuy, list);
                    collisionMap.Add(CollisionInstanceType.LittleGuy, new Tuple<int, int>(0, 0));
                    textureMap.Add(TextureObjectType.Pixel, 1);
                    rectangleMap.Add(GameObjectType.Pixel, [32]);
                    break;
                case Demo.Name.FrustrumCulling:
                    break;
                case Demo.Name.SIZE:
                    break;
            }
        }

        public void AddObjectAtIndexTexture(TextureObjectType objectType, int textureIndex)
        {
            textureMap.Add(objectType,  textureIndex);
        }

        public void AddObjectAtIndicesRectangle(GameObjectType objectType, List<int> rectangles)
        {
            rectangleMap.Add(objectType, rectangles);
        }


        internal int GetRectangleIndex(GameObjectType objectType)
        {
            return rectangleMap[objectType][0];
        }

        internal List<int> getRectangleInputPattern(GameObjectType objectType)
        {
            return rectangleMap[objectType];
        }

        public int GetTextureIndex(TextureObjectType objectType)
        {
            return textureMap[objectType];
        }

        internal Tuple<int,int> GetCollisionIndex(CollisionInstanceType objectType)
        {
            return collisionMap[objectType];
        }
    }
}
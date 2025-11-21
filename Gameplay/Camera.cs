using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch.Gameplay
{
    public class Camera : GameObject
    {
        private Func<Vector2> _posFunc;
        public float _zoom = 1f;
        public float _rotation = 0.0f;
        int _screenWidth;
        int _screenHeight;

        public Camera(ref GameIndexer indexer, 
            ref TextureManager textureManager, 
            ref RectangleManager rectangleManager, 
            Func<Vector2> posFunc,
            int preferredBackBufferWidth,
            int preferredBackBufferHeight)
            : base(new ComponentArrayMap((int)Component.TypeID.SIZE, [Component.TypeID.AI,
                             Component.TypeID.Audio,
                             Component.TypeID.Collision,
                             Component.TypeID.Gameplay,
                             Component.TypeID.Graphics,
                             Component.TypeID.Physics]))
        {
            this._posFunc = posFunc;

            Component comp = null;

            comp = new CameraGameplayComponent(ref posFunc);
            _map.AddComponent(Component.TypeID.Gameplay, ref comp);

            comp = new NullAI();
            _map.AddComponent(Component.TypeID.AI, ref comp);

            comp = new NullGraphicsComponent(ref posFunc, 1.0f);
            _map.AddComponent(Component.TypeID.Graphics, ref comp);

            // AHHHH
            _screenWidth = preferredBackBufferWidth;
            _screenHeight = preferredBackBufferHeight;
        }

        public Matrix GetViewMatrix()
        {
            return Matrix.CreateTranslation(new Vector3(-_posFunc.Invoke(), 0)) *
                Matrix.CreateRotationZ(_rotation) *
                Matrix.CreateScale(_zoom) *
                Matrix.CreateTranslation(new Vector3(
                    _screenWidth * 0.5f,
                    _screenHeight * 0.5f,
                    0));
        }


    }
}

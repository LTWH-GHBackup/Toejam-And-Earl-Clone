using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    using InventorySpace = InventoryItemGameplay[];
    
    internal class InventoryGameplay : GameplayComponent
    {
        bool display;
        InventoryItemGameplay[] _items;
        public InventoryGameplay(Vector2 position, ref InventoryItem[] items)
            : base(position)
        {
            this._position = position;
            this._items = new InventoryItemGameplay[items.Length];
        }

        public void SwapDisplay()
        {
            display = !display;
            _position.Y = 2000;
            if(display)
            {
                _position.Y = 400;
            }

            Vector2 startpos = this._position + new Vector2(0, 50);
            Vector2 currPos = startpos;
            for(uint i = 0; i < 20; ++i)
            {
                currPos.X = i % 2 == 0 ? 50 : 300;

                float multiplier = i / 2;
                currPos.Y = (multiplier * 50) + startpos.Y;

                _items[i].SetPosition(currPos);
            }
        }

        public InventoryItem[] GetInventorySpace()
        {
            throw new NotImplementedException();
        }
        public void SetInventorySpace(ref InventoryItem[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                this._items[i] = ((InventoryItemGameplay)items[i].GetComponent((int)Component.TypeID.Gameplay));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
     //public class DemoGameObjectFactory
    //{//
     //   public static ref GameObject CreateGameObject(ref DemoOrder order, ref ManagerList list)
     //   {
     //       ref GameObject res = ref list.GetMemoryPool().GetNextAvailableEmptyGameObject();
     //       ComponentArrayMap map = null;
     //       switch(order.objectType)
     //       {
     //           case GameObjectType.LittleGuy:
     //               res = new Little_Guy(ref map, indexer, ref list.GetTextureManager(),
     //               ref list.GetRectangleManager());
     //               break;
     //           case GameObjectType.Arrow:
     //               res = new Arrow(ref map, ref list.GetTextureManager(),
     //               ref list.GetRectangleManager());
     //               break;
     //       }
     //
     //       GameManager manager = list.GetGameManager();
     //       manager.AddObject(ref res);
     //
     //       manager = list.GetGameManager();
     //       manager.AddObject(ref res);
     //       return ref res; 
     //   }
    //}
}

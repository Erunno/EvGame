using GameCore.Interfaces;
using GameCore.Interfaces.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.InternalInterfaces
{
    internal interface IInternalMap
    {
        IEnumerable<IMapObject> GetAllObjects();
        IEnumerable<MapObjectType> GetAllObjects<MapObjectType>();

        IList<IMapObject> ExtractWhere(Predicate<IMapObject> predicate);
        void DeleteWhere(Predicate<IMapObject> predicate);

        void DeleteObject(IMapObject obj);
    }
}

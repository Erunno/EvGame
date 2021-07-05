using GameCore.Interfaces.MapObjects;
using GameCore.PrimitiveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Interfaces
{
    public interface IMap
    {
        IList<IMapObject> GetNeighborhood(MapPoint center, double radius);
        IList<IMapObject> GetNeighborhood(IMapObject center, double radius);

        IList<MapObjectType> GetNeighborhood<MapObjectType>(MapPoint center, double radius) 
            where MapObjectType : IMapObject;
        IList<MapObjectType> GetNeighborhood<MapObjectType>(IMapObject center, double radius) 
            where MapObjectType : IMapObject;

        IList<IMapObject> GetRectangle(Rectangle rectangle);

        void Emplace(IMapObject obj, MapPoint point);

        double GetDistance(IMapObject obj1, IMapObject obj2);
    }
}

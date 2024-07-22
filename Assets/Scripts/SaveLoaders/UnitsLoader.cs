using GameEngine;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Code
{
    public sealed class UnitsLoader : SaveLoader<UnitManager, List<Unit>>
    {
        public UnitsLoader(UnitManager service, IGameRepository gameRepository) : base(service, gameRepository)
        {
        }

        protected override List<Unit> ConvertToData(UnitManager service)
        {
            return service.GetAllUnits().ToList();
        }

        protected override void SetupData(UnitManager service, List<Unit> data)
        {
            service.SetupUnits(data);
        }
    }
}

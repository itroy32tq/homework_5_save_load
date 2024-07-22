using GameEngine;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Code
{
    public sealed class ResourcesSaveLoader : SaveLoader<ResourceService, List<Resource>>
    {
        public ResourcesSaveLoader(ResourceService service, IGameRepository gameRepository) : base(service, gameRepository)
        {
        }

        protected override List<Resource> ConvertToData(ResourceService service)
        {
            return service.GetResources().ToList();
        }

        protected override void SetupData(ResourceService service, List<Resource> data)
        {
            service.SetResources(data);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using NzbDrone.Core.Profiles;
using Prowlarr.Http.REST;

namespace Prowlarr.Api.V1.Profiles.App
{
    public class AppProfileResource : RestResource
    {
        public string Name { get; set; }
    }

    public static class ProfileResourceMapper
    {
        public static AppProfileResource ToResource(this AppSyncProfile model)
        {
            if (model == null)
            {
                return null;
            }

            return new AppProfileResource
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static AppSyncProfile ToModel(this AppProfileResource resource)
        {
            if (resource == null)
            {
                return null;
            }

            return new AppSyncProfile
            {
                Id = resource.Id,
                Name = resource.Name
            };
        }

        public static List<AppProfileResource> ToResource(this IEnumerable<AppSyncProfile> models)
        {
            return models.Select(ToResource).ToList();
        }
    }
}

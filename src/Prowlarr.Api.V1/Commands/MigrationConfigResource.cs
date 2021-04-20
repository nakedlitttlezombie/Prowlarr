using NzbDrone.Core.Configuration;
using Prowlarr.Http.REST;

namespace Prowlarr.Api.V1.Config
{
    public class MigrationConfigResource : RestResource
    {
        public string JackettApi { get; set; }
        public string JackettPath { get; set; }
    }

    public static class MigrationConfigResourceMapper
    {
        public static MigrationConfigResource ToResource(IConfigService model)
        {
            return new MigrationConfigResource
            {
                JackettApi = model.JackettApi,
                JackettPath = model.JackettPath
            };
        }
    }
}

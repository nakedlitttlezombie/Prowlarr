using System.Collections.Generic;
using System.Net.Http;
using NzbDrone.Core.Configuration;

namespace NzbDrone.Core.Migration
{
    public interface IJackettMigrationService
    {
        List<JackettIndexerDefinition> GetJackettIndexers();
        void MigrateJackettIndexers(List<JackettIndexerDefinition> jackettIndexerDefinitions);
    }

    public class JackettMigrationService : IJackettMigrationService
    {
        protected readonly IConfigService _configService;
        public JackettMigrationService(IConfigService configService)
        {
            _configService = configService;
        }

        public List<JackettIndexerDefinition> GetJackettIndexers()
        {
            var jackettApi = _configService.JackettApi;
            var jackettPath = _configService.JackettPath;

            const string url = "/api/v2.0/indexers?configured=true&apiKey=";

            try
            {
                
            }
            catch (Exception)
            {
                
            }
        }

        public void MigrateJackettIndexers(List<JackettIndexerDefinition> jackettIndexerDefinitions)
        {
            
        }
    }
}

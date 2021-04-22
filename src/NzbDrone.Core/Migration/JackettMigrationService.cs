using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using NLog;

namespace NzbDrone.Core.Migration
{
    public interface IJackettMigrationService
    {
        global::System.Threading.Tasks.Task<object> GetJackettIndexers(string jackettPath, string jackettApi);
        void MigrateJackettIndexers(List<JackettIndexerDefinition> jackettIndexerDefinitions);
    }

    public class JackettMigrationService : IJackettMigrationService
    {
        private readonly Logger _logger;
        public JackettMigrationService(Logger logger)
        {
            _logger = logger;
        }

        public async global::System.Threading.Tasks.Task<object> GetJackettIndexers(string jackettPath, string jackettApi)
        {
            string url = jackettPath + "/api/v2.0/indexers?configured=true&apiKey=" + jackettApi;

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(jackettPath + url + jackettApi))
                using (HttpContent content = response.Content)
                {
                    string indexerRequest = await content.ReadAsStringAsync();

                    return new
                    {
                        ConfiguredIndexers = JArray.Parse(indexerRequest)
                    };
                }
            }
            catch (Exception)
            {
                return new ArrayList();
            }
        }

        public void MigrateJackettIndexers(List<JackettIndexerDefinition> jackettIndexerDefinitions)
        {
            //errors
        }
    }
}

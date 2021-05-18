using FluentMigrator;
using NzbDrone.Core.Datastore.Migration.Framework;

namespace NzbDrone.Core.Datastore.Migration
{
    [Migration(6)]
    public class app_profiles : NzbDroneMigrationBase
    {
        protected override void MainDbUpgrade()
        {
            Create.TableForModel("AppSyncProfiles")
                .WithColumn("Name").AsString().Unique();
        }
    }
}

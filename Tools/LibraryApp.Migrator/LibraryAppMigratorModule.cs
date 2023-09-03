using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using LibraryApp.EntityFramework;

namespace LibraryApp.Migrator
{
    [DependsOn(typeof(LibraryAppDataModule))]
    public class LibraryAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<LibraryAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
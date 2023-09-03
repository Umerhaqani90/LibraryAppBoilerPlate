using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BoilerPlateTest.EntityFramework;

namespace BoilerPlateTest.Migrator
{
    [DependsOn(typeof(BoilerPlateTestDataModule))]
    public class BoilerPlateTestMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BoilerPlateTestDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
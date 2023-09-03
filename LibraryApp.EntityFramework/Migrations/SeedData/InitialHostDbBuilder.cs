using LibraryApp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace LibraryApp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly LibraryAppDbContext _context;

        public InitialHostDbBuilder(LibraryAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

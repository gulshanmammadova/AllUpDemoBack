using Microsoft.EntityFrameworkCore;
using P133Allup.DataAccessLayer;
using P133Allup.Interfaces;
using P133Allup.Models;

namespace P133Allup.Services
{
    public class LayoutService: IlayoutService
    {
        private readonly AppDbContext _appDbContext;
        public LayoutService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Setting>> GetSettings() {
            IEnumerable<Setting> settings = await _appDbContext.Settings.ToListAsync();
            return settings;
        }

    }
}

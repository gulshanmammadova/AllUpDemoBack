using P133Allup.Models;

namespace P133Allup.Interfaces
{
    public interface IlayoutService
    {
        Task<IEnumerable<Setting>> GetSettings();
    }
}

using WebAPI.Model;

namespace WebAPI.Services
{
    public partial interface IHomeServices
    {
        List<Emp> GetUsersList(int userId);
    }
}

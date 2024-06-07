using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Services
{
    public partial class HomeServices : IHomeServices
    {
        public readonly ApplicationDbContext dbContext;

        public HomeServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Emp> GetUsersList(int userId)
        {
            var Id = userId > 0 ? new SqlParameter("@Id", userId): new SqlParameter("@Id",DBNull.Value);
            var result = dbContext.emp.FromSqlRaw("EXEC EMP @Id", Id).AsEnumerable().ToList();

            return result;
        }

    }
}

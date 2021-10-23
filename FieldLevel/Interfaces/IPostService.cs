using FieldLevel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FieldLevel.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostModel>> GetAllPosts();
    }
}
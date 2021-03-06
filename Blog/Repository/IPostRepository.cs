using Blog.Models;
using Blog.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public interface IPostRepository
    {
        Task<List<Category>> GetCategories();

        Task<List<PostViewModel>> GetPosts();

        Task<PostViewModel> GetPost(int? postId);

        Task<int> AddPost(PostViewModel post);

        Task<int> DeletePost(int? postId);

        Task UpdatePost(PostViewModel post);
    }
}

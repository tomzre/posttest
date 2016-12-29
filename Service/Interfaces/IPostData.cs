using System.Collections.Generic;
using EFCore.Entities;

namespace TestAPI.Service.Interfaces{
    public interface IPostData{
        IEnumerable<Comment> GetAll();
        Comment Get(int id);
    }
}
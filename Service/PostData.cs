using EFCore.Entities;
using TestAPI.Service.Interfaces;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace TestAPI.Service
{
    public class PostData : IPostData
    {
        private EFCoreDbContext _context;
        public PostData(EFCoreDbContext context)
        {
            _context = context;
        }

        public Comment Get(int id)
        {
            return _context.Comments.Include(c => c.Post).ThenInclude(c => c.Category).SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Comment> GetAll(){
    return _context.Comments.Include(p => p.Post).ThenInclude(c => c.Category).ToList();
}


    }
}
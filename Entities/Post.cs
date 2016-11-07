using System;

namespace EFCore.Entities{
    public class Post{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public string Author { get; set; }
        //public int CommentId { get; set; }
        //public Comment Comment { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }

   
    
}
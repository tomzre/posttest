namespace EFCore.Entities{
 public class Comment{
        public int Id { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
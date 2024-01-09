namespace vk.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int comments_count { get; set; }
        public int comments_like { get; set; }
        public int comments_repost { get; set; }
        public User User { get; set; }
        public Comment Comments { get; set; }
    }
}

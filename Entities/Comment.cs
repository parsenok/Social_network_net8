namespace vk.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string text { get; set; }
        public int coms_like { get; set; }
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}

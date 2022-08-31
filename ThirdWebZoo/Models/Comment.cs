namespace ThirdWebZoo.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int AnimalId { get; set; }
        public string? Comments { get; set; }
        public Animal Animal_Coments { get; set; }
    }
}

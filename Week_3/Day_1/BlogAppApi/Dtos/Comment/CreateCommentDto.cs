namespace BlogAppApi.Dtos.Comment
{
    public class CreateCommentDto
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int PostId { get; set; }
    }
}
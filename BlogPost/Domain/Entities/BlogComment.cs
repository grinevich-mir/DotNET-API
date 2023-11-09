using Domain.Premitives;

namespace Domain.Entities
{
    public sealed class BlogComment : Entity
    {
        public BlogComment(Guid id, Guid postId, string content) {
            PostId = postId;
            Content = content;
        }

        public Guid PostId { get; private set;}

        public string Content { get; private set;}
    }
}

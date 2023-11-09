using MediatR;

namespace Application.BlogPost.Commands.CreateBlogComment;
public sealed record CreateBlogCommentCommand(Guid PostId, string Content) : IRequest<Guid>;

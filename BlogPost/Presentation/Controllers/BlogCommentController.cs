using Application.BlogPost.Commands.CreateBlogComment;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class BlogCommentController : ApiController
    {
        private readonly IMediator _mediator;

        public BlogCommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]



        public async Task<Guid> CreateBlogComment([Microsoft.AspNetCore.Mvc.FromBody] CreateBlogCommentCommand command, CancellationToken cancellationToken)
        {
            var CommentId = await _mediator.Send(command);
            return CommentId;

        }
    }
}

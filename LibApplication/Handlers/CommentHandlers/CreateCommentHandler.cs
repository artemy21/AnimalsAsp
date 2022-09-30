using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Commands;

namespace LibApplication.Handlers.CommentHandlers
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand, Comment>
    {
        private readonly ICommentRepository commentRepository;

        public CreateCommentHandler(ICommentRepository commentRepository) => this.commentRepository = commentRepository;

        public async Task<Comment> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new Comment
            {
                Content = request.Content,
                AnimalId = request.AnimalId
            };
            return await commentRepository.AddAsync(comment);
        }
    }
}

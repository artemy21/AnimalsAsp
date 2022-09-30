using MediatR;
using LibCore.Models;
using LibCore.Repositories;
using LibApplication.Queries.GetAll;

namespace LibApplication.Handlers.CommentHandlers
{
    public class GetAllCommentsHandler : IRequestHandler<GetAllCommentsQuery, List<Comment>?>
    {
        private readonly ICommentRepository commentRepository;

        public GetAllCommentsHandler(ICommentRepository commentRepository) => this.commentRepository = commentRepository;

        public async Task<List<Comment>?> Handle(GetAllCommentsQuery request, CancellationToken cancellationToken)
        {
            return await commentRepository.GetAllCommentsByIdAsync(request.AnimalId);
        }
    }
}

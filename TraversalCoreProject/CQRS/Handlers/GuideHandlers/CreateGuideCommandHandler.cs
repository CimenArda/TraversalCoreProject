using DocumentFormat.OpenXml.Presentation;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using TraversalCoreProject.CQRS.Commands.GuideCommands;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;
        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guids.Add(new Guid
            {
                Name = request.Name,
                Description = request.Description,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}

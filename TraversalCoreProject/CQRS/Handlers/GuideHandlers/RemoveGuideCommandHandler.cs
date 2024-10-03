using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProject.CQRS.Commands.GuideCommands;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class RemoveGuideCommandHandler : IRequestHandler<RemoveGuideCommand>
    {

        private readonly Context _context;
        public RemoveGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(RemoveGuideCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Guids.FindAsync(request.Id);

            _context.Guids.Remove(values);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}

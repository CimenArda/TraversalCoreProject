using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProject.CQRS.Commands.GuideCommands;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class UpdateGuideCommandHandler : IRequestHandler<UpdateGuideCommand>
    {
        private readonly Context _context;
        public UpdateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateGuideCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Guids.FindAsync(request.GuideID);

            values.Name = request.Name;
            values.ImageUrl = request.Image;
            values.Description = request.Description;
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}

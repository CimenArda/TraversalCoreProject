using MediatR;
using System.Threading.Tasks;
using System.Threading;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;
using DataAccessLayer.Concrete;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;
        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guids.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideID = values.GuidID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}

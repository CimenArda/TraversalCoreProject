using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;
using DataAccessLayer.Concrete;
using MediatR;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler :IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;
        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guids.Select(x => new GetAllGuideQueryResult
            {
                GuideID = x.GuidID,
                Description = x.Description,
                Image = x.ImageUrl,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}

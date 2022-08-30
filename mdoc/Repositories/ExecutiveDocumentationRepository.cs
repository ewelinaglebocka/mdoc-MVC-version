using mdoc.Models.Dokumentacja_wykonawcza;
using Microsoft.EntityFrameworkCore;

namespace mdoc.Repositories
{
    public class ExecutiveDocumentationRepository : IExecutiveDocumentationRepository
    {
        private readonly mdocContext _context;
        public ExecutiveDocumentationRepository(mdocContext context)
        {
            _context = context;
        }
        public List<Produkty> GetAll()
        {
            var produkty = _context.produkty.ToList();
            return produkty;
        }
    }
}

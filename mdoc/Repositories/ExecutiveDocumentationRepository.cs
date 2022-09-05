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
            var produkty = _context.produkty.Where(p=>p.aktywny=="tak").OrderBy(x=>x.produkt).ToList();
            return produkty;
        }

        public Dokumenty GetDocuments(string doc)
        {
            return _context.dokumenty.Include(d => d.grupa_dokumentu).FirstOrDefault(x => x.grupa_dokumentu == doc);
        }
    }
}

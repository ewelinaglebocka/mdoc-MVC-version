using mdoc.Models.Dokumentacja_wykonawcza;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace mdoc.Repositories
{
    public class ExecutiveDocumentationRepository : IExecutiveDocumentationRepository
    {
        private readonly mdocContext _context;
        public ExecutiveDocumentationRepository(mdocContext context)
        {
            _context = context;
        }
        public List<Dokumenty> GetAllDocument()
        {
            var documents = _context.dokumenty
                .Where(p=>p.aktywny=="tak" && p.status_dokumentu == "wydany" && p.grupa_dokumentu != "null" && p.grupa_dokumentu != "")
                .ToList();

            return documents;
        }

        public List<Produkty>GetAllProduct()
        {
            var products = _context.produkty.OrderBy(x=>x.produkt).ToList();
            return products;
        }

    }
}

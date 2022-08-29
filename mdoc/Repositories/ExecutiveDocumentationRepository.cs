using mdoc.DataBase.Models.Dokumentacja_wykonawcza;

namespace mdoc.Repositories
{
    public class ExecutiveDocumentationRepository : IExecutiveDocumentationRepository
    {
        private readonly mdocContext _context;
        public ExecutiveDocumentationRepository(mdocContext context)
        {
            _context = context;
        }
        public List<dokumenty> GetAll()
        {
            var documents = _context.documents;

            return documents.ToList();
        }
    }
}

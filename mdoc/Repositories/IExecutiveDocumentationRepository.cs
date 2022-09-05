using mdoc.Models.Dokumentacja_wykonawcza;

namespace mdoc.Repositories
{
    public interface IExecutiveDocumentationRepository
    {
        public List<Produkty> GetAll();
        public Dokumenty GetDocuments(string doc);
    }
}

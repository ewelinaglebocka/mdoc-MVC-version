using mdoc.Models.Dokumentacja_wykonawcza;

namespace mdoc.Services
{
    public interface IExecutiveDocumentationService
    {
        public List<Produkty> GetAll();
        public Dokumenty GetDocuments(string doc);
    }
}

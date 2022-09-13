using mdoc.Models.Dokumentacja_wykonawcza;

namespace mdoc.Repositories
{
    public interface IExecutiveDocumentationRepository
    {
        public List<Dokumenty> GetAllDocument();
        public List<Produkty> GetAllProduct();
    }
}

using mdoc.Models.Dokumentacja_wykonawcza;

namespace mdoc.Services
{
    public interface IExecutiveDocumentationService
    {
        public List<Dokumenty> GetAllDocument();
        public List<Produkty> GetAllProduct();
    }
}

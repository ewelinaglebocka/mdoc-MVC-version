using mdoc.Models.Dokumentacja_wykonawcza;
using mdoc.Repositories;

namespace mdoc.Services
{
    public class ExecutiveDocumentationService : IExecutiveDocumentationService
    {
        private readonly IExecutiveDocumentationRepository _executiveDocumentationRepository;

        public ExecutiveDocumentationService(IExecutiveDocumentationRepository executiveDocumentationRepository)
        {
            _executiveDocumentationRepository = executiveDocumentationRepository;
        }
        public List<Dokumenty> GetAllDocument()
        {
            return _executiveDocumentationRepository.GetAllDocument();
        }
        public List<Produkty> GetAllProduct()
        {
            return _executiveDocumentationRepository.GetAllProduct();
        }

    }
}

using mdoc.DataBase.Models.Dokumentacja_wykonawcza;

namespace mdoc.Repositories
{
    public interface IExecutiveDocumentationRepository
    {
        public List<dokumenty> GetAll();
    }
}

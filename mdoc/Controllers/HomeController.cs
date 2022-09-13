using GroupDocs.Viewer;
using GroupDocs.Viewer.Options;
using mdoc.Models;
using mdoc.Models.Dokumentacja_wykonawcza;
using mdoc.Services;
using mdoc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;


namespace mdoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExecutiveDocumentationService _executiveDocumentationService;
        public HomeController(IExecutiveDocumentationService executiveDocumentationService)
        {
            _executiveDocumentationService = executiveDocumentationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Instruction()
        {
            string fileName = ("W:/mdoc/mDoc_istrukcja.pdf");
            var fileStream = new FileStream(fileName,
                FileMode.Open,
                FileAccess.Read
                );
            var fsResult = new FileStreamResult(fileStream, "application/pdf");
            return fsResult;

        }
        public IActionResult ExecutiveDocumentation(Produkty p, Dokumenty d)
        {
            var document = _executiveDocumentationService.GetAllDocument();
            var product = _executiveDocumentationService.GetAllProduct();

            if (true)
            {
                product = _executiveDocumentationService.GetAllProduct().OrderBy(p => p.produkt).ToList();
            }
            
            List<Dokumenty> result = new List<Dokumenty>(); 

            foreach (var prod in product)
            {
                string val = prod.produkt.ToString();

                foreach (var dok in document)
                {
                    string val2 = dok.grupa_dokumentu.ToString();
                    if (val == val2)
                    {
                        result.Add(dok);
                    }
                }

            }
            document = result;

            var ptViewModel = new ProductTypeViewModel
            {
                Produkty = product,
                Dokumenty = document
            };

            return View(ptViewModel);
        }

        public IActionResult EditDocument()
        {
            return View();
        }
        public IActionResult EditUsers()
        {
            return View();
        }
        public IActionResult Tests()
        {
            return View();
        }
        public IActionResult TechnologicalChanges()
        {
            return View();
        }
        public IActionResult Valuations()
        {
            return View();
        }
        public IActionResult IssuanceOfDocumentation()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.BLL.Services;
using MultiGrain.DAL.UnitOfWork;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Net;

namespace MultiGrain.Api.Controllers
{
    [Route("api/filedocuments")]
    [ApiController]
    public class FileDocumentsController : ControllerBase
    {
        private readonly ILogger<FileDocumentsController> _logger;
        private readonly IFileDocumentService _fileDocumentService;
        public FileDocumentsController(  ILogger<FileDocumentsController> logger, 
            IFileDocumentService fileDocumentService)
        {
            _fileDocumentService = fileDocumentService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetDocuments()
        {
            _logger.LogInformation("called GetCatalogs");
            var personsDto = _fileDocumentService.GetDocuments();
            return Ok(personsDto);
        }
       
        [HttpGet("{id}")]
        public ActionResult DownloadDocument(int id)
        {
           
            for (int i = 0; i < _fileDocumentService.GetDocuments().Count; i++)
            {
                if (id == _fileDocumentService.GetDocuments()[i].Id)
                {
                    string fileName = _fileDocumentService.GetDocuments()[i].FileName;

                    byte[] fileBytes = _fileDocumentService.GetDocuments()[i].Data;

                    return File(fileBytes, "APPLICATION/octet-stream", fileName);
                }

            }
            return null;
        }

        /*{
            "name": "Diploma requiremnts documets",
            "nameAr": "كتاب عن معلومات الجامعة",
            "nameEn": "Diploma requiremnts documets",
            "nameFr": "Documents préparées",
            "action": null,
            "uploadedOn": null,
            "uploadedBy": null,
            "data": null,
            "institutionId": null
         } */
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file, [FromForm] string fileInfoText, CancellationToken ct)
        {
            _logger.LogInformation("Upload File");
            byte[] fileBytesArray = null;

            using (var fileMemoryStream = new MemoryStream())
            {
                await file.CopyToAsync(fileMemoryStream, ct);
                fileBytesArray = fileMemoryStream.ToArray();
            }

            await _fileDocumentService.UploadFileAsync(
                JsonConvert.DeserializeObject<UploadFileDocumentDto>(fileInfoText),
                fileBytesArray,
                file.FileName,
                file.ContentType,
                User?.Identity?.Name,
                ct);

            return Ok(/*new { count = 1, file.Length }*/);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteDocument(int id, CancellationToken ct)
        {
            var action = await _fileDocumentService.DeleteDocumentAsync(id, ct);
            return Ok(action);
        }
        ///
    }
}


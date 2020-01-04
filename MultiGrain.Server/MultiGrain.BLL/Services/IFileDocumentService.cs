using MultiGrain.BLL.Dtos;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface IFileDocumentService : IServiceBase
    {
        Task<bool> UploadFileAsync(UploadFileDocumentDto fileDocumetInfo, 
            byte[] fileDocumentData, 
            string fileName,
            string contentType,
            string userName, 
            CancellationToken ct);

        List<FileDocument> GetDocuments();
        Task<bool> DeleteDocumentAsync(int id, CancellationToken ct);
    }
}

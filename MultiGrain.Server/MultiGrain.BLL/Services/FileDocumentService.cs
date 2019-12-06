using AutoMapper;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.DAL.Entities;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using MultiGrain.BLL.Helpers;

namespace MultiGrain.BLL.Services
{
    public class FileDocumentService : ServiceBase, IFileDocumentService
    {
        public FileDocumentService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<FileDocumentService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<bool> UploadFileAsync(UploadFileDocumentDto fileDocumetInfo, 
            byte[] fileDocumentData,
            string fileName,
            string contentType,
            string userName, 
            CancellationToken ct)
        {
            FileDocument fileDocumentEntity = _mapper.Mapper.Map<FileDocument>(fileDocumetInfo);
            fileDocumentEntity.FileName = fileName;
            fileDocumentEntity.ContentType = contentType;
            fileDocumentEntity.Data = fileDocumentData;
            fileDocumentEntity.UploadedBy = userName;
            fileDocumentEntity.UploadedOn = DateTime.UtcNow;
            
            _uow.FileDocuments.Add(fileDocumentEntity);

            return await _uow.SaveChangesAsync(ct) > 0;


        }
        public List<FileDocument> GetDocuments()
        {
            return _uow.FileDocuments.GetAll().ToList();
        }


    }
}

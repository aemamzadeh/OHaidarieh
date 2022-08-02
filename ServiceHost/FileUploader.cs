using _0_Framework.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ServiceHost
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IImageCompression _imageCompression;


        public FileUploader(IWebHostEnvironment webHostEnvironment, IImageCompression imageCompression)
        {
            _webHostEnvironment = webHostEnvironment;
            _imageCompression = imageCompression;
        }

        public (string filePath, string savePath) Upload(IFormFile file, string path)
        {
            if (file == null) return (null,null);

            var directoryPath = $"{ _webHostEnvironment.WebRootPath}//{path}";
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            var fileName = $"{DateTime.Now.ToFileName()}-{file.FileName}";
            var filePath = $"{directoryPath}//{fileName}";
            var savePath = $"{path}/{fileName}";
            using var output = File.Create(filePath);
            file.CopyTo(output);

            //return filePath;
            //return $"{path}/{fileName}";

            return (filePath,savePath);
        }
    }
}

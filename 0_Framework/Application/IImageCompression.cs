using Microsoft.AspNetCore.Http;
using System.IO;

namespace _0_Framework.Application
{
    public interface IImageCompression
    {
        void ImageOptimize(IFormFile sourcePath, string targetPath);
    }
}

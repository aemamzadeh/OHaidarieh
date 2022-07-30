using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _0_Framework.Application
{
    public interface IFileUploader
    {
        (string filePath, string savePath) Upload(IFormFile file,string path);
    }
}

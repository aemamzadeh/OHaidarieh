using _01_HaidariehQuery.Contracts.CeremonyGuests;
using _01_HaidariehQuery.Contracts.Multimedias;
using Haidarieh.Infrastructure.EFCore;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _01_HaidariehQuery.Query
{
    public class MultimediaQuery : IMultimediaQuery
    {
        private readonly HContext _hContext;

        public MultimediaQuery(HContext hContext)
        {
            _hContext = hContext;
        }

        public List<MultimediaQueryModel> GetMultimediasWithCeremony(long typeId)
        {
            string contentType;
            var medias = _hContext.Multimedias.Where(x => x.Status)
                    .Select(x => new MultimediaQueryModel
                    {
                        Id = x.Id,
                        Title = x.Ceremony.Title,
                        FileAddress = x.FileAddress,
                        VisitCount = x.VisitCount,
                        CeremonyDate=x.Ceremony.CeremonyDate
                       
                        

                    }).ToList();
            foreach (var item in medias)
            {
                new FileExtensionContentTypeProvider().TryGetContentType(item.FileAddress, out contentType);
                var x = contentType;
                item.ContentType = x;
            }
            if (typeId == 1)
            {

                medias = medias.Where(x => x.ContentType != null && x.ContentType.StartsWith("image/")).OrderByDescending(x => x.VisitCount).ToList();
            }
            else if (typeId == 2)
            {

                medias = medias.Where(x => x.ContentType.StartsWith("audio/")).OrderByDescending(x => x.VisitCount).ToList();
            }
            else if (typeId == 3)
            {

                medias = medias.Where(x => x.ContentType.StartsWith("video/")).OrderByDescending(x => x.VisitCount).ToList();
            }
            return medias;

        }
    }
}

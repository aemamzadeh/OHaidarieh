﻿using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haidarieh.Application.Contracts.Multimedia
{
    public interface IMultimediaApplication
    {
        OperationResult Create(CreateMultimedia command, List<IFormFile> files);
        OperationResult EditAlbum(EditMultimedia command, List<IFormFile> files);
        OperationResult EditMetadata(EditMultimedia command);
        List<MultimediaViewModel> Search(MultimediaSearchModel searchModel);
        EditMultimedia GetDetail(long Id);
        List<MultimediaViewModel> GetMultimediasWithCeremony(long id);
        OperationResult Delete(long command);
        long AddVisitCount(long Id);
        EditMultimedia GetDetailMultimedia(long id);

    }
}

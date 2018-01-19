using BaoCaoSuCo.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaoCaoSuCo.Service;

namespace BaoCaoSuCo.Web.Api
{
    public class SuCoController : ApiControllerBase
    {
        ISuCoService _suCoService;
        public SuCoController(IErrorService errorService, ISuCoService suCoService) : base(errorService)
        {
            _suCoService = suCoService;
        }

    }
}
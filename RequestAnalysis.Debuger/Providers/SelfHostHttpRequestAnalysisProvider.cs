﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using System.Web.Http.SelfHost;
using System.Web.Http.WebHost;
using System.Web.Routing;

namespace RequestAnalysis.Debuger
{
    public class SelfHostHttpRequestAnalysisProvider : HttpRequestAnalysisProvider
    {
        protected override string Mode => "SelfHost-Http";
        protected override string LookupPrefix => "../../Controllers";
        public override RequestAnalysisResult GetRequestAnalysis(RequestAnalysisContext analysisContext)
        {
            if (analysisContext.HttpRouteData!=null)
            {
                return base.GetRequestAnalysis(analysisContext);
            }
            return null;
        }
    }
}

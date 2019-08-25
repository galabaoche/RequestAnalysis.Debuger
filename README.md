1. Build the Project.
2. Copy the RequestAnalysis.Debuger.dll to the Host project bin/debug diretory
3. 
    Web Host: In Web.config system.webServer/modules section, add section `<add name="RequestAnalysisModule" type="RequestAnalysis.Debuger.RequestAnalysisModule, RequestAnalysis.Debuger"/>`

    Self Host: httpServer.Configuration.MessageHandlers.Add(new RequestAnalysisDelegatingHandler())

Example
=================================================================================
Time: 2019/8/3 18:28:45
Url: http://XXX.XXX.com/submissions/6?page=1&i=6
Mode: MVC
Controller: SMM.Web.Controllers.XXXController
Action: Details
FilePath: C:\projects\XXX\Source\SMM.Web\Controllers\XXXController.cs
Parameters: id,fid,i,t
SupportedHttpMethods: All
=================================================================================
=================================================================================
Time: 2019/8/3 18:28:53
Url: http://XXX/api/org/submissions/6/labels
Mode: Web API
Controller: SMM.Web.Api.SubmissionsController
Action: GetSubmissionLabels
FilePath: C:\projects\XXX\Source\SMM.Web\Api\XXXController.cs
Parameters: id
SupportedHttpMethods: GET
=================================================================================

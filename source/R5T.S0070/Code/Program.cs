using System;
using System.Threading.Tasks;


namespace R5T.S0070
{
    class Program
    {
        static async Task Main()
        {
            //CodeFileGenerationScripts.Instance.Create_ProgramFile_ForConsole();
            //await CodeFileGenerationScripts.Instance.Create_ProgramFile_ForWebserverForBlazorClient();
            //CodeFileGenerationScripts.Instance.Create_ProjectPlanMarkdownFile();
            //CodeFileGenerationScripts.Instance.Create_AppSettingsJsonFile();
            //CodeFileGenerationScripts.Instance.Create_Development_AppSettingsJsonFile();
            //await CodeFileGenerationScripts.Instance.Create_LaunchSettingsJsonFile_WebServerForBlazorClient();
            //CodeFileGenerationScripts.Instance.Create_InstancesFile();
            //await CodeFileGenerationScripts.Instance.Create_DocumentationFile();
            //await CodeFileGenerationScripts.Instance.Create_PackageJsonFile();
            //await CodeFileGenerationScripts.Instance.Create_TailwindConfigJsFile();
            //await CodeFileGenerationScripts.Instance.Create_TailwindCssFile();
            //await CodeFileGenerationScripts.Instance.Create_IndexHtmlFile();
            //await CodeFileGenerationScripts.Instance.Create_ProgramFile_ForWebBlazorClient();
            //await CodeFileGenerationScripts.Instance.Create_AppRazorFile_WebBlazorClient();
            //await CodeFileGenerationScripts.Instance.Create_ImportsRazorFile_WebBlazorClient_Main();
            //await CodeFileGenerationScripts.Instance.Create_MainLayoutRazorFile_WebBlazorClient();
            //await CodeFileGenerationScripts.Instance.Create_IndexRazorFile_WebBlazorClient();
            //await CodeFileGenerationScripts.Instance.Create_TailwindCssContentPathsJsonFile();
            await CodeFileGenerationScripts.Instance.Create_TailwindCssAllContentPathsJsonFile();
        }
    }
}
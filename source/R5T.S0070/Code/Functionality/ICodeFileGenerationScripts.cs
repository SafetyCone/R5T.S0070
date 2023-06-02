using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0070
{
    /// <summary>
    /// See also: R5T.S0065.ICodeFileGenerationScripts (all code element generation scripts).
    /// </summary>
    [FunctionalityMarker]
    public partial interface ICodeFileGenerationScripts : IFunctionalityMarker
    {
        public async Task Create_TailwindCssAllContentPathsJsonFile()
        {
            /// Inputs.
            var jsonFilePath = Instances.Paths.Sample_JsonFilePath;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_TailwindCssAllContentPathsJsonFile(
                jsonFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                jsonFilePath.Value);
        }

        public async Task Create_TailwindCssContentPathsJsonFile()
        {
            /// Inputs.
            var jsonFilePath = Instances.Paths.Sample_JsonFilePath;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_TailwindCssContentPathsJsonFile(
                jsonFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                jsonFilePath.Value);
        }

        public async Task Create_IndexRazorFile_WebBlazorClient()
        {
            /// Inputs.
            var razorFilePath = Instances.Paths.Sample_RazorFilePath;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_IndexRazorFile_WebBlazorClient(
                razorFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                razorFilePath.Value);
        }

        public async Task Create_MainLayoutRazorFile_WebBlazorClient()
        {
            /// Inputs.
            var razorFilePath = Instances.Paths.Sample_RazorFilePath;
            var projectNamespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_MainLayoutRazorFile_WebBlazorClient(
                razorFilePath,
                projectNamespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                razorFilePath.Value);
        }

        public async Task Create_ImportsRazorFile_WebBlazorClient_Main()
        {
            /// Inputs.
            var razorFilePath = Instances.Paths.Sample_RazorFilePath;
            var projectNamespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_ImportsRazorFile_WebBlazorClient_Main(
                razorFilePath,
                projectNamespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                razorFilePath.Value);
        }

        public async Task Create_AppRazorFile_WebBlazorClient()
        {
            /// Inputs.
            var razorFilePath = Instances.Paths.Sample_RazorFilePath;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_AppRazorFile_WebBlazorClient(
                razorFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                razorFilePath.Value);
        }

        public async Task Create_IndexHtmlFile()
        {
            /// Inputs.
            var htmlFilePath = Instances.Paths.Sample_HtmlFilePath;
            var pageTitle = Instances.Values.Sample_PageTitle;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_IndexHtmlFile(
                htmlFilePath,
                pageTitle);

            Instances.NotepadPlusPlusOperator.Open(
                htmlFilePath.Value);
        }

        public async Task Create_TailwindCssFile()
        {
            /// Inputs.
            var cssFilePath = Instances.Paths.Sample_CssFilePath;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_TailwindCssFile(
                cssFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                cssFilePath.Value);
        }

        public async Task Create_TailwindConfigJsFile()
        {
            /// Inputs.
            var jsFilePath = Instances.Paths.Sample_JsFilePath;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_TailwindConfigJsFile(
                jsFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                jsFilePath.Value);
        }

        public async Task Create_PackageJsonFile()
        {
            /// Inputs.
            var jsonFilePath = Instances.Paths.Sample_JsonFilePath;
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_PackageJsonFile(
                jsonFilePath,
                projectName,
                projectDescription);

            Instances.NotepadPlusPlusOperator.Open(
                jsonFilePath.Value);
        }

        public async Task Create_DocumentationFile()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_DocumentationFile(
                codeFilePath,
                projectDescription,
                namespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath.Value);
        }

        public void Create_InstancesFile()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            Instances.CodeFileGenerationOperations.Create_InstancesFile(
                codeFilePath,
                namespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath.Value);
        }

        public async Task Create_LaunchSettingsJsonFile_WebServerForBlazorClient()
        {
            /// Inputs.
            var jsonFilePath = Instances.Paths.Sample_JsonFilePath;
            var projectName = Instances.Values.Sample_ProjectName;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_LaunchSettingsJsonFile_WebServerForBlazorClient(
                jsonFilePath,
                projectName);

            Instances.NotepadPlusPlusOperator.Open(
                jsonFilePath.Value);
        }

        public void Create_Development_AppSettingsJsonFile()
        {
            /// Inputs.
            var jsonFilePath = Instances.Paths.Sample_JsonFilePath;


            /// Run.
            Instances.CodeFileGenerationOperations.Create_Development_AppSettingsJsonFile(
                jsonFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                jsonFilePath.Value);
        }

        public void Create_AppSettingsJsonFile()
        {
            /// Inputs.
            var jsonFilePath = Instances.Paths.Sample_JsonFilePath;


            /// Run.
            Instances.CodeFileGenerationOperations.Create_AppSettingsJsonFile(
                jsonFilePath);

            Instances.NotepadPlusPlusOperator.Open(
                jsonFilePath.Value);
        }

        public void Create_ProjectPlanMarkdownFile()
        {
            /// Inputs.
            var markdownFilePath = Instances.Paths.Sample_MarkdownFilePath;
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;


            /// Run.
            Instances.CodeFileGenerationOperations.Create_ProjectPlanFile_Markdown(
                markdownFilePath,
                projectName,
                projectDescription);

            Instances.NotepadPlusPlusOperator.Open(
                markdownFilePath.Value);
        }

        public async Task Create_ProgramFile_ForWebBlazorClient()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_ProgramFile_WebBlazorClient(
                codeFilePath,
                namespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath.Value);
        }

        /// <summary>
        /// Creates the program file for the web server application of a Blazor client.
        /// </summary>
        public async Task Create_ProgramFile_ForWebserverForBlazorClient()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_ProgramFile_WebServerForBlazorClient(
                codeFilePath,
                namespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath.Value);
        }

        /// <summary>
        /// Creates the Visual Studio console application template default program file.
        /// (Uses best practices for string interpolation-based code file generation.)
        /// </summary>
        public void Create_ProgramFile_ForConsole()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            Instances.CodeFileGenerationOperations.Create_ProgramFile_ForConsole(
                codeFilePath,
                namespaceName);

            Instances.NotepadPlusPlusOperator.Open(
                codeFilePath.Value);
        }
    }
}

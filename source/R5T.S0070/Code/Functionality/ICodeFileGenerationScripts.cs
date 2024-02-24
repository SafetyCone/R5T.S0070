using System;
using System.Threading.Tasks;

using R5T.L0073.F001;
using R5T.L0093.T000;
using R5T.L0096.T000;
using R5T.T0132;
using R5T.T0161.Extensions;
using R5T.T0221;


namespace R5T.S0070
{
    /// <summary>
    /// See also: R5T.S0065.ICodeFileGenerationScripts (all code element generation scripts).
    /// </summary>
    [FunctionalityMarker]
    public partial interface ICodeFileGenerationScripts : IFunctionalityMarker
    {
        public async Task Create_ProgramFile_ForConsole_ViaRazorComponents()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                Instances.CodeFileGenerationContextOperations._UsingRazorComponents.Create_ProgramFile_ForConsole<L0097.O001.CodeFileContext>(
                    out _
                )
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_ProgramFile_ForConsole_ViaRoslyn()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                context =>
                {
                    return Instances.CodeFileContextOperator.In_CodeFileContext(
                        context.FilePath,
                        out _,
                        Instances.CodeFileContextOperationSetOperator.Generate_ProgramFile<L0073.T003.CodeFileContext>(
                            context.NamespaceName)
                    );
                }
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_ProgramFile_ForConsole_ViaTextTemplating()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                Instances.CodeFileGenerationContextOperations._UsingTextTemplating.Create_ProgramFile_ForConsole<L0097.O001.CodeFileContext>(
                    out _
                )
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        /// <summary>
        /// Creates the Visual Studio console application template default program file.
        /// (Uses best practices for string interpolation-based code file generation.)
        /// </summary>
        public void Create_ProgramFile_ForConsole_ViaTextTemplating_Old()
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
            var namespaceName = "Sample".ToNamespaceName();


            /// Run.
            await Instances.CodeFileGenerationOperations.Create_IndexRazorFile_WebBlazorClient(
                razorFilePath,
                namespaceName);

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

        public async Task Create_DocumentationFile_ViaRoslyn()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out (IsSet<IHasFilePath> FilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) codeFilePropertiesSet,
                Instances.CodeFileContextOperationSetOperator.Generate_DocumentationFile<L0097.O001.CodeFileContext>(
                    codeFilePropertiesSet,
                    out _,
                    projectDescription.Value)
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_DocumentationFile_ViaTextTemplating()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                Instances.CodeFileGenerationContextOperations._UsingTextTemplating.Create_DocumentationFile<L0097.O001.CodeFileContext>(
                    projectDescription.Value,
                    out _)
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_DocumentationFile_ViaRazorComponents()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var projectDescription = Instances.Values.Sample_ProjectDescription;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                Instances.CodeFileGenerationContextOperations._UsingRazorComponents.Create_DocumentationFile<L0097.O001.CodeFileContext>(
                    projectDescription.Value,
                    out _)
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_DocumentationFile_ViaRazorComponents_Old()
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

        public async Task Create_InstancesFile_ViaRoslyn()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out (IsSet<IHasFilePath> FilePathSet, IsSet<IHasNamespaceName> NamespaceNameSet) codeFilePropertiesSet,
                Instances.CodeFileContextOperationSetOperator.Generate_InstancesFile<L0097.O001.CodeFileContext>(
                    (codeFilePropertiesSet.FilePathSet, codeFilePropertiesSet.NamespaceNameSet),
                    out _
                )
                //Instances.CodeFileContextOperations.In_CompilationFileContext<L0097.O001.CodeFileContext>(
                //    out _,
                //    Instances.CompilationUnitContextOperations.Set_CompilationUnit_ToNewEmpty,
                //    Instances.CompilationUnitContextOperations.Add_UsingNamespace<L0073.T003.CompilationFileContext>(
                //        Instances.NamespaceNames.System,
                //        out _
                //    ),
                //    Instances.CompilationUnitContextOperations.In_NamespaceDeclarationContext<L0073.T003.CompilationFileContext>(
                //        out _,
                //        Instances.NamespaceDeclarationContextOperations.Set_NamespaceDeclaration_ToNewEmpty<L0073.T003.N001.NamespaceDeclarationContext>(
                //            out _
                //        ),
                //        Instances.NamespaceDeclarationContextOperations.In_ClassDeclarationContext<L0073.T003.N001.NamespaceDeclarationContext>(
                //            out _,
                //            Instances.ClassDeclarationContextOperations.Set_ClassDeclaration_New<L0073.T003.ClassDeclarationContext>(
                //                Instances.ClassNames._Strings.Instances,
                //                out var classDeclarationSet
                //            ),
                //            Instances.ClassDeclarationContextOperations.Modify_Modifiers<L0073.T003.ClassDeclarationContext>(
                //                classDeclarationSet,
                //                _ =>
                //                {
                //                    var modifiersDescriptor = new ModifiersDescriptor
                //                    {
                //                        Accessibility = MemberAccessibilityLevel.Public,
                //                        Is_Static = true,
                //                    };

                //                    var output = Instances.ModifiersOperator.Get_ModifiersTokenList(modifiersDescriptor);
                //                    return output;
                //                }
                //            ),
                //            Instances.ClassDeclarationContextOperations.Add_ClassDeclaration_ToNamespaceDeclaration
                //        ),
                //        Instances.NamespaceDeclarationContextOperations.Add_NamespaceDeclaration_ToCompilationUnit
                //    ),
                //    Instances.CompilationUnitContextOperations.Write_CompilationUnit_ToFilePath<L0073.T003.CompilationFileContext>(
                //        out _
                //    )
                //)
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_InstancesFile_ViaRazorComponents()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                Instances.CodeFileGenerationContextOperations._UsingRazorComponents.Create_InstancesFile<L0097.O001.CodeFileContext>(
                    out _)
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public async Task Create_InstancesFile_ViaTextTemplating()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var namespaceName = Instances.Values.Sample_NamespaceName;


            /// Run.
            await Instances.CodeFileContextOperator.In_CodeFileContext(
                codeFilePath.Value,
                namespaceName.Value,
                out _,
                Instances.CodeFileGenerationContextOperations._UsingTextTemplating.Create_InstancesFile<L0097.O001.CodeFileContext>(
                    out _)
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
        }

        public void Create_InstancesFile_ViaTextTemplating_Old()
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

        public void Create_ProjectPlanMarkdownFile_ViaTextTemplating_Old()
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

        public async Task Create_ProjectPlanMarkdownFile_ViaTextTemplating()
        {
            /// Inputs.
            var codeFilePath = Instances.Paths.Sample_CSharpFilePath;
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDescription = Instances.Values.Sample_ProjectDescription;


            /// Run.
            

            await Instances.ContextOperator.In_Context(
                new Context000
                {
                    FilePath = codeFilePath.Value,
                    ProjectName = projectName.Value,
                    ProjectDescription = projectDescription.Value
                },
                Instances.CodeFileGenerationContextOperations.Create_ProjectPlanFile<Context000>(
                    (
                    Instances.IsSetOperator.IsSet<IHasFilePath>(),
                    Instances.IsSetOperator.IsSet<IHasProjectName>(),
                    Instances.IsSetOperator.IsSet<IHasProjectDescription>()
                    ),
                    out _
                )
            );

            Instances.NotepadPlusPlusOperator.Open(codeFilePath);
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
    }
}

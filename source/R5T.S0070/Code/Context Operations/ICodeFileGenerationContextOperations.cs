using System;

using R5T.T0241;


namespace R5T.S0070
{
    [ContextOperationsMarker]
    public partial interface ICodeFileGenerationContextOperations : IContextOperationsMarker,
        L0097.O002.ICodeFileGenerationContextOperations,
        F0083.O001.ICodeFileGenerationContextOperations
    {
#pragma warning disable IDE1006 // Naming Styles
        public L0097.O002.ICodeFileGenerationContextOperations _UsingTextTemplating => L0097.O002.CodeFileGenerationContextOperations.Instance;
        public F0083.O001.ICodeFileGenerationContextOperations _UsingRazorComponents => F0083.O001.CodeFileGenerationContextOperations.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}

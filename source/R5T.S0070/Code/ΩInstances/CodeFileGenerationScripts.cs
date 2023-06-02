using System;


namespace R5T.S0070
{
    public class CodeFileGenerationScripts : ICodeFileGenerationScripts
    {
        #region Infrastructure

        public static ICodeFileGenerationScripts Instance { get; } = new CodeFileGenerationScripts();


        private CodeFileGenerationScripts()
        {
        }

        #endregion
    }
}

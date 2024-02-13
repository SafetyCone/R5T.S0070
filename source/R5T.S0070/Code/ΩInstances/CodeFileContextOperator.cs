using System;


namespace R5T.S0070
{
    public class CodeFileContextOperator : ICodeFileContextOperator
    {
        #region Infrastructure

        public static ICodeFileContextOperator Instance { get; } = new CodeFileContextOperator();


        private CodeFileContextOperator()
        {
        }

        #endregion
    }
}

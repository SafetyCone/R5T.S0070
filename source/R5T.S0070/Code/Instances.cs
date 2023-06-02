using System;


namespace R5T.S0070
{
    public static class Instances
    {
        public static O0008.ICodeFileGenerationOperations CodeFileGenerationOperations => O0008.CodeFileGenerationOperations.Instance;
        //public static ICodeFileGenerationScripts CodeFileGenerationScripts => S0070.CodeFileGenerationScripts.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IPaths Paths => S0070.Paths.Instance;
        public static IValues Values => S0070.Values.Instance;
    }
}
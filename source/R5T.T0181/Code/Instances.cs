using System;


namespace R5T.T0181
{
    public static class Instances
    {
        public static IFilePathOperator FilePathOperator => T0181.FilePathOperator.Instance;
        public static IStringOperator StringOperator => T0181.StringOperator.Instance;
    }
}
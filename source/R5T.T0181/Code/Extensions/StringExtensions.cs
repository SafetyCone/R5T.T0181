using System;


namespace R5T.T0181.Extensions
{
    public static class StringExtensions
    {
        public static IExecutableDirectoryPath ToExecutableDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToExecutableDirectoryPath(value);
        }

        public static IExecutableFilePath ToExecutableFilePath(this string value)
        {
            return Instances.StringOperator.ToExecutableFilePath(value);
        }

        public static IJsonFilePath ToJsonFilePath(this string value)
        {
            return Instances.StringOperator.ToJsonFilePath(value);
        }

        public static ITextFileName ToTextFileName(this string value)
        {
            return Instances.StringOperator.ToTextFileName(value);
        }

        public static ITextFilePath ToTextFilePath(this string value)
        {
            return Instances.StringOperator.ToTextFilePath(value);
        }

        public static IXmlFileName ToXmlFileName(this string value)
        {
            return Instances.StringOperator.ToXmlFileName(value);
        }

        public static IXmlFilePath ToXmlFilePath(this string value)
        {
            return Instances.StringOperator.ToXmlFilePath(value);
        }
    }
}

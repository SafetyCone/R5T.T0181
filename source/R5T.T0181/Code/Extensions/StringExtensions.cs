using System;


namespace R5T.T0181.Extensions
{
    public static class StringExtensions
    {
        public static ExecutableDirectoryPath ToExecutableDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToExecutableDirectoryPath(value);
        }

        public static ExecutableFilePath ToExecutableFilePath(this string value)
        {
            return Instances.StringOperator.ToExecutableFilePath(value);
        }

        public static JsonFilePath ToJsonFilePath(this string value)
        {
            return Instances.StringOperator.ToJsonFilePath(value);
        }

        public static TextFilePath ToTextFilePath(this string value)
        {
            return Instances.StringOperator.ToTextFilePath(value);
        }

        public static XmlFilePath ToXmlFilePath(this string value)
        {
            return Instances.StringOperator.ToXmlFilePath(value);
        }
    }
}

using System;


namespace R5T.T0181.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCssFilePath(string)"/>
        public static ICssFilePath ToCssFilePath(this string value)
        {
            return Instances.StringOperator.ToCssFilePath(value);
        }

        public static IExecutableDirectoryPath ToExecutableDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToExecutableDirectoryPath(value);
        }

        public static IExecutableFilePath ToExecutableFilePath(this string value)
        {
            return Instances.StringOperator.ToExecutableFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToHtmlFilePath(string)"/>
        public static IHtmlFilePath ToHtmlFilePath(this string value)
        {
            return Instances.StringOperator.ToHtmlFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToJsFilePath(string)"/>
        public static IJsFilePath ToJsFilePath(this string value)
        {
            return Instances.StringOperator.ToJsFilePath(value);
        }

        public static IJsonFilePath ToJsonFilePath(this string value)
        {
            return Instances.StringOperator.ToJsonFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToMarkdownFilePath(string)"/>
        public static IMarkdownFilePath ToMarkdownFilePath(this string value)
        {
            return Instances.StringOperator.ToMarkdownFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRazorFilePath(string)"/>
        public static IRazorFilePath ToRazorFilePath(this string value)
        {
            return Instances.StringOperator.ToRazorFilePath(value);
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

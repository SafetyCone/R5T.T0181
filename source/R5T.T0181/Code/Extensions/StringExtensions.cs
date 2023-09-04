using System;


namespace R5T.T0181.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCssFilePath(string)"/>
        public static ICssFilePath ToCssFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToCssFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToDataFilePath(string)"/>
        public static IDataFilePath ToDataFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDataFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToDllFilePath(string)"/>
        public static IDllFilePath ToDllFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDllFilePath(value);
        }

        public static IExecutableDirectoryPath ToExecutableDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToExecutableDirectoryPath(value);
        }

        public static IExecutableFilePath ToExecutableFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToExecutableFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToHtmlFilePath(string)"/>
        public static IHtmlFilePath ToHtmlFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToHtmlFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToJsFilePath(string)"/>
        public static IJsFilePath ToJsFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToJsFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToJsonFileName(string)"/>
        public static IJsonFileName ToJsonFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToJsonFileName(value);
        }

        public static IJsonFilePath ToJsonFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToJsonFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLogFilePath(string)"/>
        public static ILogFilePath ToLogFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLogFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToMarkdownFilePath(string)"/>
        public static IMarkdownFilePath ToMarkdownFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToMarkdownFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRazorFilePath(string)"/>
        public static IRazorFilePath ToRazorFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToRazorFilePath(value);
        }

        public static ITextFileName ToTextFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToTextFileName(value);
        }

        public static ITextFilePath ToTextFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToTextFilePath(value);
        }

        public static IXmlFileName ToXmlFileName(this string value)
        {
            return Instances.StringOperator_Extensions.ToXmlFileName(value);
        }

        public static IXmlFilePath ToXmlFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToXmlFilePath(value);
        }
    }
}

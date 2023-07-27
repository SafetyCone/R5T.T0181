using System;

using R5T.T0132;


namespace R5T.T0181.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICssFilePath"/>
        public ICssFilePath ToCssFilePath(string value)
        {
            var output = new CssFilePath(value);
            return output;
        }

        public IExecutableDirectoryPath ToExecutableDirectoryPath(string value)
        {
            var output = new ExecutableDirectoryPath(value);
            return output;
        }

        public IExecutableFilePath ToExecutableFilePath(string value)
        {
            var output = new ExecutableFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IHtmlFilePath"/>
        public IHtmlFilePath ToHtmlFilePath(string value)
        {
            var output = new HtmlFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IJsonFileName"/>
        public IJsonFileName ToJsonFileName(string value)
        {
            var output = new JsonFileName(value);
            return output;
        }

        /// <inheritdoc cref="IJsFilePath"/>
        public IJsFilePath ToJsFilePath(string value)
        {
            var output = new JsFilePath(value);
            return output;
        }

        public IJsonFilePath ToJsonFilePath(string value)
        {
            var output = new JsonFilePath(value);
            return output;
        }

        /// <inheritdoc cref="ILogFilePath"/>
        public ILogFilePath ToLogFilePath(string value)
        {
            var output = new LogFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IMarkdownFilePath"/>
        public IMarkdownFilePath ToMarkdownFilePath(string value)
        {
            var output = new MarkdownFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IRazorFilePath"/>
        public IRazorFilePath ToRazorFilePath(string value)
        {
            var output = new RazorFilePath(value);
            return output;
        }

        public ITextFileName ToTextFileName(string value)
        {
            var output = new TextFileName(value);
            return output;
        }

        public ITextFilePath ToTextFilePath(string value)
        {
            var output = new TextFilePath(value);
            return output;
        }

        public IXmlFileName ToXmlFileName(string value)
        {
            var output = new XmlFileName(value);
            return output;
        }

        public IXmlFilePath ToXmlFilePath(string value)
        {
            var output = new XmlFilePath(value);
            return output;
        }
    }
}

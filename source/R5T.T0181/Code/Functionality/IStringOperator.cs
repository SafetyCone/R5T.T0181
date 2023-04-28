using System;

using R5T.T0132;


namespace R5T.T0181
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
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

        public IJsonFilePath ToJsonFilePath(string value)
        {
            var output = new JsonFilePath(value);
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

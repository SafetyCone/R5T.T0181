using System;

using R5T.T0180;


namespace R5T.T0181.Extensions
{
    public static class IFilePathExtensions
    {
        public static XmlFilePath AsXmlFilePath(this IFilePath filePath)
        {
            return Instances.FilePathOperator.AsXmlFilePath(filePath);
        }
    }
}

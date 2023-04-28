using System;

using R5T.T0132;
using R5T.T0180;
using R5T.T0181.Extensions;


namespace R5T.T0181
{
    [FunctionalityMarker]
    public partial interface IFilePathOperator : IFunctionalityMarker
    {
        public IXmlFilePath AsXmlFilePath(IFilePath filePath)
        {
            return filePath.Value.ToXmlFilePath();
        }
    }
}

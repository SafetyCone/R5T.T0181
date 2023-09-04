using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as the path of a file containing markdown.
    /// </summary>
    [StrongTypeMarker]
    public interface IMarkdownFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}
using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as the path of an HTML file.
    /// </summary>
    [StrongTypeMarker]
    public interface IHtmlFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}
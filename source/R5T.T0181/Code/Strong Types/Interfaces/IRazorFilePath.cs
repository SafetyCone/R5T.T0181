using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as the path of an ASP.NET Razor markup file.
    /// </summary>
    [StrongTypeMarker]
    public interface IRazorFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}
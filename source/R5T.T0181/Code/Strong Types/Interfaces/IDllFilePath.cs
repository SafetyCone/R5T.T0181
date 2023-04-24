using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// The strong-type for all file paths.
    /// </summary>
    [StrongTypeMarker]
    public interface IDllFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}

using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as a CSS (cascading style sheets) file path.
    /// </summary>
    [StrongTypeMarker]
    public interface ICssFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}
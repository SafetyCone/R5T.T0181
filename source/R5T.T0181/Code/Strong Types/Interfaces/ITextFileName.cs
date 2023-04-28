using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as a text file name.
    /// </summary>
    [StrongTypeMarker]
    public interface ITextFileName : IStrongTypeMarker,
        IFileName
    {
    }
}

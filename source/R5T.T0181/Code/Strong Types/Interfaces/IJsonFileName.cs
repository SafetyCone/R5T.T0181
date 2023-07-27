using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as a the name of a file containing JSON-formatted data (usally with the ".json" file extension).
    /// </summary>
    [StrongTypeMarker]
    public interface IJsonFileName : IStrongTypeMarker,
        IFileName
    {
    }
}
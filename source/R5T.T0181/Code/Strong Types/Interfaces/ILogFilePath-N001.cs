using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181.N001
{
    /// <summary>
    /// Strongly-types a string as a log file path.
    /// Note: not necessarily a text-based log file path.
    /// </summary>
    [StrongTypeMarker]
    public interface ILogFilePath : IStrongTypeMarker,
        /// Does not inherit from <see cref="ITextFilePath"/> since log files might be structured as JSON or binary data.
        IFilePath
    {
    }
}
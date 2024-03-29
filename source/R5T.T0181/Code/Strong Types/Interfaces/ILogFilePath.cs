using System;

using R5T.T0178;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as a text-based log file path.
    /// Chooses <see cref="ITextBasedLogFilePath"/> as the default for log file paths.
    /// </summary>
    [StrongTypeMarker]
    public interface ILogFilePath : IStrongTypeMarker,
        ITextBasedLogFilePath
    {
    }
}
using System;

using R5T.T0178;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as a text-based log file path.
    /// </summary>
    [StrongTypeMarker]
    public interface ITextBasedLogFilePath : IStrongTypeMarker,
        N001.ILogFilePath,
        ITextFilePath
    {
    }
}
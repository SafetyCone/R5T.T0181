using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="ITextBasedLogFilePath"/>
    [StrongTypeImplementationMarker]
    public class TextBasedLogFilePath : TypedBase<string>, IStrongTypeMarker,
        ITextBasedLogFilePath
    {
        public TextBasedLogFilePath(string value)
            : base(value)
        {
        }
    }
}
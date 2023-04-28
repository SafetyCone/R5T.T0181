using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="ITextFileName"/>
    [StrongTypeImplementationMarker]
    public class TextFileName : TypedBase<string>, IStrongTypeImplementationMarker,
        ITextFileName
    {
        public TextFileName(string value)
            : base(value)
        {
        }
    }
}

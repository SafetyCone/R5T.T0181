using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="ITextFilePath"/>
    [StrongTypeImplementationMarker]
    public class TextFilePath : TypedBase<string>, IStrongTypeImplementationMarker,
        ITextFilePath
    {
        public TextFilePath(string value)
            : base(value)
        {
        }
    }
}

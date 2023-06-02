using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IMarkdownFilePath"/>
    [StrongTypeImplementationMarker]
    public class MarkdownFilePath : TypedBase<string>, IStrongTypeMarker,
        IMarkdownFilePath
    {
        public MarkdownFilePath(string value)
            : base(value)
        {
        }
    }
}
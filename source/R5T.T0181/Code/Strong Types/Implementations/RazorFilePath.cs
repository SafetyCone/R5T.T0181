using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IRazorFilePath"/>
    [StrongTypeImplementationMarker]
    public class RazorFilePath : TypedBase<string>, IStrongTypeMarker,
        IRazorFilePath
    {
        public RazorFilePath(string value)
            : base(value)
        {
        }
    }
}
using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="ICssFilePath"/>
    [StrongTypeImplementationMarker]
    public class CssFilePath : TypedBase<string>, IStrongTypeMarker,
        ICssFilePath
    {
        public CssFilePath(string value)
            : base(value)
        {
        }
    }
}
using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IJsFilePath"/>
    [StrongTypeImplementationMarker]
    public class JsFilePath : TypedBase<string>, IStrongTypeMarker,
        IJsFilePath
    {
        public JsFilePath(string value)
            : base(value)
        {
        }
    }
}
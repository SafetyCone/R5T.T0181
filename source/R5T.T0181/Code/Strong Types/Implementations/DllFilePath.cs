using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IDllFilePath"/>
    [StrongTypeImplementationMarker]
    public class DllFilePath : TypedBase<string>, IStrongTypeImplementationMarker,
        IDllFilePath
    {
        public DllFilePath(string value)
            : base(value)
        {
        }
    }
}

using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IExecutableFilePath"/>
    [StrongTypeImplementationMarker]
    public class ExecutableFilePath : TypedBase<string>, IStrongTypeImplementationMarker,
        IExecutableFilePath
    {
        public ExecutableFilePath(string value)
            : base(value)
        {
        }
    }
}

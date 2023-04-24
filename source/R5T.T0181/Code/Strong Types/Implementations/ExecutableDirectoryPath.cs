using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IExecutableDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class ExecutableDirectoryPath : TypedBase<string>, IStrongTypeImplementationMarker,
        IExecutableDirectoryPath
    {
        public ExecutableDirectoryPath(string value)
            : base(value)
        {
        }
    }
}

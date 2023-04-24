using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IJsonFilePath"/>
    [StrongTypeImplementationMarker]
    public class JsonFilePath : TypedBase<string>, IStrongTypeImplementationMarker,
        IJsonFilePath
    {
        public JsonFilePath(string value)
            : base(value)
        {
        }
    }
}

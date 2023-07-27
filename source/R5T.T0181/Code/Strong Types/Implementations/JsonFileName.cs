using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IJsonFileName"/>
    [StrongTypeImplementationMarker]
    public class JsonFileName : TypedBase<string>, IStrongTypeMarker,
        IJsonFileName
    {
        public JsonFileName(string value)
            : base(value)
        {
        }
    }
}
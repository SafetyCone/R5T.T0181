using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0181
{
    /// <inheritdoc cref="IXmlFileName"/>
    [StrongTypeImplementationMarker]
    public class XmlFileName : TypedBase<string>, IStrongTypeImplementationMarker,
        IXmlFileName
    {
        public XmlFileName(string value)
            : base(value)
        {
        }
    }
}

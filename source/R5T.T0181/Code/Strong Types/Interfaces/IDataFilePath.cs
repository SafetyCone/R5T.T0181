using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// Strongly-types a string as the path of a data file.
    /// Note: no assumption is made about the format of the data in the file; it might be binary, text, JSON, whatever!
    /// The only assumption is that the file contains data.
    /// </summary>
    [StrongTypeMarker]
    public interface IDataFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}
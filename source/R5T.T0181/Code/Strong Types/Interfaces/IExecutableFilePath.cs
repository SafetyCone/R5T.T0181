using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0181
{
    /// <summary>
    /// The strong-type for an executable file path.
    /// Note: no assumption is made about whether the executable is a .NET executable, or any other executable.
    /// Only that the executable file path is a file path.
    /// </summary>
    [StrongTypeMarker]
    public interface IExecutableFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}

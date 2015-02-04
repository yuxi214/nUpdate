﻿using System;

namespace nUpdate.Internal.Exceptions
{
    /// <summary>
    ///     The exception that is thrown if the package deletion fails in case the signature is invalid.
    /// </summary>
    [Serializable]
    public class PackageDeleteException : Exception
    {
        public PackageDeleteException(string message)
            : base(message)
        {
        }
    }
}

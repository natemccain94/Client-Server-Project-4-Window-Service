using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VeryImportantWindowService
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract]
    public interface IWindowService
    {
        /// <summary>
        /// Gets the window one value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetWindowOneVal();

        /// <summary>
        /// Gets the window two value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetWindowTwoVal();
    }
}

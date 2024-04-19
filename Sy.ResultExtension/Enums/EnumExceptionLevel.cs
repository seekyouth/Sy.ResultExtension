using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sy.ResultExtension.Enums
{
    ///<summary>
    /// 异常级别
    ///</summary>
    public enum EnumExceptionLevel
    {
        ///<summary>
        /// 警告
        ///</summary>
        [Description("警告")]
        Warn =1,

        ///<summary>
        /// 错误
        ///</summary>
        [Description("错误")]
        Err = 2,
    }
}

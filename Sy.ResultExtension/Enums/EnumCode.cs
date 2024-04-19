using System;
using System.Collections.Generic;
using System.Text;

namespace Sy.ResultExtension.Enums
{
    ///<summary>
    /// 返回标识码
    ///</summary>
    public enum EnumCode
    {

        ///<summary>
        /// 成功
        ///</summary>
        Succeed = 0,

        ///<summary>
        /// 异常
        ///</summary>
        Err = -1,

        ///<summary>
        /// 未找到
        ///</summary>
        NotFound = -2,

        ///<summary>
        /// 没有权限
        ///</summary>
        NoPower = -3,

        ///<summary>
        /// 没有登录
        ///</summary>
        NoLogin = -4,

        ///<summary>
        /// 参数异常
        ///</summary>
        ParameterErr = -5,
    }
}

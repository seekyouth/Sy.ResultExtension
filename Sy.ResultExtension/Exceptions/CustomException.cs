using Sy.ResultExtension.Enums;
using System;

namespace Sy.ResultExtension.Exceptions
{
    ///<summary>
    /// 自定义异常
    ///</summary>
    public class CustomException : Exception
    {
        private readonly string _message;

        public EnumExceptionLevel Level { get; set; }

        ///<summary>
        /// 
        ///</summary>
        ///<param name="memberName"></param>
        ///<param name="memberType"></param>
        ///<param name="constantType"></param>
        public CustomException(string message, EnumExceptionLevel level = EnumExceptionLevel.Warn)
        {
            _message = message;
            Level = level;
        }

        ///<summary>
        ///  消息
        ///</summary>
        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}

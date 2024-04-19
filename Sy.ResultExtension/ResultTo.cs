using Sy.ResultExtension.Dto;
using Sy.ResultExtension.Enums;
using Sy.ResultExtension.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sy.ResultExtension
{

    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultTo
    {

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto Success(string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultDto().Success(msg, code);
        }

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static async Task<ResultDto> SuccessAsync(string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return await Task.FromResult(new ResultDto().Success(msg, code));
        }


        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data">返回数据</param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto Success(dynamic data, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultDto().Success(data, msg, code);
        }

        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<returns></returns>
        public static ResultDto Failed(string error = null)
        {
            return new ResultDto().Failed(error, (int)EnumCode.Err);
        }

        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultDto Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultDto().Failed(error, code);
        }


        ///<summary>
        /// 自定义异常
        ///</summary>
        ///<param name="error">异常信息</param>
        ///<returns></returns>
        public static void Exception(string error = null)
        {
            throw new CustomException(error);
        }


        ///<summary>
        /// 自定义异常
        ///</summary>
        ///<param name="error">异常信息</param>
        ///<returns></returns>
        public static void Exception(string error = null, EnumExceptionLevel enumExceptionLevel = EnumExceptionLevel.Warn)
        {
            throw new CustomException(error, enumExceptionLevel);
        }

    }



    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultTo<T>
    {
        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data">返回数据</param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto<T> Success(T data, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultDto<T>().Success(data, msg, code);
        }


        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultDto<T> Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultDto<T>().Failed(error, code);
        }


        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultDto<T> Failed(T t, string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultDto<T>().Failed(t,error, code);
        }
    }

    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultTo<T, T2>
    {

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data">返回数据</param>
        ///<param name="data2"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto<T, T2> Success(T data, T2 data2, string msg = "success")
        {
            return new ResultDto<T, T2>().Success(data, data2, msg);
        }


        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultDto<T, T2> Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultDto<T, T2>().Failed(error, code);
        }

    }

    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultToList<T> where T : class
    {

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="list">返回数据</param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultListDto<T> Success(List<T> list, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultListDto<T>().Success(list, msg, code);
        }


        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultListDto<T> Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultListDto<T>().Failed(error, code);
        }

        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultListDto<T> Failed(List<T> list,string error = null,int code = (int)EnumCode.Err)
        {
            return new ResultListDto<T>().Failed(list,error, code);
        }

    }


    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultToList<T, T2>
    {
        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="list">返回数据</param>
        ///<param name="data2"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultListDto<T, T2> Success(List<T> list, T2 data2, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultListDto<T, T2>().Success(list, data2, msg, code);
        }

        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultListDto<T, T2> Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultListDto<T, T2>().Failed(error, code);
        }
    }


    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultToPage<T>
    {
        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="list">返回数据</param>
        ///<param name="total"></param>
        ///<param name="page"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultPageDto<T> Success(List<T> list, int total, int page, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultPageDto<T>().Success(list, page, total, msg, code);
        }


        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultPageDto<T> Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultPageDto<T>().Failed(error, code);
        }
    }


    ///<summary>
    /// 返回结果
    ///</summary>
    public static class ResultToPage<T, T2>
    {

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="list">返回数据</param>
        ///<param name="data2"></param>
        ///<param name="total"></param>
        ///<param name="page"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultPageDto<T, T2> Success(List<T> list, T2 data2, int total, int page, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            return new ResultPageDto<T, T2>().Success(list, data2, page, total, msg, code);
        }


        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="error">错误信息</param>
        ///<param name="code"></param>
        ///<returns></returns>
        public static ResultPageDto<T, T2> Failed(string error = null, int code = (int)EnumCode.Err)
        {
            return new ResultPageDto<T, T2>().Failed(error, code);
        }
    }
}

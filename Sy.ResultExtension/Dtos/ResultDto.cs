using Sy.ResultExtension.Enums;
using System.Collections.Generic;

namespace Sy.ResultExtension.Dto
{

    ///<summary>
    /// 返回模型
    ///</summary>
    public class ResultDto : IResultDto
    {
        ///<summary>
        /// 返回标识码
        ///</summary>
        public int Code { get; set; }

        ///<summary>
        /// 成功
        ///</summary>
        public bool IsSuccessful { get; set; }

        ///<summary>
        /// 消息
        ///</summary>
        public string Msg { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        public dynamic Data { get; set; }


        ///<summary>
        /// 成功
        ///</summary>
        ///<returns></returns>
        public ResultDto Success(string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultDto Success(dynamic data = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Data = data;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 失败
        ///</summary>
        ///<param name="code"></param>
        ///<param name="msg">说明</param>
        public ResultDto Failed(string msg = "failed", int code = default)
        {
            this.Code = code;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }


    }

    ///<summary>
    /// 泛型类 返回模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class ResultDto<T> : ResultDto, IResultDto<T>
    {
        ///<summary>
        /// 常规数据
        ///</summary>
        public new T Data { get; set; }

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultDto<T> Success(T data = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Data = data;
            this.Msg = msg;
            return this;
        }


        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultDto<T> Failed(string msg = "err")
        {
            this.Code = (int)EnumCode.Err;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public new ResultDto<T> Failed(string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultDto<T> Failed(T t, string msg, int enumCode)
        {
            this.Data = t;
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }


    }


    ///<summary>
    /// 泛型类  返回元祖模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class ResultDto<T, T2> : ResultDto, IResultDto<T, T2>
    {
        ///<summary>
        /// 常规数据
        ///</summary>
        public new T Data { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        public T2 Data2 { get; set; }


        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="data2"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultDto<T, T2> Success(T data = default, T2 data2 = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Data = data;
            this.Data2 = data2;
            this.Msg = msg;
            return this;
        }



        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultDto<T, T2> Failed(string msg = "err")
        {
            this.Code = (int)EnumCode.Err;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public new ResultDto<T, T2> Failed(string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

    }



    ///<summary>
    /// 泛型类 返回模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class ResultListDto<T> : ResultDto, IResultListDto<T>
    {

        ///<summary>
        /// 常规数据
        ///</summary>
        public new List<T> Data { get; set; }

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultListDto<T> Success(List<T> data = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Data = data;
            this.Msg = msg;
            return this;
        }


        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultListDto<T> Failed(string msg = "err")
        {
            this.Code = (int)EnumCode.Err;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public new ResultListDto<T> Failed(string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }


        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultListDto<T> Failed(List<T> list, string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            this.Data = list;
            return this;
        }

    }


    ///<summary>
    /// 泛型类 返回模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class ResultListDto<T, T2> : ResultDto, IResultListDto<T, T2>
    {
        ///<summary>
        /// 常规数据
        ///</summary>
        public new List<T> Data { get; set; }


        ///<summary>
        /// 常规数据
        ///</summary>
        public T2 Data2 { get; set; }


        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="data2"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultListDto<T, T2> Success(List<T> data = default, T2 data2 = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Data = data;
            this.Data2 = data2;
            this.Msg = msg;
            return this;
        }



        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultListDto<T, T2> Failed(string msg = "err")
        {
            this.Code = (int)EnumCode.Err;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public new ResultListDto<T, T2> Failed(string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }
    }



    ///<summary>
    /// 泛型类 返回模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class ResultPageDto<T> : ResultDto, IResultPageDto<T>
    {

        ///<summary>
        /// 总条数
        ///</summary>1
        public int Total { get; set; }


        ///<summary>
        /// 当前页
        ///</summary>
        public int Page { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        public new List<T> Data { get; set; }

        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultPageDto<T> Success(List<T> data = default, int page = default, int total = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Page = page;
            this.Total = total;
            this.Data = data;
            this.Msg = msg;
            return this;
        }


        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultPageDto<T> Failed(string msg = "err")
        {
            this.Code = (int)EnumCode.Err;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public new ResultPageDto<T> Failed(string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }


    }


    ///<summary>
    /// 泛型类 返回模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class ResultPageDto<T, T2> : ResultDto, IResultPageDto<T, T2>
    {

        ///<summary>
        /// 总条数
        ///</summary>1
        public int Total { get; set; }


        ///<summary>
        /// 当前页
        ///</summary>
        public int Page { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        public new List<T> Data { get; set; }


        ///<summary>
        /// 常规数据
        ///</summary>
        public T2 Data2 { get; set; }



        ///<summary>
        /// 成功
        ///</summary>
        ///<param name="data"></param>
        ///<param name="data2"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultPageDto<T, T2> Success(List<T> data = default, T2 data2 = default, int page = default, int total = default, string msg = "success", int code = (int)EnumCode.Succeed)
        {
            this.Code = code;
            this.IsSuccessful = true;
            this.Data = data;
            this.Data2 = data2;
            this.Page = page;
            this.Total = total;
            this.Msg = msg;
            return this;
        }



        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public ResultPageDto<T, T2> Failed(string msg = "err")
        {
            this.Code = (int)EnumCode.Err;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }

        ///<summary>
        /// 异常
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public new ResultPageDto<T, T2> Failed(string msg, int enumCode)
        {
            this.Code = enumCode;
            this.IsSuccessful = false;
            this.Msg = msg;
            return this;
        }
    }

}

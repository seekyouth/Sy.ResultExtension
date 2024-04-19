using Sy.ResultExtension.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sy.ResultExtension.Dto
{

    ///<summary>
    /// 结果模型
    ///</summary>
    public interface IResultDto
    {
        ///<summary>
        /// 成功
        ///</summary>
        bool IsSuccessful { get; set; }

        ///<summary>
        /// 返回标识码
        ///</summary>
        int Code { get; set; }

        ///<summary>
        /// 消息
        ///</summary>
        string Msg { get; set; }


        ///<summary>
        /// 常规数据
        ///</summary>
        dynamic Data { get; set; }

    }



    ///<summary>
    /// 泛型结果模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public interface IResultDto<T> : IResultDto  
    {
        ///<summary>
        /// 常规数据
        ///</summary>
        new T Data { get; set; }

    }

    ///<summary>
    /// 泛型结果模型
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public interface IResultDto<T, T2> : IResultDto 
    {
        ///<summary>
        /// 常规数据
        ///</summary>
        new T Data { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        T2 Data2 { get; set; }

    }

    ///<summary>
    /// 泛型结果模型集合
    ///</summary>
    public interface IResultListDto<T> : IResultDto  
    {

        ///<summary>
        /// 常规数据
        ///</summary>
        new List<T> Data { get; set; }

    }

    ///<summary>
    /// 泛型结果模型集合
    ///</summary>
    public interface IResultListDto<T, T2> : IResultDto
    {

        ///<summary>
        /// 常规数据
        ///</summary>
        new List<T> Data { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        T2 Data2 { get; set; }

    }


    ///<summary>
    /// 泛型结果模型集合
    ///</summary>
    public interface IResultPageDto<T> : IResultDto  
    {

        ///<summary>
        /// 总条数
        ///</summary>1
        int Total { get; set; }


        ///<summary>
        /// 当前页
        ///</summary>
        int Page { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        new List<T> Data { get; set; }

    }

    ///<summary>
    /// 泛型结果模型集合
    ///</summary>
    public interface IResultPageDto<T, T2> : IResultDto  
    {

        ///<summary>
        /// 总条数
        ///</summary>1
        int Total { get; set; }


        ///<summary>
        /// 当前页
        ///</summary>
        int Page { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        new List<T> Data { get; set; }

        ///<summary>
        /// 常规数据
        ///</summary>
        T2 Data2 { get; set; }

    }
}

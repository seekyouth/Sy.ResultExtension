using Sy.ResultExtension.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sy.ResultExtension.Extensions
{
    public static class ResultConvert
    {
        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto Convert(this IResultDto input)
        {
            return (ResultDto)input;
        }

        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto<T> Convert<T>(this IResultDto input) where T : class
        {
            if (input.IsSuccessful)
            {
                var result = (ResultDto)input;
                return ResultTo<T>.Success((T)input.Data, input.Msg);
            }
            else
                return ResultTo<T>.Failed(input.Msg, input.Code);
        }


        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultDto<T, T2> Convert<T, T2>(this IResultDto input) where T : class where T2 : class
        {
            if (input.IsSuccessful)
            {
                var result = (ResultDto<T, T2>)input;
                return ResultTo<T, T2>.Success((T)result.Data, (T2)result.Data2, input.Msg);
            }
            else
                return ResultTo<T, T2>.Failed(input.Msg, input.Code);
        }

        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultListDto<T> ConvertList<T>(this IResultDto input) where T : class
        {
            if (input.IsSuccessful)
            {
                var result = (ResultListDto<T>)input;
                return ResultToList<T>.Success(result.Data, result.Msg);
            }
            else
                return ResultToList<T>.Failed(input.Msg, input.Code);
        }

        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultListDto<T, T2> ConvertList<T, T2>(this IResultDto input) where T : class where T2 : class
        {
            if (input.IsSuccessful)
            {
                var result = (ResultListDto<T,T2>)input;
                var  aa=result.Data2;
                return ResultToList<T,T2>.Success(result.Data,result.Data2, input.Msg);
            }
            else
                return ResultToList<T, T2>.Failed(input.Msg, input.Code);
        }


        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultPageDto<T> ConvertPageList<T>(this IResultDto input) where T : class
        {
            if (input.IsSuccessful)
            {
                var result = (ResultPageDto<T>)input;
                    return ResultToPage<T>.Success(result.Data, result.Total, result.Page, result.Msg);

            }
            else
                return ResultToPage<T>.Failed(input.Msg, input.Code);
        }

        ///<summary>
        /// 转换
        ///</summary>
        ///<param name="data"></param>
        ///<param name="msg"></param>
        ///<returns></returns>
        public static ResultPageDto<T, T2> ConvertPageList<T, T2>(this IResultDto input) where T : class where T2 : class
        {
            if (input.IsSuccessful)
            {
                var result = (ResultPageDto<T, T2>)input;
                return ResultToPage<T, T2>.Success((List<T>)result.Data,result.Data2, result.Total, result.Page, result.Msg);
            }
            else
                return ResultToPage<T, T2>.Failed(input.Msg, input.Code);
        }
    }
}

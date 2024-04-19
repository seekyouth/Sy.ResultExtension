1、动态参数接收情况

```
public async Task<ResultDto> GetList(AllWebSiteDto input)
{
  return ResultTo.Success("返回成功");
  //return ResultTo.Failed("返回失败",errCode);
}
```

2、泛型接收

```
public async Task<ResultDto<NewsDto>> GetList(AllWebSiteDto input)
 {
   return ResultTo<NewsDto>.Success(model,"返回成功");
  //return ResultTo<NewsDto>.Failed("返回失败",errCode);
 }
public async Task<ResultDto<NewsDto,WebSiteDto>> GetList(AllWebSiteDto input)
 {
    return ResultTo<NewsDto>.Success(newsDto,webSiteDto，"返回成功");
    //return ResultTo<NewsDto, WebSiteDto>.Failed("返回失败");
 }
```

3、泛型接收列表

```
public async Task<ResultListDto<NewsDto>> GetList(AllWebSiteDto input)
{
    return ResultToList<NewsDto>.Success(list, "返回成功");
    //return ResultToList<NewsDto>.Failed("返回失败",errCode);
}
public async Task<ResultListDto<NewsDto, WebSiteDto>> GetList(AllWebSiteDto input)
{
    return ResultToList<NewsDto>.Success(newsDtos, webSiteDtos，"返回成功");
    //return ResultToList<newsDtos, WebSitwebSiteDtoseDto>.Failed("返回失败");
}
```

4、泛型接口分页列表

```
public async Task<ResultPageDto<NewsDto>> GetList(AllWebSiteDto input)
{
    return ResultToPage<NewsDto>.Success(list,total,page, "返回成功");
    //return ResultToPage<NewsDto>.Failed("返回失败",errCode);
}
public async Task<ResultPageDto<NewsDto, WebSiteDto>> GetList(AllWebSiteDto input)
{
    return ResultToPage<NewsDto>.Success(newsDtos, webSiteDtos, total, page，"返回成功");
    //return ResultToPage<newsDtos, WebSitwebSiteDtoseDto>.Failed("返回失败");
}
```

# Easy Download

**目前正在编写中，请稍等。**

迅雷下载助手，可使用内置搜索功能进行搜索，并智能提取结果中的所有磁力链接。

## 1. 计划支持的磁力链接搜索网站

+ [Btbook - 磁力搜索](http://www.btmeet.org/)
+ [BT磁力链 - 最好用的磁力链接搜索引擎](http://www.bturls.net/)
+ [磁力搜 - CiLiSou.CN](http://www.cilisou.cn/)
+ [BT樱桃 - 磁力链接搜索引擎](http://www.btcherry.info/)
+ [BT岛 - 最好用的磁力链接搜索引擎](http://www.btdao5.com/)
+ [蜘蛛磁力搜索 - 磁力链接搜索引擎](http://www.zhizhucili.net/)
+ [磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载](http://www.cililian.com/)
+ [RunBT - 磁力搜索_BT搜索_磁力链接_种子搜索](http://www.runbt.cc/)
+ [磁力链接 - BT种子磁力链接搜索引擎](http://cililian.me/)

## 2. 磁力链接位置分析

在这些网站中，根据获取磁力链接的位置可以分成两大类：
+ 直接在搜索结果页可以直接提取：
    + Btbook - 磁力搜索
    + BT磁力链 - 最好用的磁力链接搜索引擎
    + 磁力搜 - CiLiSou.CN
    + BT樱桃 - 磁力链接搜索引擎
    + BT岛 - 最好用的磁力链接搜索引擎
    + 蜘蛛磁力搜索 - 磁力链接搜索引擎
    + RunBT - 磁力搜索_BT搜索_磁力链接_种子搜索
    + 磁力链接 - BT种子磁力链接搜索引擎
+ 需要从搜索结果页获得磁力链接所在的具体网页后才能获取：    
    + 磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载

## 3. 磁力链接提取方法

### 3.1 能直接在搜索结果页面提取的
1. Btbook - 磁力搜索 
   
   搜索页面链接特点：
   ```html
   "http://www.btmeet.org/search/" + urlencode(keyword) + ".html"
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.btmeet.org/wiki/" + "d64ca14cb5184823bc142c861b143715e72e1184" + ".html"
   ```

2. BT磁力链 - 最好用的磁力链接搜索引擎

   搜索页面链接特点：
   ```html
   "http://www.bturls.net/search/" + urlencode(keyword) + "_ctime_1.html"
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.bturls.net/" + "1E461BB688DCB05A7F170EF70BFC675D3A59CA76" + ".html"
   ```

3. 磁力搜 - CiLiSou.CN

   搜索页面链接特点：
   ```html
   "http://www.cilisou.cn/s.php?q=2012" + urlencode(keyword) + "&encode_=1"
   ```
   
   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.cilisou.cn/info.php?sphinx_id=11192590&info_hash=" + "8968E1DCE990564E01928E40F6B82AEF3CB3DB2D" + "&q=2~0~1~2~"
   ```

4. BT樱桃 - 磁力链接搜索引擎

   搜索页面链接特点：
   ```html
   "http://www.btcherry.info/search?keyword=" + urlencode(keyword)
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.btcherry.info/info/" + "B946DD4D6EAEB81C8EE083FF6265009FB11DF300"
   ```

5. BT岛 - 最好用的磁力链接搜索引擎

   搜索页面链接特点：
   ```html
   "http://www.btdao5.com/list/" + urlencode(keyword) + "-s1d-1.html"
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.btdao5.com/info/" + "7f48c79aa1a77f40bf85b207b8c34192d9f76be2"
   ```

6. 蜘蛛磁力搜索 - 磁力链接搜索引擎

   搜索页面链接特点：
   ```html
   "http://www.zhizhucili.net/so/" + urlencode(keyword) + "-first-asc-1?f=h"
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.zhizhucili.net/bt/" + "6c7e702f55488dca661fb94cd6ec4e4c407d1db61786973" + ".html"
   ```

7. RunBT - 磁力搜索_BT搜索_磁力链接_种子搜索

   搜索页面链接特点：
   ```html
   "http://www.runbt.cc/list/" + urlencode(keyword) + "/1"
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://www.runbt.cc/detail/" + "46bcef489f7214db0d8d09db37d209a7913dc97d"
   ```

8. 磁力链接 - BT种子磁力链接搜索引擎

   搜索页面链接特点：
   ```html
   "http://cililian.me/list/" + urlencode(keyword) + "/1.html"
   ```

   而在上面的网页中能用正则表达式匹配出以下链接：
   ```html
   "http://cililian.me/xiangxi/" + "29185099ecd60463f4a62fc6f77da88eda3e170a"
   ```

### 3.2 需要从搜索结果页获得磁力链接所在的具体网页后才能获取的

+ 磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载

  搜索结果页 -> 其中的某一项 -> 在这一项的源文件中获取磁力链接
  
  在如下模式的连接地址可以获取到搜索结果：
  ```html
  "http://www.cililian.com/main-search.html?kw=" + urlencode(keyword)
  ```

  而在这个页面中能匹配到如下模式的结果页面地址：
  ```html
  http://www.cililian.com/main-show-id-5421621.html
  ```

  在这些详细信息页面中，能匹配到如下的连接地址：
  ```html
  <textarea class="well magnet center" id="MagnetLink" onclick="$(this).select();" readonly="">
  magnet:?xt=urn:btih:42246ccf187337731ea9fd07976e965dd70d8672&amp;dn=[钢铁侠].Iron.Man.2008.Bluray.1080p.DTS.2audio.x264-CHD.mkv
  </textarea>
  ```
  
  我们使用正则表达式即可将中间的磁力链接取出。

### 3.3 相关函数设计

而就获取搜索结果页面这一步来说，除了 **BT樱桃 - 磁力链接搜索引擎** 和 **磁力链 - 磁力搜索 - 种子搜索 - 迅雷种子下载** 是「前缀 + 关键字」的模式，其余的都是「前缀 + 关键字 + 后缀」的模式。所以在设计本步骤的获取方法的时候，就可以用一个函数重载两次，分别对应「前缀 + 关键字」的模式和「前缀 + 关键字 + 后缀」的模式。
```csharp
//由于这些使用「前缀 + 关键字 + 后缀」模式的网站都能在搜索结果页直接获取磁力链接
//故直接用一个方法获取即可

/// <summary>
/// 获取搜索结果，可以直接绑定到 dg_main 的 ItemsSource 中。
/// 适配模式「前缀 + 关键字 + 后缀」
/// </summary>
/// <param name="prefix">连接前缀</param>
/// <param name="keyword">关键字</param>
/// <param name="suffix">后缀</param>
/// <param name="reg">磁力链接的正则表达式</param>
public static DataTable GetResultTable(string prefix, string keyword, string suffix){
    //处理逻辑
}

/// <summary>
/// 获取搜索结果，可以直接绑定到 dg_main 的 ItemsSource 中。
/// 适配模式「前缀 + 关键字」
/// </summary>
/// <param name="prefix">连接前缀</param>
/// <param name="keyword">关键字</param>
/// <param name="reg">磁力链接的正则表达式</param>
public static DataTable GetResultTable(string prefix, string keyword){
    //处理逻辑
}
```

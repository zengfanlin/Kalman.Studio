using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalman.Data.SchemaObject
{
    /// <summary>
    /// 表自定义的方法
    /// 用于生成自定义的方法和方法的名称
    /// </summary>
    public class SOTableMethod
    {
       public string MethodName { set; get; }
       public string MethodAlias { set; get; }
    }
}

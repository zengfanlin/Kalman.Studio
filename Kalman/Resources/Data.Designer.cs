﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kalman.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Data {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Data() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kalman123.Resources.Data", typeof(Data).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 该Command对象必须是SqlCommand类型 的本地化字符串。
        /// </summary>
        internal static string CommandNotSqlCommand {
            get {
                return ResourceManager.GetString("CommandNotSqlCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不能找到名称为[{0}]的连接字符串 的本地化字符串。
        /// </summary>
        internal static string ConnectionStringNameNotFound {
            get {
                return ResourceManager.GetString("ConnectionStringNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 连接字符串没有配置 的本地化字符串。
        /// </summary>
        internal static string ConnectionStringNotConfig {
            get {
                return ResourceManager.GetString("ConnectionStringNotConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 找不到名称为[{0}]数据提供程序，请检查配置节system.data-&gt;DbProviderFactories 的本地化字符串。
        /// </summary>
        internal static string DataProviderNotFound {
            get {
                return ResourceManager.GetString("DataProviderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 必须初始化至少一个Command 的本地化字符串。
        /// </summary>
        internal static string MustInitAtLeastOneCommand {
            get {
                return ResourceManager.GetString("MustInitAtLeastOneCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数值的个数与当前存储过程的参数个数不匹配 的本地化字符串。
        /// </summary>
        internal static string ParameterMatchFailure {
            get {
                return ResourceManager.GetString("ParameterMatchFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无法更新行 的本地化字符串。
        /// </summary>
        internal static string RowUpdateFailed {
            get {
                return ResourceManager.GetString("RowUpdateFailed", resourceCulture);
            }
        }
    }
}

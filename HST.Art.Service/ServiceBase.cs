/*----------------------------------------------------------------

// 文件名：ServiceBase.cs
// 功能描述： 服务基类
// 创建者：sysmenu
// 创建时间：2015-9-18
//----------------------------------------------------------------*/
using HST.Art.Core;
using HST.Utillity;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace HST.Art.Service
{
    /// <summary>
    /// 服务基类
    /// </summary>
    public class ServiceBase: IDisposable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ServiceBase()
        {
            DisposableObjects = new List<IDisposable>();
            
        }
        
        /// <summary>
        /// 包含可释放的实体集合
        /// </summary>
        public IList<IDisposable> DisposableObjects { get; private set; }

        /// <summary>
        /// 添加实体对象到集合
        /// </summary>
        /// <param name="obj"></param>
        protected void AddDisposableObject(object obj)
        {
            IDisposable disposable = obj as IDisposable;
            if (null != disposable)
            {
                this.DisposableObjects.Add(disposable);
            }
        }

        /// <summary>
        /// 销毁时释放包含的实体
        /// </summary>
        public void Dispose()
        {
            foreach (IDisposable obj in this.DisposableObjects)
            {
                if (null != obj)
                {
                    obj.Dispose();
                }
            }
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public virtual ErrorCode ErrorMsg { get; set; }
    }
}

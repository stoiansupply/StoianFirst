using System;
using System.Data.Entity;

namespace IDAL
{
    /// <summary>
    /// EF数据上下文 工厂
    /// </summary>
    public interface IDBContextFactory
    {
        /// <summary>
        /// 获取 EF 上下文对象
        /// </summary>
        /// <returns></returns>
        DbContext GetDbContext();
    }
}

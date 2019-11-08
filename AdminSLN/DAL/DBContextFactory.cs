using System;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Model;
using IDAL;

namespace DAL
{
    public class DBContextFactory : IDBContextFactory
    {
        #region 创建 EF上下文 对象，在线程中共享 一个 上下文对象 
        /// <summary>
        /// 创建 EF上下文 对象，在线程中共享 一个 上下文对象 
        /// </summary>
        /// <returns></returns>
        public DbContext GetDbContext()
        {
            //从当前线程中 获取 EF上下文对象
            var dbContext = CallContext.GetData(typeof(DBContextFactory).Name) as DbContext;
            if(dbContext == null)
            {
                dbContext = new UltimusDBEntities();
                CallContext.SetData(typeof(DBContextFactory).Name, dbContext);
            }
            return dbContext;
        }
        #endregion
    }
}

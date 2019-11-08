using System;
using System.Runtime.Remoting.Messaging;
using IDAL;

namespace DAL
{
    public class DBSessionFactory : IDBSessionFactory
    {
        /// <summary>
        /// 此方法的作用： 提高效率，在线程中 共用一个 DBSession 对象！
        /// </summary>
        /// <returns></returns>
        public IDBSession GetDBSession()
        {
            //从当前线程中 获取 DBContext 数据仓储 对象
            IDBSession dbSession = CallContext.GetData(typeof(DBSessionFactory).Name) as DBSession;
            if(dbSession == null)
            {
                dbSession = new DBSession();
                CallContext.SetData(typeof(DBSessionFactory).Name, dbSession);
            }

            return dbSession;
        }
    }
}

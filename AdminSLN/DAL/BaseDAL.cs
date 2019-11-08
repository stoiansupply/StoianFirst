using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Model;

namespace DAL
{
    /// <summary>
    /// 数据层 父类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseDAL<T> : IDAL.IBaseDAL<T> where T : class, new()
    {
        /// <summary>
        /// EF上下文对象
        /// </summary>
        DbContext db = new UltimusDBEntities();

        #region 1.0 新增 实体
        /// <summary>
        /// 新增 实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges();
        }
        #endregion

        #region 2.0 根据id 删除
        /// <summary>
        /// 根据id 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Del(T model)
        {
            db.Set<T>().Attach(model);
            db.Set<T>().Remove(model);
            return db.SaveChanges();
        }
        #endregion

        #region 3.0 根据条件删除
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="delWhere"></param>
        /// <returns></returns>
        public int DelBy(Expression<Func<T,bool>> delWhere)
        {
            //查询要删除的数据
            List<T> listDeleting = db.Set<T>().Where(delWhere).ToList();
            //将要删除的数据 用删除方法添加到 EF 容器中
            listDeleting.ForEach(u =>
            {
                db.Set<T>().Attach(u);
                db.Set<T>().Remove(u);
            });

            return db.SaveChanges();
        }
        #endregion

        #region 4.0 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <param name="proNames"></param>
        /// <returns></returns>
        public int Modify(T model, params string[] proNames)
        {
            //4.1将 对象 添加到 EF中
            DbEntityEntry entry = db.Entry<T>(model);
            //4.2先设置 对象的包装 状态为 Unchanged
            entry.State = System.Data.Entity.EntityState.Unchanged;
            //4.3循环 被修改的属性名 数组
            foreach(string proName in proNames)
            {
                //4.4将每个 被修改的属性的状态 设置为已修改状态;后面生成update语句时，就只为已修改的属性 更新
                entry.Property(proName).IsModified = true;
            }
            return db.SaveChanges();
        }
        #endregion

        #region 4.1 批量修改
        public int ModifyBy(T model,Expression<Func<T,bool>> whereLamda,params string[] modifiedProNames)
        {
            //4.1查询要修改的数据
            List<T> listModifing = db.Set<T>().Where(whereLamda).ToList();
            //获取 实体类 类型对象
            Type t = typeof(T);
            //获取 实体类 所有的 公有属性
            List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
            //创建 实体属性 字典集合
            Dictionary<string, PropertyInfo> dictPros = new Dictionary<string, PropertyInfo>();
            //将 实体属性 中要修改的属性名 添加到 字典集合中 键：属性名  值：属性对象
            proInfos.ForEach(p =>
            {
                if (modifiedProNames.Contains(p.Name))
                {
                    dictPros.Add(p.Name, p);
                }
            });
            //4.3循环 要修改的属性名
            foreach(string proName in modifiedProNames)
            {
                //如果存在，则取出要修改的 属性对象
                PropertyInfo proInfo = dictPros[proName];
                //取出 要修改的值
                object newValue = proInfo.GetValue(model, null);

                //批量设置 要修改 对象的 属性
                foreach(T usrO in listModifing)
                {
                    //为 要修改的对象 的 要修改的属性 设置新的值
                    proInfo.SetValue(usrO, newValue, null);
                }
            }

            return db.SaveChanges();
        }
        #endregion

        #region  5.0 根据条件查询
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="whereLamda"></param>
        /// <returns></returns>
        public List<T> GetListBy(Expression<Func<T,bool>> whereLamda)
        {
            return db.Set<T>().Where(whereLamda).ToList();
        }
        #endregion

        #region 5.1 根据条件 排序 和查询
        /// <summary>
        /// 根据条件 排序 和查询
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="whereLamda"></param>
        /// <param name="orderLamda"></param>
        /// <returns></returns>
        public List<T> GetListBy<TKey>(Expression<Func<T,bool>> whereLamda,Expression<Func<T,TKey>> orderLamda)
        {
            return db.Set<T>().Where(whereLamda).OrderBy(orderLamda).ToList();
        }
        #endregion

        #region 6.0 分页查询 
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="Tkey"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="whereLamda"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<T> GetPagedList<Tkey>(int pageIndex,int pageSize,Expression<Func<T,bool>> whereLamda,Expression<Func<T,Tkey>> orderBy)
        {
            return db.Set<T>().Where(whereLamda).OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        #endregion
    }
}

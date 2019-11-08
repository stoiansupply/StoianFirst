using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    /// <summary>
    /// 业务层父接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseBLL<T> where T : class, new()
    {
        #region 1.0 新增 实体
        /// <summary>
        /// 新增 实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add(T model);
        #endregion

        #region 2.0 根据id删除
        /// <summary>
        /// 根据id删除
        /// </summary>
        /// <param name="model">包含要删除id的对象</param>
        /// <returns></returns>
        int Del(T model);
        #endregion

        #region 3.0 根据条件删除
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="delWhere"></param>
        /// <returns></returns>
        int DelBy(Expression<Func<T, bool>> delWhere);
        #endregion

        #region 4.0 修改
        /// <summary>
        /// 修改
        /// T u = new T() {uid=1,uLoginName="1234"};
        /// this.Modify(u, 'uLoginName');
        /// </summary>
        /// <param name="model">要修改的实体</param>
        /// <param name="proNames">要修改的属性名称</param>
        /// <returns></returns>
        int Modify(T model, params string[] proNames);
        #endregion

        #region 4.1 批量修改
        /// <summary>
        /// 批量修改        
        /// </summary>
        /// <param name="model">要修改的实体</param>
        /// <param name="whereLamda">查询条件</param>
        /// <param name="midifiedProNames">要修改的属性名称</param>
        /// <returns></returns>
        int ModifyBy(T model, Expression<Func<T, bool>> whereLamda, params string[] midifiedProNames);
        #endregion

        #region 5.0 根据条件查询
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="whereLamda"></param>
        /// <returns></returns>
        List<T> GetListBy(Expression<Func<T, bool>> whereLamda);
        #endregion

        #region 5.1 根据条件排序和查询
        /// <summary>
        /// 根据条件排序和查询
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="where"></param>
        /// <param name=""></param>
        /// <param name="orderLamda"></param>
        /// <returns></returns>
        List<T> GetListBy<TKey>(Expression<Func<T, bool>> whereLamda, Expression<Func<T, TKey>> orderLamda);
        #endregion

        #region 6.0 分页查询
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="whereLamda"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> GetPagedList<TKey>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLamda, Expression<Func<T, TKey>> orderBy);
        #endregion
    }
}

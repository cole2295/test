using CNVP.Application.Entity.AuthorizeManage;
using CNVP.Application.Entity.AuthorizeManage.ViewModel;
using CNVP.Application.Entity.BaseManage;
using CNVP.Util.WebControl;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CNVP.Application.IService.AuthorizeManage
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 温州市捷点信息技术有限公司
    /// 创建人：潘温崎
    /// 日 期：2015.12.5 22:35
    /// 描 述：授权认证
    /// </summary>
    public interface IAuthorizeService<T>
    {
        IQueryable<T> IQueryable();
        IQueryable<T> IQueryable(Expression<Func<T, bool>> condition);
        IEnumerable<T> FindList(Pagination pagination);
        IEnumerable<T> FindList(Expression<Func<T, bool>> condition, Pagination pagination);
        IEnumerable<T> FindList(string strSql);
        IEnumerable<T> FindList(string strSql, DbParameter[] dbParameter);
        IEnumerable<T> FindList(string strSql, Pagination pagination);
        IEnumerable<T> FindList(string strSql, DbParameter[] dbParameter, Pagination pagination);
    }
}

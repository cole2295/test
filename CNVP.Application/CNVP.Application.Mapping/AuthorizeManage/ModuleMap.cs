﻿using CNVP.Application.Entity.AuthorizeManage;
using System.Data.Entity.ModelConfiguration;

namespace CNVP.Application.Mapping.AuthorizeManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 温州市捷点信息技术有限公司
    /// 创建人：潘温崎
    /// 日 期：2015.10.27 09:16
    /// 描 述：系统功能
    /// </summary>
    public class ModuleMap : EntityTypeConfiguration<ModuleEntity>
    {
        public ModuleMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_Module");
            //主键
            this.HasKey(t => t.ModuleId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

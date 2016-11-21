using CNVP.Application.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace CNVP.Application.Mapping.SystemManage
{
    /// <summary>
    /// 版 本 6.1
    /// Copyright (c) 2013-2016 温州市捷点信息技术有限公司
    /// 创建人：潘温崎
    /// 日 期：2015.12.21 16:19
    /// 描 述：编号规则种子
    /// </summary>
    public class CodeRuleSeedMap : EntityTypeConfiguration<CodeRuleSeedEntity>
    {
        public CodeRuleSeedMap()
        {
            #region 表、主键
            //表
            this.ToTable("Base_CodeRuleSeed");
            //主键
            this.HasKey(t => t.RuleSeedId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SQLDBHelperServices.Models
{
    public partial class tcCHNContext : DbContext
    {
        public tcCHNContext()
        {

        }

        public tcCHNContext(DbContextOptions<tcCHNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<A00> A00s { get; set; }
        public virtual DbSet<A01> A01s { get; set; }
        public virtual DbSet<APatrolErrorLog> APatrolErrorLogs { get; set; }
        public virtual DbSet<SSjzd> SSjzds { get; set; }
        public virtual DbSet<SSjzdLx> SSjzdLxes { get; set; }
        public virtual DbSet<ShChnr> ShChnrs { get; set; }
        public virtual DbSet<ShClset> ShClsets { get; set; }
        public virtual DbSet<ShDwxx> ShDwxxes { get; set; }
        public virtual DbSet<ShGhdj> ShGhdjs { get; set; }
        public virtual DbSet<ShGzd> ShGzds { get; set; }
        public virtual DbSet<ShHt> ShHts { get; set; }
        public virtual DbSet<ShHtYq> ShHtYqs { get; set; }
        public virtual DbSet<ShLaw> ShLaws { get; set; }
        public virtual DbSet<ShLawTree> ShLawTrees { get; set; }
        public virtual DbSet<ShSf> ShSfs { get; set; }
        public virtual DbSet<ShSfGc> ShSfGcs { get; set; }
        public virtual DbSet<ShSfGccl> ShSfGccls { get; set; }
        public virtual DbSet<ShSfGcclSl> ShSfGcclSls { get; set; }
        public virtual DbSet<ShSfbz> ShSfbzs { get; set; }
        public virtual DbSet<ShSjcl> ShSjcls { get; set; }
        public virtual DbSet<ShSqdj> ShSqdjs { get; set; }
        public virtual DbSet<ShSqdjOld> ShSqdjOlds { get; set; }
        public virtual DbSet<ShSqdjkz> ShSqdjkzs { get; set; }
        public virtual DbSet<ShSqdjlc> ShSqdjlcs { get; set; }
        public virtual DbSet<ShTxl> ShTxls { get; set; }
        public virtual DbSet<Tabhouse> Tabhouses { get; set; }
        public virtual DbSet<Tablogcadhouse> Tablogcadhouses { get; set; }
        public virtual DbSet<Tablogcadroom> Tablogcadrooms { get; set; }
        public virtual DbSet<Tabroom> Tabrooms { get; set; }
        public virtual DbSet<TcchCeng> TcchCengs { get; set; }
        public virtual DbSet<TcchDataDict> TcchDataDicts { get; set; }
        public virtual DbSet<TcchDataDictClass> TcchDataDictClasses { get; set; }
        public virtual DbSet<TcchFtModel> TcchFtModels { get; set; }
        public virtual DbSet<TcchItem> TcchItems { get; set; }
        public virtual DbSet<TcchItemChecked> TcchItemCheckeds { get; set; }
        public virtual DbSet<TcchShi> TcchShis { get; set; }
        public virtual DbSet<TcchShiTemp> TcchShiTemps { get; set; }
        public virtual DbSet<TcchShi分摊x> TcchShi分摊xes { get; set; }
        public virtual DbSet<TcchZhuang> TcchZhuangs { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<UtExtImagePath> UtExtImagePaths { get; set; }
        public virtual DbSet<VmTcchShi> VmTcchShis { get; set; }
        public virtual DbSet<VmTcchShiNoDesid> VmTcchShiNoDesids { get; set; }
        public virtual DbSet<VmTcchShiSendRemote> VmTcchShiSendRemotes { get; set; }
        public virtual DbSet<VmTcchZhuang> VmTcchZhuangs { get; set; }
        public virtual DbSet<VmTcchZhuangSendRemote> VmTcchZhuangSendRemotes { get; set; }
        public virtual DbSet<Vm室导出> Vm室导出s { get; set; }
        public virtual DbSet<受理表> 受理表s { get; set; }
        public virtual DbSet<旧室数据> 旧室数据s { get; set; }
        public virtual DbSet<旧幢数据> 旧幢数据s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //此处使用依赖注入进行配置 
                optionsBuilder.UseSqlServer("Server=.;Database=tcCHN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<A00>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("A_00");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<A01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("A01");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PriceUnit).HasColumnName("price_unit");

                entity.Property(e => e.XNum).HasColumnName("x_num");
            });

            modelBuilder.Entity<APatrolErrorLog>(entity =>
            {
                entity.ToTable("A_PatrolErrorLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Creattime)
                    .HasColumnType("datetime")
                    .HasColumnName("creattime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorInfo).HasColumnName("errorInfo");
            });

            modelBuilder.Entity<SSjzd>(entity =>
            {
                entity.HasKey(e => e.ItemCode);

                entity.ToTable("S_SJZD");

                entity.HasComment("数据字典表");

                entity.Property(e => e.ItemCode)
                    .ValueGeneratedNever()
                    .HasComment("字典code");

                entity.Property(e => e.Available)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否可用");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .HasComment("类型");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ItemID")
                    .HasComment("字典ID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(1020)
                    .HasComment("名称");

                entity.Property(e => e.OrderCode).HasComment("显示顺序");

                entity.Property(e => e.ParentItemId)
                    .HasColumnName("ParentItemID")
                    .HasComment("父结点ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1020)
                    .HasComment("注释");
            });

            modelBuilder.Entity<SSjzdLx>(entity =>
            {
                entity.ToTable("S_SJZD_LX");

                entity.HasComment("系统联系表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.BoolRemark).HasComment("布尔型备注（默认流程：是否指定受理人）");

                entity.Property(e => e.FirstClass).HasComment("第一联系元素(数据字典)");

                entity.Property(e => e.IntRemark)
                    .HasMaxLength(500)
                    .HasComment("数字型备注(在默认流程的时候存放超期时间)");

                entity.Property(e => e.LxType)
                    .HasMaxLength(100)
                    .HasComment("联系类型(数据字典)");

                entity.Property(e => e.ObjectCode).HasComment("关系对象（例：业务类型,[数据字典]）");

                entity.Property(e => e.SecondClass).HasComment("第二联系元素(数据字典)");

                entity.Property(e => e.ThirdClass).HasComment("第三联系元素(数据字典)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(500)
                    .HasComment("用户ID");
            });

            modelBuilder.Entity<ShChnr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SH_CHNR");

                entity.HasComment("测绘内容");

                entity.Property(e => e.Category)
                    .HasDefaultValueSql("((10))")
                    .HasComment("10 测绘内容 20成果内容");

                entity.Property(e => e.Djh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DJH")
                    .HasComment("登记号");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.IsChecked)
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否选中");

                entity.Property(e => e.Sjlx)
                    .HasColumnName("SJLX")
                    .HasComment("测绘类型");

                entity.Property(e => e.Sjmc)
                    .HasMaxLength(100)
                    .HasColumnName("SJMC")
                    .HasComment("测绘名称");
            });

            modelBuilder.Entity<ShClset>(entity =>
            {
                entity.ToTable("SH_CLSET");

                entity.HasComment("材料设置");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("大类");

                entity.Property(e => e.ProjectType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("项目类型");

                entity.Property(e => e.XBh)
                    .HasMaxLength(20)
                    .HasColumnName("xBH")
                    .HasComment("编号规则");

                entity.Property(e => e.XList)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("xList")
                    .HasComment("材料清单");

                entity.Property(e => e.XOrder)
                    .HasColumnName("xOrder")
                    .HasComment("排序");

                entity.Property(e => e.XType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("xType")
                    .HasComment("类型");
            });

            modelBuilder.Entity<ShDwxx>(entity =>
            {
                entity.ToTable("SH_DWXX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dwdz)
                    .HasMaxLength(500)
                    .HasColumnName("DWDZ");

                entity.Property(e => e.Dwmc)
                    .HasMaxLength(50)
                    .HasColumnName("DWMC");

                entity.Property(e => e.Lxdh)
                    .HasMaxLength(50)
                    .HasColumnName("LXDH");

                entity.Property(e => e.Lxr)
                    .HasMaxLength(50)
                    .HasColumnName("LXR");

                entity.Property(e => e.XOrder)
                    .HasMaxLength(50)
                    .HasColumnName("xOrder");
            });

            modelBuilder.Entity<ShGhdj>(entity =>
            {
                entity.ToTable("SH_GHDJ");

                entity.HasComment("规划测绘");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.Bz)
                    .HasMaxLength(400)
                    .HasColumnName("BZ")
                    .HasComment("备注");

                entity.Property(e => e.Bz3)
                    .HasMaxLength(400)
                    .HasColumnName("BZ3")
                    .HasComment("备注3");

                entity.Property(e => e.Bz5)
                    .HasMaxLength(400)
                    .HasColumnName("BZ5")
                    .HasComment("备注");

                entity.Property(e => e.Bz6)
                    .HasMaxLength(400)
                    .HasColumnName("BZ6")
                    .HasComment("备注");

                entity.Property(e => e.Cgh5)
                    .HasMaxLength(400)
                    .HasColumnName("CGH5")
                    .HasComment("成果号");

                entity.Property(e => e.Cgh6)
                    .HasMaxLength(400)
                    .HasColumnName("CGH6")
                    .HasComment("成果号");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasComment("登记时间");

                entity.Property(e => e.Dbtype)
                    .HasColumnName("DBType")
                    .HasComment("当前督办方式");

                entity.Property(e => e.Djdl)
                    .HasColumnName("DJDL")
                    .HasComment("登记大类");

                entity.Property(e => e.Djlx)
                    .HasColumnName("DJLX")
                    .HasComment("登记类型");

                entity.Property(e => e.Djr)
                    .HasMaxLength(400)
                    .HasColumnName("DJR")
                    .HasDefaultValueSql("(N'王旭艳')")
                    .HasComment("收件人");

                entity.Property(e => e.Dw)
                    .HasMaxLength(400)
                    .HasColumnName("DW")
                    .HasComment("单位");

                entity.Property(e => e.Dwdz)
                    .HasMaxLength(400)
                    .HasColumnName("DWDZ")
                    .HasComment("单位地址");

                entity.Property(e => e.Dz)
                    .HasMaxLength(400)
                    .HasColumnName("DZ")
                    .HasComment("地址");

                entity.Property(e => e.Dzrq)
                    .HasMaxLength(400)
                    .HasColumnName("DZRQ")
                    .HasComment("到账日期");

                entity.Property(e => e.Fjr)
                    .HasMaxLength(400)
                    .HasColumnName("FJR")
                    .HasComment("发件人");

                entity.Property(e => e.Fjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("FJRQ")
                    .HasComment("发件日期");

                entity.Property(e => e.Fuid)
                    .HasMaxLength(200)
                    .HasColumnName("FUID")
                    .HasComment("FUID");

                entity.Property(e => e.Gdr)
                    .HasMaxLength(400)
                    .HasColumnName("GDR")
                    .HasComment("归档人");

                entity.Property(e => e.Gdrq)
                    .HasColumnType("datetime")
                    .HasColumnName("GDRQ")
                    .HasComment("归档日期");

                entity.Property(e => e.Gzl)
                    .HasMaxLength(400)
                    .HasColumnName("GZL")
                    .HasComment("工作量");

                entity.Property(e => e.IsBack).HasComment("是否退回");

                entity.Property(e => e.Je)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("JE")
                    .HasComment("金额");

                entity.Property(e => e.Lxdh)
                    .HasMaxLength(400)
                    .HasColumnName("LXDH")
                    .HasComment("联系电话");

                entity.Property(e => e.Pjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("PJRQ")
                    .HasComment("派件日期");

                entity.Property(e => e.Ry)
                    .HasMaxLength(400)
                    .HasColumnName("RY")
                    .HasComment("人员");

                entity.Property(e => e.Sfdz5)
                    .HasColumnName("SFDZ5")
                    .HasComment("是否到账");

                entity.Property(e => e.Sffj)
                    .HasColumnName("SFFJ")
                    .HasComment("是否发件");

                entity.Property(e => e.Sfje)
                    .HasColumnName("SFJE")
                    .HasComment("收费金额");

                entity.Property(e => e.Sfr)
                    .HasMaxLength(400)
                    .HasColumnName("SFR")
                    .HasComment("收费人");

                entity.Property(e => e.Shr)
                    .HasMaxLength(400)
                    .HasColumnName("SHR")
                    .HasComment("审核人");

                entity.Property(e => e.Shrq)
                    .HasColumnType("datetime")
                    .HasColumnName("SHRQ")
                    .HasComment("审核日期");

                entity.Property(e => e.Shrq5)
                    .HasColumnType("datetime")
                    .HasColumnName("SHRQ5")
                    .HasComment("审核日期");

                entity.Property(e => e.Shyj)
                    .HasMaxLength(400)
                    .HasColumnName("SHYJ")
                    .HasComment("审核意见");

                entity.Property(e => e.Sjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("SJRQ")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("收件日期");

                entity.Property(e => e.Spjd)
                    .HasColumnName("SPJD")
                    .HasDefaultValueSql("((0))")
                    .HasComment("审批阶段");

                entity.Property(e => e.SprQ)
                    .HasMaxLength(400)
                    .HasColumnName("SPR_Q")
                    .HasComment("前阶段审批人");

                entity.Property(e => e.SprX)
                    .HasMaxLength(1000)
                    .HasColumnName("SPR_X")
                    .HasComment("现阶段审批人");

                entity.Property(e => e.SprXStr)
                    .HasMaxLength(1000)
                    .HasColumnName("SPR_X_STR")
                    .HasComment("现阶段审批人");

                entity.Property(e => e.SprqQ)
                    .HasColumnType("datetime")
                    .HasColumnName("SPRQ_Q")
                    .HasComment("前阶段审批时间");

                entity.Property(e => e.Sprs)
                    .HasMaxLength(400)
                    .HasColumnName("SPRS")
                    .HasComment("审批人字符串");

                entity.Property(e => e.Sqr)
                    .HasMaxLength(400)
                    .HasColumnName("SQR")
                    .HasComment("申请人");

                entity.Property(e => e.Tdlb)
                    .HasMaxLength(400)
                    .HasColumnName("TDLB")
                    .HasComment("土地类型");

                entity.Property(e => e.Thrq)
                    .HasColumnType("datetime")
                    .HasColumnName("THRQ")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("退回时间");

                entity.Property(e => e.Thyj)
                    .HasMaxLength(2000)
                    .HasColumnName("THYJ")
                    .HasComment("退回意见");

                entity.Property(e => e.Wcrq)
                    .HasColumnType("datetime")
                    .HasColumnName("WCRQ")
                    .HasComment("完成日期");

                entity.Property(e => e.Wtdw)
                    .HasMaxLength(400)
                    .HasColumnName("WTDW")
                    .HasComment("委托单位");

                entity.Property(e => e.Xmbh)
                    .HasMaxLength(400)
                    .HasColumnName("XMBH")
                    .HasComment("项目编号");

                entity.Property(e => e.Xmbh3)
                    .HasMaxLength(400)
                    .HasColumnName("XMBH3")
                    .HasComment("项目编号");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(400)
                    .HasColumnName("XMMC")
                    .HasComment("项目名称");

                entity.Property(e => e.Zje)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ZJE")
                    .HasComment("总金额");

                entity.Property(e => e.Zk)
                    .HasMaxLength(50)
                    .HasColumnName("ZK")
                    .HasComment("折扣");
            });

            modelBuilder.Entity<ShGzd>(entity =>
            {
                entity.ToTable("SH_GZD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ShHt>(entity =>
            {
                entity.ToTable("SH_HT");

                entity.HasComment("合同管理");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.Fddbr)
                    .HasMaxLength(50)
                    .HasColumnName("FDDBR")
                    .HasComment("法定代表人");

                entity.Property(e => e.Fksj)
                    .HasColumnType("date")
                    .HasColumnName("FKSJ")
                    .HasComment("付款时间");

                entity.Property(e => e.Fwf)
                    .HasMaxLength(100)
                    .HasColumnName("FWF")
                    .HasComment("服务方");

                entity.Property(e => e.Gznr)
                    .HasColumnName("GZNR")
                    .HasComment("工作内容");

                entity.Property(e => e.HtType)
                    .HasMaxLength(100)
                    .HasColumnName("HT_Type")
                    .HasComment("合同类型 GH,TD,...");

                entity.Property(e => e.Htbh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("HTBH")
                    .HasComment("合同编号");

                entity.Property(e => e.Htmc)
                    .HasMaxLength(50)
                    .HasColumnName("HTMC")
                    .HasComment("合同名称");

                entity.Property(e => e.Htxl)
                    .HasMaxLength(100)
                    .HasColumnName("HTXL")
                    .HasComment("合同小类");

                entity.Property(e => e.Lxdh)
                    .HasMaxLength(100)
                    .HasColumnName("LXDH")
                    .HasComment("联系电话");

                entity.Property(e => e.Lxr)
                    .HasMaxLength(100)
                    .HasColumnName("LXR")
                    .HasComment("联系人");

                entity.Property(e => e.Qddd)
                    .HasMaxLength(100)
                    .HasColumnName("QDDD")
                    .HasDefaultValueSql("(N'上海市金山区卫二路429号3号楼')")
                    .HasComment("签订地点");

                entity.Property(e => e.Qdsj)
                    .HasColumnType("date")
                    .HasColumnName("QDSJ")
                    .HasComment("签订时间");

                entity.Property(e => e.TdIds)
                    .HasMaxLength(500)
                    .HasColumnName("TD_IDS")
                    .HasComment("土地项目ids");

                entity.Property(e => e.Wtdw)
                    .HasMaxLength(100)
                    .HasColumnName("WTDW")
                    .HasComment("委托单位");

                entity.Property(e => e.Xmbh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("XMBH")
                    .HasComment("项目编号");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(100)
                    .HasColumnName("XMMC")
                    .HasComment("项目名称");

                entity.Property(e => e.Zjze)
                    .HasMaxLength(500)
                    .HasColumnName("ZJZE")
                    .HasComment("资金总额");
            });

            modelBuilder.Entity<ShHtYq>(entity =>
            {
                entity.ToTable("SH_HT_YQ");

                entity.HasComment("仪器合同");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.Gmdw)
                    .HasMaxLength(200)
                    .HasColumnName("GMDW")
                    .HasComment("购买单位");

                entity.Property(e => e.Gmrq)
                    .HasColumnType("datetime")
                    .HasColumnName("GMRQ")
                    .HasComment("购买日期");

                entity.Property(e => e.Jbr)
                    .HasMaxLength(100)
                    .HasColumnName("JBR")
                    .HasComment("经办人");

                entity.Property(e => e.Je)
                    .HasMaxLength(100)
                    .HasColumnName("JE")
                    .HasComment("金额");

                entity.Property(e => e.Xh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("XH")
                    .HasComment("序号");

                entity.Property(e => e.Yqfl)
                    .HasMaxLength(100)
                    .HasColumnName("YQFL")
                    .HasComment("仪器分类");

                entity.Property(e => e.Yqmc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("YQMC")
                    .HasComment("仪器名称");
            });

            modelBuilder.Entity<ShLaw>(entity =>
            {
                entity.ToTable("SH_LAW");

                entity.HasComment("法律法规");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.XContent)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("xContent")
                    .HasComment("内容");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("xName")
                    .HasComment("名称");

                entity.Property(e => e.XType)
                    .HasMaxLength(100)
                    .HasColumnName("xType")
                    .HasComment("类型");
            });

            modelBuilder.Entity<ShLawTree>(entity =>
            {
                entity.ToTable("SH_LAW_TREE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bz)
                    .HasMaxLength(500)
                    .HasColumnName("bz");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.WebUrl)
                    .HasMaxLength(200)
                    .HasColumnName("webUrl");
            });

            modelBuilder.Entity<ShSf>(entity =>
            {
                entity.ToTable("SH_SF");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pid)
                    .HasMaxLength(50)
                    .HasColumnName("pid");

                entity.Property(e => e.Skfs)
                    .HasMaxLength(50)
                    .HasColumnName("skfs")
                    .HasComment("收款方式");

                entity.Property(e => e.Skje)
                    .HasColumnName("skje")
                    .HasComment("收款金额");

                entity.Property(e => e.Skr)
                    .HasMaxLength(50)
                    .HasColumnName("skr")
                    .HasComment("收款人");

                entity.Property(e => e.Skrq)
                    .HasColumnType("datetime")
                    .HasColumnName("skrq")
                    .HasComment("首款日期");
            });

            modelBuilder.Entity<ShSfGc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SH_SF_GC");

                entity.Property(e => e.Dljcksdgccl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dljcksdgccl")
                    .HasComment("道路交叉口散点高程测量");

                entity.Property(e => e.DmclH)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dmcl_h")
                    .HasComment("横断面测量");

                entity.Property(e => e.DmclZ)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dmcl_z")
                    .HasComment("断面测量                 纵断面测量");

                entity.Property(e => e.Dzdxcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dzdxcl")
                    .HasComment("带状地形图测量                 一般");

                entity.Property(e => e.GckzclDwsz)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("gckzcl_dwsz")
                    .HasComment("等外水准");

                entity.Property(e => e.GckzclSdsz)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("gckzcl_sdsz")
                    .HasComment("高程控制测量               四等水准");

                entity.Property(e => e.GcxlclKn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("gcxlcl_kn")
                    .HasComment("困难");

                entity.Property(e => e.GcxlclYb)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("gcxlcl_yb")
                    .HasComment("工程线路测量                   一般");

                entity.Property(e => e.Ghdldx)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ghdldx")
                    .HasComment("规划道路定线                   一般");

                entity.Property(e => e.Ghdzcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ghdzcl")
                    .HasComment("规划定桩测量");

                entity.Property(e => e.GhjdclGc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ghjdcl_gc")
                    .HasComment("验测高程、高度");

                entity.Property(e => e.GhjdclMj)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ghjdcl_mj")
                    .HasComment("规划面积测量");

                entity.Property(e => e.GhjdclPm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ghjdcl_pm")
                    .HasComment("规划监督测量           验测平面位置");

                entity.Property(e => e.Hbdm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("hbdm")
                    .HasComment("河浜断面");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("id");

                entity.Property(e => e.Jzwfy)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("jzwfy")
                    .HasComment("建筑物放样");

                entity.Property(e => e.PmkzclDx)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pmkzcl_dx")
                    .HasComment("一、二、三级导线");

                entity.Property(e => e.PmkzclGps)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pmkzcl_GPS")
                    .HasComment("平面控制测量          GPS测量（E级）");

                entity.Property(e => e.PmkzclXsj)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pmkzcl_xsj")
                    .HasComment("一、二级小三角");

                entity.Property(e => e.Qwdyt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("qwdyt")
                    .HasComment("桥位大样图");

                entity.Property(e => e.Xbdcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("xbdcl")
                    .HasComment("细部点测量");

                entity.Property(e => e.Xsdmc)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("xsdmc")
                    .HasComment("下水道摸测");

                entity.Property(e => e.Ydfwcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ydfwcl")
                    .HasComment("用地范围线测量");
            });

            modelBuilder.Entity<ShSfGccl>(entity =>
            {
                entity.ToTable("SH_SF_GCCL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bz)
                    .HasMaxLength(500)
                    .HasColumnName("bz")
                    .HasComment("备注");

                entity.Property(e => e.Dj)
                    .HasColumnName("dj")
                    .HasComment("单价(元)");

                entity.Property(e => e.Dw)
                    .HasMaxLength(50)
                    .HasColumnName("dw")
                    .HasComment("单位");

                entity.Property(e => e.Lx)
                    .HasMaxLength(50)
                    .HasColumnName("lx")
                    .HasComment("类型");

                entity.Property(e => e.Xh)
                    .HasMaxLength(50)
                    .HasColumnName("xh")
                    .HasComment("序号");

                entity.Property(e => e.Xm)
                    .HasMaxLength(50)
                    .HasColumnName("xm")
                    .HasComment("项目");
            });

            modelBuilder.Entity<ShSfGcclSl>(entity =>
            {
                entity.ToTable("SH_SF_GCCL_SL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bz)
                    .HasMaxLength(50)
                    .HasColumnName("bz")
                    .HasComment("备注");

                entity.Property(e => e.Dj)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("dj")
                    .HasComment("单价（元）");

                entity.Property(e => e.Dw)
                    .HasMaxLength(50)
                    .HasColumnName("dw")
                    .HasComment("单位");

                entity.Property(e => e.Gzl)
                    .HasColumnName("gzl")
                    .HasComment("工作量");

                entity.Property(e => e.Je)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("je")
                    .HasComment("金额");

                entity.Property(e => e.Xh)
                    .HasMaxLength(50)
                    .HasColumnName("xh")
                    .HasComment("序号");

                entity.Property(e => e.Xm)
                    .HasMaxLength(50)
                    .HasColumnName("xm")
                    .HasComment("项目");

                entity.Property(e => e.Xmbh)
                    .HasMaxLength(50)
                    .HasColumnName("xmbh");
            });

            modelBuilder.Entity<ShSfbz>(entity =>
            {
                entity.ToTable("SH_SFBZ");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Djcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("djcl");

                entity.Property(e => e.Djpt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("djpt")
                    .HasComment("地籍配图");

                entity.Property(e => e.Jzd)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("jzd")
                    .HasComment("界址点");

                entity.Property(e => e.Jzwjx)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("jzwjx");

                entity.Property(e => e.Kzd)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("kzd")
                    .HasComment("控制点");

                entity.Property(e => e.Lxcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("lxcl")
                    .HasComment("零星测绘");

                entity.Property(e => e.Sftdcl)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("sftdcl")
                    .HasComment("私房土地测量");
            });

            modelBuilder.Entity<ShSjcl>(entity =>
            {
                entity.ToTable("SH_SJCL");

                entity.HasComment("收件属性结构描述表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.Djh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DJH")
                    .HasComment("登记号");

                entity.Property(e => e.IsCheck).HasColumnName("isCheck");

                entity.Property(e => e.Sjmc)
                    .HasMaxLength(100)
                    .HasColumnName("SJMC")
                    .HasComment("收件名称");

                entity.Property(e => e.XStatus)
                    .HasColumnName("xStatus")
                    .HasDefaultValueSql("((10))")
                    .HasComment("10土地 20规划");

                entity.Property(e => e.XType)
                    .HasMaxLength(100)
                    .HasColumnName("xType");
            });

            modelBuilder.Entity<ShSqdj>(entity =>
            {
                entity.ToTable("SH_SQDJ");

                entity.HasComment("登记主表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.Bm)
                    .HasMaxLength(200)
                    .HasColumnName("BM")
                    .HasComment("部门");

                entity.Property(e => e.Bz)
                    .HasMaxLength(200)
                    .HasColumnName("BZ")
                    .HasComment("备注");

                entity.Property(e => e.Bz3)
                    .HasMaxLength(200)
                    .HasColumnName("BZ3")
                    .HasComment("备注3");

                entity.Property(e => e.Bz5)
                    .HasMaxLength(200)
                    .HasColumnName("BZ5")
                    .HasComment("备注");

                entity.Property(e => e.Bz6)
                    .HasMaxLength(200)
                    .HasColumnName("BZ6")
                    .HasComment("备注");

                entity.Property(e => e.Cgh)
                    .HasMaxLength(200)
                    .HasColumnName("CGH")
                    .HasComment("成果号");

                entity.Property(e => e.Cgh5)
                    .HasMaxLength(200)
                    .HasColumnName("CGH5")
                    .HasComment("成果号");

                entity.Property(e => e.Cgh6)
                    .HasMaxLength(200)
                    .HasColumnName("CGH6")
                    .HasComment("成果号");

                entity.Property(e => e.Chyq)
                    .HasMaxLength(200)
                    .HasColumnName("CHYQ")
                    .HasComment("测绘要求");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("登记时间");

                entity.Property(e => e.Dbtype)
                    .HasColumnName("DBType")
                    .HasComment("当前督办方式");

                entity.Property(e => e.Djch)
                    .HasMaxLength(200)
                    .HasColumnName("DJCH")
                    .HasComment("地籍测绘");

                entity.Property(e => e.DjchDj)
                    .HasColumnName("DJCH_DJ")
                    .HasComment("地籍测绘单价");

                entity.Property(e => e.Djdl)
                    .HasColumnName("DJDL")
                    .HasComment("登记大类");

                entity.Property(e => e.Djlx)
                    .HasColumnName("DJLX")
                    .HasComment("登记类型");

                entity.Property(e => e.Djpts)
                    .HasMaxLength(200)
                    .HasColumnName("DJPTS")
                    .HasComment("地籍配图数");

                entity.Property(e => e.DjptsDj)
                    .HasColumnName("DJPTS_DJ")
                    .HasComment("地籍配图数单价");

                entity.Property(e => e.Djr)
                    .HasMaxLength(200)
                    .HasColumnName("DJR")
                    .HasDefaultValueSql("(N'陶磊')")
                    .HasComment("登记人");

                entity.Property(e => e.Dw)
                    .HasMaxLength(200)
                    .HasColumnName("DW")
                    .HasComment("单位");

                entity.Property(e => e.Dwdz)
                    .HasMaxLength(200)
                    .HasColumnName("DWDZ")
                    .HasComment("单位地址");

                entity.Property(e => e.Dz)
                    .HasMaxLength(200)
                    .HasColumnName("DZ")
                    .HasComment("地址");

                entity.Property(e => e.Fjgs)
                    .HasColumnName("FJGS")
                    .HasComment("发件个数");

                entity.Property(e => e.Fjr)
                    .HasMaxLength(200)
                    .HasColumnName("FJR")
                    .HasComment("发件人");

                entity.Property(e => e.Fjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("FJRQ")
                    .HasComment("发件日期");

                entity.Property(e => e.Fuid)
                    .HasMaxLength(100)
                    .HasColumnName("FUID")
                    .HasComment("FUID");

                entity.Property(e => e.Gdbgs)
                    .HasColumnName("GDBGS")
                    .HasComment("报告书是否提交");

                entity.Property(e => e.Gdr)
                    .HasMaxLength(200)
                    .HasColumnName("GDR")
                    .HasComment("归档人");

                entity.Property(e => e.Gdrq)
                    .HasColumnType("datetime")
                    .HasColumnName("GDRQ")
                    .HasComment("归档日期");

                entity.Property(e => e.Gdzl)
                    .HasColumnName("GDZL")
                    .HasComment("资料是否提交");

                entity.Property(e => e.IsBack).HasComment("是否退回");

                entity.Property(e => e.Je)
                    .HasColumnName("JE")
                    .HasComment("金额");

                entity.Property(e => e.Jzds)
                    .HasMaxLength(200)
                    .HasColumnName("JZDS")
                    .HasComment("界址点数");

                entity.Property(e => e.JzdsDj)
                    .HasColumnName("JZDS_DJ")
                    .HasComment("界址点数单价");

                entity.Property(e => e.JzwjxDj)
                    .HasColumnName("JZWJX_DJ")
                    .HasComment("建筑物交线单价");

                entity.Property(e => e.Jzwjxs)
                    .HasMaxLength(200)
                    .HasColumnName("JZWJXS")
                    .HasComment("建筑物交线");

                entity.Property(e => e.Kzds)
                    .HasMaxLength(200)
                    .HasColumnName("KZDS")
                    .HasComment("控制点数");

                entity.Property(e => e.KzdsDj)
                    .HasColumnName("KZDS_DJ")
                    .HasComment("控制点数单价");

                entity.Property(e => e.Lxch)
                    .HasMaxLength(200)
                    .HasColumnName("LXCH")
                    .HasComment("零星测绘");

                entity.Property(e => e.LxchDj)
                    .HasColumnName("LXCH_DJ")
                    .HasComment("零星测绘单价");

                entity.Property(e => e.Lxdh)
                    .HasMaxLength(200)
                    .HasColumnName("LXDH")
                    .HasComment("联系电话");

                entity.Property(e => e.Lxr)
                    .HasMaxLength(200)
                    .HasColumnName("LXR")
                    .HasComment("联系人");

                entity.Property(e => e.Nf)
                    .HasColumnName("NF")
                    .HasDefaultValueSql("((2018))")
                    .HasComment("年份");

                entity.Property(e => e.Pjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("PJRQ")
                    .HasComment("派件日期");

                entity.Property(e => e.Ry)
                    .HasMaxLength(200)
                    .HasColumnName("RY")
                    .HasComment("人员");

                entity.Property(e => e.Sfdz5)
                    .HasColumnName("SFDZ5")
                    .HasComment("是否到账");

                entity.Property(e => e.Sfje)
                    .HasColumnName("SFJE")
                    .HasComment("收费金额");

                entity.Property(e => e.Sfr)
                    .HasMaxLength(200)
                    .HasColumnName("SFR")
                    .HasComment("收费人");

                entity.Property(e => e.Sftd)
                    .HasMaxLength(200)
                    .HasColumnName("SFTD")
                    .HasComment("私房土地测量");

                entity.Property(e => e.SftdDj)
                    .HasColumnName("SFTD_DJ")
                    .HasComment("私房土地测量单价");

                entity.Property(e => e.Shr)
                    .HasMaxLength(200)
                    .HasColumnName("SHR")
                    .HasComment("审核人");

                entity.Property(e => e.Shrq)
                    .HasColumnType("datetime")
                    .HasColumnName("SHRQ")
                    .HasComment("审核日期");

                entity.Property(e => e.Shrq5)
                    .HasColumnType("datetime")
                    .HasColumnName("SHRQ5")
                    .HasComment("审核日期");

                entity.Property(e => e.Shyj)
                    .HasMaxLength(200)
                    .HasColumnName("SHYJ")
                    .HasComment("审核意见");

                entity.Property(e => e.Sjcl)
                    .HasColumnName("SJCL")
                    .HasComment("收件材料是否提交");

                entity.Property(e => e.Sjr)
                    .HasMaxLength(200)
                    .HasColumnName("SJR")
                    .HasDefaultValueSql("(N'陶磊')")
                    .HasComment("收件人");

                entity.Property(e => e.Sjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("SJRQ")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("收件日期");

                entity.Property(e => e.Spjd)
                    .HasColumnName("SPJD")
                    .HasComment("审批阶段");

                entity.Property(e => e.SprQ)
                    .HasMaxLength(200)
                    .HasColumnName("SPR_Q")
                    .HasComment("前阶段审批人");

                entity.Property(e => e.SprX)
                    .HasMaxLength(500)
                    .HasColumnName("SPR_X")
                    .HasComment("现阶段审批人");

                entity.Property(e => e.SprXStr)
                    .HasMaxLength(500)
                    .HasColumnName("SPR_X_STR")
                    .HasComment("现阶段审批人");

                entity.Property(e => e.SprqQ)
                    .HasColumnType("datetime")
                    .HasColumnName("SPRQ_Q")
                    .HasComment("前阶段审批时间");

                entity.Property(e => e.Sprs)
                    .HasMaxLength(200)
                    .HasColumnName("SPRS")
                    .HasComment("审批人字符串");

                entity.Property(e => e.Sqr)
                    .HasMaxLength(200)
                    .HasColumnName("SQR")
                    .HasComment("申请人");

                entity.Property(e => e.Tdlb)
                    .HasMaxLength(200)
                    .HasColumnName("TDLB")
                    .HasComment("土地类型");

                entity.Property(e => e.Tdmj)
                    .HasColumnName("TDMJ")
                    .HasDefaultValueSql("((0))")
                    .HasComment("土地面积");

                entity.Property(e => e.Thrq)
                    .HasColumnType("datetime")
                    .HasColumnName("THRQ")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("退回时间");

                entity.Property(e => e.Thyj)
                    .HasMaxLength(1000)
                    .HasColumnName("THYJ")
                    .HasComment("退回意见");

                entity.Property(e => e.Wcrq)
                    .HasColumnType("datetime")
                    .HasColumnName("WCRQ")
                    .HasComment("完成日期");

                entity.Property(e => e.Xmbh)
                    .HasMaxLength(200)
                    .HasColumnName("XMBH")
                    .HasComment("项目编号");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(200)
                    .HasColumnName("XMMC")
                    .HasComment("项目名称");

                entity.Property(e => e.Zk)
                    .HasMaxLength(50)
                    .HasColumnName("zk")
                    .HasDefaultValueSql("((1))")
                    .HasComment("折扣");
            });

            modelBuilder.Entity<ShSqdjOld>(entity =>
            {
                entity.ToTable("SH_SQDJ_OLD");

                entity.HasComment("登记主表");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.Dbtype)
                    .HasColumnName("DBType")
                    .HasComment("当前督办方式");

                entity.Property(e => e.Djh)
                    .HasMaxLength(100)
                    .HasColumnName("DJH")
                    .HasComment("登记号");

                entity.Property(e => e.Djlx)
                    .HasColumnName("DJLX")
                    .HasComment("登记类型");

                entity.Property(e => e.Dwdz)
                    .HasMaxLength(400)
                    .HasColumnName("DWDZ")
                    .HasComment("单位地址");

                entity.Property(e => e.Fuid)
                    .HasMaxLength(50)
                    .HasColumnName("FUID");

                entity.Property(e => e.IsBack).HasComment("是否退回");

                entity.Property(e => e.Jar)
                    .HasColumnName("JAR")
                    .HasComment("结案人");

                entity.Property(e => e.Jarq)
                    .HasColumnType("datetime")
                    .HasColumnName("JARQ")
                    .HasComment("结案时间");

                entity.Property(e => e.Lxdh)
                    .HasMaxLength(400)
                    .HasColumnName("LXDH")
                    .HasComment("联系人电话");

                entity.Property(e => e.Lxr)
                    .HasMaxLength(400)
                    .HasColumnName("LXR")
                    .HasComment("联系人");

                entity.Property(e => e.Notes)
                    .HasMaxLength(4000)
                    .HasComment("备注");

                entity.Property(e => e.SjrId)
                    .HasColumnName("SJR_ID")
                    .HasComment("收件人ID");

                entity.Property(e => e.Sjrq)
                    .HasColumnType("datetime")
                    .HasColumnName("SJRQ")
                    .HasComment("收件时间");

                entity.Property(e => e.Spjd)
                    .HasColumnName("SPJD")
                    .HasDefaultValueSql("((4010))")
                    .HasComment("审批阶段");

                entity.Property(e => e.SprQ)
                    .HasColumnName("SPR_Q")
                    .HasComment("前阶段审批人");

                entity.Property(e => e.SprX)
                    .HasColumnName("SPR_X")
                    .HasComment("现阶段审批人");

                entity.Property(e => e.SprqQ)
                    .HasColumnType("datetime")
                    .HasColumnName("SPRQ_Q")
                    .HasComment("前阶段审批时间");

                entity.Property(e => e.Sprs)
                    .HasMaxLength(100)
                    .HasColumnName("SPRS")
                    .HasComment("审批人字符串");

                entity.Property(e => e.Sqr)
                    .HasMaxLength(400)
                    .HasColumnName("SQR")
                    .HasComment("申请人");

                entity.Property(e => e.Tdmj)
                    .HasColumnName("TDMJ")
                    .HasComment("土地面积");

                entity.Property(e => e.Tdzl)
                    .HasMaxLength(1000)
                    .HasColumnName("TDZL")
                    .HasComment("土地坐落");

                entity.Property(e => e.Xmmc)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("XMMC")
                    .HasComment("项目名称");
            });

            modelBuilder.Entity<ShSqdjkz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SH_SQDJKZ");

                entity.HasComment("登记流程扩展表（督办、退回）");

                entity.Property(e => e.Dbjd)
                    .HasColumnName("DBJD")
                    .HasComment("督办阶段");

                entity.Property(e => e.Dblx)
                    .HasColumnName("DBLX")
                    .HasComment("督办类型");

                entity.Property(e => e.Dbr)
                    .HasColumnName("DBR")
                    .HasComment("督办人");

                entity.Property(e => e.Dbsj)
                    .HasColumnType("datetime")
                    .HasColumnName("DBSJ")
                    .HasComment("督办时间");

                entity.Property(e => e.Djh)
                    .HasMaxLength(100)
                    .HasColumnName("DJH")
                    .HasComment("登记号");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.Isvalid)
                    .HasColumnName("ISValid")
                    .HasComment("是否有效");

                entity.Property(e => e.Kznr)
                    .HasMaxLength(800)
                    .HasColumnName("KZNR")
                    .HasComment("督办内容");
            });

            modelBuilder.Entity<ShSqdjlc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SH_SQDJLC");

                entity.HasComment("登记流程表");

                entity.Property(e => e.Czsj)
                    .HasColumnType("datetime")
                    .HasColumnName("CZSJ")
                    .HasComment("操作时间");

                entity.Property(e => e.Djh)
                    .HasMaxLength(100)
                    .HasColumnName("DJH")
                    .HasComment("登记号");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasComment("自增id");

                entity.Property(e => e.Sfwc)
                    .HasColumnName("SFWC")
                    .HasComment("是否完成");

                entity.Property(e => e.Spjd)
                    .HasColumnName("SPJD")
                    .HasComment("审批阶段");

                entity.Property(e => e.SpjdN)
                    .HasColumnName("SPJD_N")
                    .HasComment("下一个受理阶段");

                entity.Property(e => e.SprX)
                    .HasColumnName("SPR_X")
                    .HasComment("审批人");

                entity.Property(e => e.SprXslsj)
                    .HasColumnType("datetime")
                    .HasColumnName("SPR_XSLSJ")
                    .HasComment("审批实际受理时间");

                entity.Property(e => e.Spyj)
                    .HasColumnType("ntext")
                    .HasColumnName("SPYJ")
                    .HasComment("审批意见");
            });

            modelBuilder.Entity<ShTxl>(entity =>
            {
                entity.ToTable("SH_TXL");

                entity.HasComment("通讯录");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID");

                entity.Property(e => e.AddAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Add_Address")
                    .HasComment("地址");

                entity.Property(e => e.AddBirthday)
                    .HasMaxLength(100)
                    .HasColumnName("Add_birthday")
                    .HasComment("生日 ");

                entity.Property(e => e.AddCompany)
                    .HasMaxLength(100)
                    .HasColumnName("Add_Company")
                    .HasComment("公司名称");

                entity.Property(e => e.AddCompanyAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Add_Company_Address")
                    .HasComment("公司地址");

                entity.Property(e => e.AddName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Add_Name")
                    .HasComment("姓名");

                entity.Property(e => e.AddPhone)
                    .HasMaxLength(100)
                    .HasColumnName("Add_Phone")
                    .HasComment("手机");

                entity.Property(e => e.AddTel)
                    .HasMaxLength(100)
                    .HasColumnName("Add_Tel")
                    .HasComment("电话");

                entity.Property(e => e.AddZip)
                    .HasMaxLength(100)
                    .HasColumnName("Add_Zip")
                    .HasComment("邮编");
            });

            modelBuilder.Entity<Tabhouse>(entity =>
            {
                entity.ToTable("TABHOUSE");

                entity.HasIndex(e => e.Desid, "TABLOGCADHOUSE_DESID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Unitno, e.Sourceid }, "TABLOGCADHOUSE_SOURCEID");

                entity.HasIndex(e => e.Id, "XPKTABLOGCADHOUSE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Desid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESID");

                entity.Property(e => e.Inchessflag)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("INCHESSFLAG");

                entity.Property(e => e.Indate).HasColumnName("INDATE");

                entity.Property(e => e.Sourceid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCEID");

                entity.Property(e => e.Unitno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UNITNO");

                entity.Property(e => e.Userid)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Tablogcadhouse>(entity =>
            {
                entity.ToTable("TABLOGCADHOUSE");

                entity.HasIndex(e => e.Desid, "TABLOGCADHOUSE_DESID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Unitno, e.Sourceid }, "TABLOGCADHOUSE_SOURCEID");

                entity.HasIndex(e => e.Id, "XPKTABLOGCADHOUSE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Desid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESID");

                entity.Property(e => e.Inchessflag)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("INCHESSFLAG");

                entity.Property(e => e.Indate).HasColumnName("INDATE");

                entity.Property(e => e.Sourceid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCEID");

                entity.Property(e => e.Unitno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UNITNO");

                entity.Property(e => e.Userid)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Tablogcadroom>(entity =>
            {
                entity.ToTable("TABLOGCADROOM");

                entity.HasIndex(e => e.Desid, "TABLOGCADROOM_DESID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Unitno, e.Sourceid }, "TABLOGCADROOM_SOURCEID");

                entity.HasIndex(e => e.Id, "XPKTABLOGCADROOM")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Desid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESID");

                entity.Property(e => e.Indate).HasColumnName("INDATE");

                entity.Property(e => e.Sourceid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCEID");

                entity.Property(e => e.Unitno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNITNO");

                entity.Property(e => e.Userid)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Tabroom>(entity =>
            {
                entity.ToTable("TABROOM");

                entity.HasIndex(e => e.Desid, "TABLOGCADROOM_DESID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Unitno, e.Sourceid }, "TABLOGCADROOM_SOURCEID");

                entity.HasIndex(e => e.Id, "XPKTABLOGCADROOM")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("ID");

                entity.Property(e => e.Desid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESID");

                entity.Property(e => e.Indate).HasColumnName("INDATE");

                entity.Property(e => e.Sourceid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCEID");

                entity.Property(e => e.Unitno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UNITNO");

                entity.Property(e => e.Userid)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<TcchCeng>(entity =>
            {
                entity.ToTable("TCCH_Ceng");

                entity.Property(e => e.Cg)
                    .HasColumnName("CG")
                    .HasComment("层高");

                entity.Property(e => e.Clx)
                    .HasMaxLength(50)
                    .HasColumnName("CLX")
                    .HasComment("层类型");

                entity.Property(e => e.Cm)
                    .HasMaxLength(10)
                    .HasColumnName("CM")
                    .HasComment("层名");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否删除");

                entity.Property(e => e.OldItemId).HasMaxLength(20);

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH")
                    .HasComment("施工幢号");

                entity.Property(e => e.Zbh)
                    .HasColumnName("ZBH")
                    .HasComment("幢编号");

                entity.Property(e => e._).HasColumnName("-----");
            });

            modelBuilder.Entity<TcchDataDict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_DataDict");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sort)
                    .HasDefaultValueSql("((100))")
                    .HasComment("100");

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<TcchDataDictClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_DataDict_Class");

                entity.Property(e => e.ClassId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TcchFtModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_FT_Model");

                entity.Property(e => e.Ftarea)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ftarea")
                    .HasComment("分摊面积");

                entity.Property(e => e.Ftnum)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ftnum")
                    .HasComment("分摊系数");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否删除");

                entity.Property(e => e.Jdname)
                    .HasMaxLength(20)
                    .HasColumnName("jdname")
                    .HasComment("节点名");

                entity.Property(e => e.Jdnum)
                    .HasMaxLength(20)
                    .HasColumnName("jdnum")
                    .HasComment("第几层的节点");

                entity.Property(e => e.Mirror)
                    .HasMaxLength(50)
                    .HasColumnName("mirror");

                entity.Property(e => e.ModelId).ValueGeneratedOnAdd();

                entity.Property(e => e.OldItemId)
                    .HasMaxLength(20)
                    .HasComment("旧项目编号");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH")
                    .HasComment("施工幢号");

                entity.Property(e => e.Suballarea)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("suballarea")
                    .HasComment("下面总面积");

                entity.Property(e => e.Tag)
                    .HasMaxLength(20)
                    .HasColumnName("tag")
                    .HasComment("节点类型");

                entity.Property(e => e.Zsarea)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("zsarea")
                    .HasComment("共有面积");

                entity.Property(e => e._).HasColumnName("-------");
            });

            modelBuilder.Entity<TcchItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("TCCH_Item");

                entity.Property(e => e.Cgbh)
                    .HasMaxLength(20)
                    .HasColumnName("CGBH")
                    .HasComment("成果编号");

                entity.Property(e => e.Chgs)
                    .HasMaxLength(50)
                    .HasColumnName("CHGS")
                    .HasComment("测绘公司");

                entity.Property(e => e.Fcqh)
                    .HasMaxLength(50)
                    .HasColumnName("FCQH")
                    .HasComment("房产区号");

                entity.Property(e => e.Fcqsz)
                    .HasMaxLength(50)
                    .HasColumnName("FCQSZ")
                    .HasComment("房产权属主");

                entity.Property(e => e.Fczl)
                    .HasMaxLength(250)
                    .HasColumnName("FCZL")
                    .HasComment("房产座落");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否删除");

                entity.Property(e => e.IsOld)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否为旧数据");

                entity.Property(e => e.IsSendReg)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否提交到登记");

                entity.Property(e => e.Kfszjh)
                    .HasMaxLength(200)
                    .HasColumnName("KFSZJH")
                    .HasComment("开发公司证件号");

                entity.Property(e => e.Lxdh)
                    .HasMaxLength(50)
                    .HasColumnName("LXDH")
                    .HasComment("联系电话");

                entity.Property(e => e.Lxr)
                    .HasMaxLength(50)
                    .HasColumnName("LXR")
                    .HasComment("联系人");

                entity.Property(e => e.MdbPath).HasComment("Mdb数据库路径");

                entity.Property(e => e.OldStatus).HasComment("旧数据状态");

                entity.Property(e => e.Qh)
                    .HasMaxLength(50)
                    .HasColumnName("QH")
                    .HasComment("丘号");

                entity.Property(e => e.Qmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("QMJ")
                    .HasComment("丘面积");

                entity.Property(e => e.Qms)
                    .HasMaxLength(250)
                    .HasColumnName("QMS")
                    .HasComment("丘描述");

                entity.Property(e => e.Qsz)
                    .HasMaxLength(50)
                    .HasColumnName("QSZ")
                    .HasComment("丘四至");

                entity.Property(e => e.Rwchs)
                    .HasMaxLength(50)
                    .HasColumnName("RWCHS")
                    .HasComment("任务测绘师");

                entity.Property(e => e.Rwrq)
                    .HasColumnType("date")
                    .HasColumnName("RWRQ")
                    .HasComment("任务日期");

                entity.Property(e => e.Sfyc)
                    .HasColumnName("SFYC")
                    .HasDefaultValueSql("((5))")
                    .HasComment("是否为预测件，1为预测，5为正式测绘");

                entity.Property(e => e.Slbh)
                    .HasColumnName("SLBH")
                    .HasComment("受理编号");

                entity.Property(e => e.Slrq)
                    .HasColumnType("date")
                    .HasColumnName("SLRQ")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("受理日期");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("审核状态");

                entity.Property(e => e.Tfh)
                    .HasMaxLength(50)
                    .HasColumnName("TFH")
                    .HasComment("图幅号");

                entity.Property(e => e.Xlh)
                    .HasMaxLength(20)
                    .HasColumnName("XLH")
                    .HasComment("序列号");

                entity.Property(e => e.Xmlj)
                    .HasMaxLength(250)
                    .HasColumnName("XMLJ")
                    .HasComment("项目路径");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(250)
                    .HasColumnName("XMMC")
                    .HasComment("项目名称");

                entity.Property(e => e.Xmms)
                    .HasMaxLength(250)
                    .HasColumnName("XMMS")
                    .HasComment("项目描述");

                entity.Property(e => e.Xzqh)
                    .HasMaxLength(50)
                    .HasColumnName("XZQH")
                    .HasComment("行政区号");

                entity.Property(e => e.Yccgbh)
                    .HasMaxLength(20)
                    .HasColumnName("YCCGBH")
                    .HasComment("预测成果编号");

                entity.Property(e => e.Ydlb)
                    .HasMaxLength(20)
                    .HasColumnName("YDLB")
                    .HasComment("用地类别");

                entity.Property(e => e.Ywlx)
                    .HasMaxLength(20)
                    .HasColumnName("YWLX")
                    .HasComment("业务类型");

                entity.Property(e => e.ZipPath).HasComment("Zip压缩包路径");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("-------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TcchItemChecked>(entity =>
            {
                entity.ToTable("TCCH_Item_Checked");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckUser).HasMaxLength(50);

                entity.Property(e => e.Direction)
                    .HasDefaultValueSql("((1))")
                    .HasComment("审核方向");

                entity.Property(e => e.OldItemId)
                    .HasMaxLength(20)
                    .HasComment("旧项目编号");

                entity.Property(e => e.Remark)
                    .HasMaxLength(250)
                    .HasComment("建议 意见");
            });

            modelBuilder.Entity<TcchShi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_Shi");

                entity.Property(e => e.Cqmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CQMJ")
                    .HasComment("产权面积");

                entity.Property(e => e.Ftjd)
                    .HasMaxLength(50)
                    .HasColumnName("FTJD")
                    .HasComment("分摊节点");

                entity.Property(e => e.Ftmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTMJ")
                    .HasComment("分摊面积");

                entity.Property(e => e.Ftxs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTXS")
                    .HasComment("分摊系数");

                entity.Property(e => e.ImagePath).HasComment("文件路径");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否删除");

                entity.Property(e => e.IsSendReg)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否提交登记");

                entity.Property(e => e.ItemId).HasComment("项目ID");

                entity.Property(e => e.Mjfl)
                    .HasMaxLength(20)
                    .HasColumnName("MJFL")
                    .HasComment("面积分类");

                entity.Property(e => e.OldSlbh)
                    .HasColumnName("OldSLBH")
                    .HasComment("旧受理编号");

                entity.Property(e => e.Qmjyb)
                    .HasMaxLength(50)
                    .HasColumnName("QMJYB")
                    .HasComment("取面积一半");

                entity.Property(e => e.RoomId)
                    .ValueGeneratedOnAdd()
                    .HasComment("");

                entity.Property(e => e.Rzsfhg)
                    .HasMaxLength(20)
                    .HasColumnName("RZSFHG")
                    .HasComment("日照是否合格");

                entity.Property(e => e.Sbh)
                    .HasColumnName("SBH")
                    .HasComment("室编号");

                entity.Property(e => e.SbhDj)
                    .HasColumnName("SBH_DJ")
                    .HasComment("旧登记 ID ");

                entity.Property(e => e.SbhNew)
                    .HasColumnName("SBH_NEW")
                    .HasComment("合并后室编号 旧登记ID为空时用SBH");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH")
                    .HasComment("施工幢号");

                entity.Property(e => e.Sh)
                    .HasMaxLength(20)
                    .HasColumnName("SH")
                    .HasComment("室号");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT")
                    .HasComment("设计用途");

                entity.Property(e => e.Sm)
                    .HasMaxLength(20)
                    .HasColumnName("SM")
                    .HasComment("室名");

                entity.Property(e => e.Ssm)
                    .HasColumnName("SSM")
                    .HasComment("SSM");

                entity.Property(e => e.Szc)
                    .HasMaxLength(30)
                    .HasColumnName("SZC")
                    .HasComment("所在层");

                entity.Property(e => e.Szc2)
                    .HasColumnName("SZC2")
                    .HasComment("所在层2");

                entity.Property(e => e.Szdy)
                    .HasMaxLength(20)
                    .HasColumnName("SZDY")
                    .HasComment("所在单元");

                entity.Property(e => e.Tddymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDDYMJ")
                    .HasDefaultValueSql("((0))")
                    .HasComment("土地独用面积");

                entity.Property(e => e.Tdftmj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTMJ")
                    .HasDefaultValueSql("((0))")
                    .HasComment("土地分摊面积");

                entity.Property(e => e.Tdftxs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTXS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("分摊系数");

                entity.Property(e => e.Tdgymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDGYMJ")
                    .HasDefaultValueSql("((0))")
                    .HasComment("土地公用面积");

                entity.Property(e => e.Tdyt)
                    .HasMaxLength(50)
                    .HasColumnName("TDYT")
                    .HasComment("土地用途");

                entity.Property(e => e.Zbh)
                    .HasColumnName("ZBH")
                    .HasComment("幢编号");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG")
                    .HasComment("房屋结构");

                entity.Property(e => e.Zjlbcyjs)
                    .HasColumnName("ZJLBCYJS")
                    .HasComment("只记录不参与计算");

                entity.Property(e => e.Zsmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ZSMJ")
                    .HasComment("自身面积");

                entity.Property(e => e.Zzrq)
                    .HasColumnType("date")
                    .HasColumnName("ZZRQ")
                    .HasComment("终止日期");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("--------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TcchShiTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_Shi_Temp");

                entity.Property(e => e.Cqmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CQMJ")
                    .HasComment("产权面积");

                entity.Property(e => e.Ftjd)
                    .HasMaxLength(50)
                    .HasColumnName("FTJD")
                    .HasComment("分摊节点");

                entity.Property(e => e.Ftmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTMJ")
                    .HasComment("分摊面积");

                entity.Property(e => e.Ftxs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTXS")
                    .HasComment("分摊系数");

                entity.Property(e => e.ImagePath).HasComment("文件路径");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否删除");

                entity.Property(e => e.IsSendReg)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否提交到登记");

                entity.Property(e => e.ItemId).HasComment("项目ID");

                entity.Property(e => e.Mjfl)
                    .HasMaxLength(20)
                    .HasColumnName("MJFL")
                    .HasComment("面积分类");

                entity.Property(e => e.OldSlbh)
                    .HasColumnName("OldSLBH")
                    .HasComment("旧受理编号");

                entity.Property(e => e.Qmjyb)
                    .HasMaxLength(50)
                    .HasColumnName("QMJYB")
                    .HasComment("取面积一半");

                entity.Property(e => e.RoomId).ValueGeneratedOnAdd();

                entity.Property(e => e.Rzsfhg)
                    .HasMaxLength(20)
                    .HasColumnName("RZSFHG")
                    .HasComment("日照是否合格");

                entity.Property(e => e.Sbh)
                    .HasColumnName("SBH")
                    .HasComment("室编号");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH")
                    .HasComment("施工幢号");

                entity.Property(e => e.Sh)
                    .HasMaxLength(20)
                    .HasColumnName("SH")
                    .HasComment("室号");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT")
                    .HasComment("设计用途");

                entity.Property(e => e.Sm)
                    .HasMaxLength(20)
                    .HasColumnName("SM")
                    .HasComment("室名");

                entity.Property(e => e.Ssm)
                    .HasColumnName("SSM")
                    .HasComment("SSM");

                entity.Property(e => e.Szc)
                    .HasMaxLength(30)
                    .HasColumnName("SZC")
                    .HasComment("所在层");

                entity.Property(e => e.Szc2)
                    .HasColumnName("SZC2")
                    .HasComment("所在层2");

                entity.Property(e => e.Szdy)
                    .HasMaxLength(20)
                    .HasColumnName("SZDY")
                    .HasComment("所在单元");

                entity.Property(e => e.Tddymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDDYMJ");

                entity.Property(e => e.Tdftmj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTMJ");

                entity.Property(e => e.Tdftxs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTXS");

                entity.Property(e => e.Tdgymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDGYMJ");

                entity.Property(e => e.Tdyt)
                    .HasMaxLength(50)
                    .HasColumnName("TDYT");

                entity.Property(e => e.Zbh)
                    .HasColumnName("ZBH")
                    .HasComment("幢编号");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG")
                    .HasComment("房屋结构");

                entity.Property(e => e.Zjlbcyjs)
                    .HasColumnName("ZJLBCYJS")
                    .HasComment("只记录不参与计算");

                entity.Property(e => e.Zsmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ZSMJ")
                    .HasComment("自身面积");

                entity.Property(e => e.Zzrq)
                    .HasColumnType("date")
                    .HasColumnName("ZZRQ");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("--------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TcchShi分摊x>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_Shi_分摊X");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TcchZhuang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TCCH_Zhuang");

                entity.Property(e => e.Dscs)
                    .HasColumnName("DSCS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("地上层数");

                entity.Property(e => e.Dxcs)
                    .HasColumnName("DXCS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("地下层数");

                entity.Property(e => e.Ftlx)
                    .HasMaxLength(50)
                    .HasColumnName("FTLX")
                    .HasComment("分摊类型(无分摊\\一次分摊\\多次分摊)");

                entity.Property(e => e.Fwcb)
                    .HasMaxLength(50)
                    .HasColumnName("FWCB")
                    .HasComment("房屋产别");

                entity.Property(e => e.Gazh)
                    .HasMaxLength(20)
                    .HasColumnName("GAZH")
                    .HasComment("公安幢号");

                entity.Property(e => e.IsDelete)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否删除");

                entity.Property(e => e.IsSendReg)
                    .HasDefaultValueSql("((0))")
                    .HasComment("是否提交登记");

                entity.Property(e => e.Jgrq)
                    .HasMaxLength(20)
                    .HasColumnName("JGRQ")
                    .HasComment("竣工日期");

                entity.Property(e => e.OldItemId)
                    .HasMaxLength(20)
                    .HasComment("旧项目编号");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(50)
                    .HasColumnName("SGZH");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT")
                    .HasComment("设计用途");

                entity.Property(e => e.Zbh)
                    .HasColumnName("ZBH")
                    .HasComment("幢编号");

                entity.Property(e => e.ZbhDj)
                    .HasColumnName("ZBH_DJ")
                    .HasComment("旧登记ID");

                entity.Property(e => e.ZbhNew)
                    .HasColumnName("ZBH_NEW")
                    .HasComment("合并后幢编号 旧登记ID为空时用ZBH");

                entity.Property(e => e.Zid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ZId");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG")
                    .HasComment("幢结构");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("-------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test");

                entity.Property(e => e.Objectid).HasColumnName("objectid");
            });

            modelBuilder.Entity<UtExtImagePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_ExtImagePath");

                entity.Property(e => e.ExtName).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath).HasMaxLength(100);

                entity.Property(e => e.ManageUnit).HasMaxLength(500);

                entity.Property(e => e.Xfilepath)
                    .HasMaxLength(500)
                    .HasColumnName("XFilepath");
            });

            modelBuilder.Entity<VmTcchShi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VM_TCCH_Shi");

                entity.Property(e => e.Cqmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CQMJ");

                entity.Property(e => e.Fczl)
                    .HasMaxLength(250)
                    .HasColumnName("FCZL");

                entity.Property(e => e.Ftjd)
                    .HasMaxLength(50)
                    .HasColumnName("FTJD");

                entity.Property(e => e.Ftmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTMJ");

                entity.Property(e => e.Ftxs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTXS");

                entity.Property(e => e.Mjfl)
                    .HasMaxLength(20)
                    .HasColumnName("MJFL");

                entity.Property(e => e.OldSlbh).HasColumnName("OldSLBH");

                entity.Property(e => e.Qmjyb)
                    .HasMaxLength(50)
                    .HasColumnName("QMJYB");

                entity.Property(e => e.Rzsfhg)
                    .HasMaxLength(20)
                    .HasColumnName("RZSFHG");

                entity.Property(e => e.Sbh).HasColumnName("SBH");

                entity.Property(e => e.SbhDj).HasColumnName("SBH_DJ");

                entity.Property(e => e.SbhNew).HasColumnName("SBH_NEW");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH");

                entity.Property(e => e.Sh)
                    .HasMaxLength(20)
                    .HasColumnName("SH");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT");

                entity.Property(e => e.Sm)
                    .HasMaxLength(20)
                    .HasColumnName("SM");

                entity.Property(e => e.Ssm).HasColumnName("SSM");

                entity.Property(e => e.Szc)
                    .HasMaxLength(30)
                    .HasColumnName("SZC");

                entity.Property(e => e.Szc2).HasColumnName("SZC2");

                entity.Property(e => e.SzcE)
                    .HasMaxLength(101)
                    .HasColumnName("SZC_E");

                entity.Property(e => e.SzcS)
                    .HasMaxLength(101)
                    .HasColumnName("SZC_S");

                entity.Property(e => e.Szdy)
                    .HasMaxLength(20)
                    .HasColumnName("SZDY");

                entity.Property(e => e.Tddymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDDYMJ");

                entity.Property(e => e.Tdftmj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTMJ");

                entity.Property(e => e.Tdftxs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTXS");

                entity.Property(e => e.Tdgymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDGYMJ");

                entity.Property(e => e.Tdyt)
                    .HasMaxLength(50)
                    .HasColumnName("TDYT");

                entity.Property(e => e.Zbh).HasColumnName("ZBH");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG");

                entity.Property(e => e.Zjlbcyjs).HasColumnName("ZJLBCYJS");

                entity.Property(e => e.Zsjyt)
                    .HasMaxLength(20)
                    .HasColumnName("ZSJYT");

                entity.Property(e => e.Zsmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ZSMJ");

                entity.Property(e => e.Zzjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZZJG");

                entity.Property(e => e.Zzrq)
                    .HasColumnType("date")
                    .HasColumnName("ZZRQ");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("--------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VmTcchShiNoDesid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VM_TCCH_Shi_NoDESID");

                entity.Property(e => e.Cqmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CQMJ");

                entity.Property(e => e.Fczl)
                    .HasMaxLength(250)
                    .HasColumnName("FCZL");

                entity.Property(e => e.Ftjd)
                    .HasMaxLength(50)
                    .HasColumnName("FTJD");

                entity.Property(e => e.Ftmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTMJ");

                entity.Property(e => e.Ftxs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTXS");

                entity.Property(e => e.Mjfl)
                    .HasMaxLength(20)
                    .HasColumnName("MJFL");

                entity.Property(e => e.OldSlbh).HasColumnName("OldSLBH");

                entity.Property(e => e.Qmjyb)
                    .HasMaxLength(50)
                    .HasColumnName("QMJYB");

                entity.Property(e => e.Rzsfhg)
                    .HasMaxLength(20)
                    .HasColumnName("RZSFHG");

                entity.Property(e => e.Sbh).HasColumnName("SBH");

                entity.Property(e => e.SbhDj).HasColumnName("SBH_DJ");

                entity.Property(e => e.SbhNew).HasColumnName("SBH_NEW");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH");

                entity.Property(e => e.Sh)
                    .HasMaxLength(20)
                    .HasColumnName("SH");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT");

                entity.Property(e => e.Sm)
                    .HasMaxLength(20)
                    .HasColumnName("SM");

                entity.Property(e => e.Ssm).HasColumnName("SSM");

                entity.Property(e => e.Szc)
                    .HasMaxLength(30)
                    .HasColumnName("SZC");

                entity.Property(e => e.Szc2).HasColumnName("SZC2");

                entity.Property(e => e.SzcE)
                    .HasMaxLength(101)
                    .HasColumnName("SZC_E");

                entity.Property(e => e.SzcS)
                    .HasMaxLength(101)
                    .HasColumnName("SZC_S");

                entity.Property(e => e.Szdy)
                    .HasMaxLength(20)
                    .HasColumnName("SZDY");

                entity.Property(e => e.Tddymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDDYMJ");

                entity.Property(e => e.Tdftmj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTMJ");

                entity.Property(e => e.Tdftxs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTXS");

                entity.Property(e => e.Tdgymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDGYMJ");

                entity.Property(e => e.Tdyt)
                    .HasMaxLength(50)
                    .HasColumnName("TDYT");

                entity.Property(e => e.Zbh).HasColumnName("ZBH");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG");

                entity.Property(e => e.Zjlbcyjs).HasColumnName("ZJLBCYJS");

                entity.Property(e => e.Zsjyt)
                    .HasMaxLength(20)
                    .HasColumnName("ZSJYT");

                entity.Property(e => e.Zsmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ZSMJ");

                entity.Property(e => e.Zzjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZZJG");

                entity.Property(e => e.Zzrq)
                    .HasColumnType("date")
                    .HasColumnName("ZZRQ");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("--------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VmTcchShiSendRemote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VM_TCCH_Shi_SendRemote");

                entity.Property(e => e.Cgbh)
                    .HasMaxLength(20)
                    .HasColumnName("CGBH");

                entity.Property(e => e.Cqmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("CQMJ");

                entity.Property(e => e.Fcqsz)
                    .HasMaxLength(50)
                    .HasColumnName("FCQSZ");

                entity.Property(e => e.Fczl)
                    .HasMaxLength(250)
                    .HasColumnName("FCZL");

                entity.Property(e => e.Ftjd)
                    .HasMaxLength(50)
                    .HasColumnName("FTJD");

                entity.Property(e => e.Ftmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTMJ");

                entity.Property(e => e.Ftxs)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("FTXS");

                entity.Property(e => e.Kfszjh)
                    .HasMaxLength(200)
                    .HasColumnName("KFSZJH");

                entity.Property(e => e.Mjfl)
                    .HasMaxLength(20)
                    .HasColumnName("MJFL");

                entity.Property(e => e.OldSlbh).HasColumnName("OldSLBH");

                entity.Property(e => e.Qh)
                    .HasMaxLength(50)
                    .HasColumnName("QH");

                entity.Property(e => e.Qmjyb)
                    .HasMaxLength(50)
                    .HasColumnName("QMJYB");

                entity.Property(e => e.Rzsfhg)
                    .HasMaxLength(20)
                    .HasColumnName("RZSFHG");

                entity.Property(e => e.Sbh).HasColumnName("SBH");

                entity.Property(e => e.SbhDj).HasColumnName("SBH_DJ");

                entity.Property(e => e.SbhNew).HasColumnName("SBH_NEW");

                entity.Property(e => e.Sfyc).HasColumnName("SFYC");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(20)
                    .HasColumnName("SGZH");

                entity.Property(e => e.Sh)
                    .HasMaxLength(20)
                    .HasColumnName("SH");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT");

                entity.Property(e => e.Slbh).HasColumnName("SLBH");

                entity.Property(e => e.Sm)
                    .HasMaxLength(20)
                    .HasColumnName("SM");

                entity.Property(e => e.Ssm).HasColumnName("SSM");

                entity.Property(e => e.Szc)
                    .HasMaxLength(30)
                    .HasColumnName("SZC");

                entity.Property(e => e.Szc2).HasColumnName("SZC2");

                entity.Property(e => e.SzcS)
                    .HasMaxLength(101)
                    .HasColumnName("SZC_S");

                entity.Property(e => e.Szdy)
                    .HasMaxLength(20)
                    .HasColumnName("SZDY");

                entity.Property(e => e.Tddymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDDYMJ");

                entity.Property(e => e.Tdftmj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTMJ");

                entity.Property(e => e.Tdftxs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDFTXS");

                entity.Property(e => e.Tdgymj)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TDGYMJ");

                entity.Property(e => e.Tdyt)
                    .HasMaxLength(50)
                    .HasColumnName("TDYT");

                entity.Property(e => e.Wlcs).HasColumnName("WLCS");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(250)
                    .HasColumnName("XMMC");

                entity.Property(e => e.Zbh).HasColumnName("ZBH");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG");

                entity.Property(e => e.Zjlbcyjs).HasColumnName("ZJLBCYJS");

                entity.Property(e => e.Zsjyt)
                    .HasMaxLength(20)
                    .HasColumnName("ZSJYT");

                entity.Property(e => e.Zsmj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ZSMJ");

                entity.Property(e => e.Zzjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZZJG");

                entity.Property(e => e.Zzrq)
                    .HasColumnType("date")
                    .HasColumnName("ZZRQ");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("--------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VmTcchZhuang>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VM_TCCH_Zhuang");

                entity.Property(e => e.Cgbh)
                    .HasMaxLength(20)
                    .HasColumnName("CGBH");

                entity.Property(e => e.ChlxDj)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CHLX_DJ");

                entity.Property(e => e.Dscs).HasColumnName("DSCS");

                entity.Property(e => e.Dxcs).HasColumnName("DXCS");

                entity.Property(e => e.Fcqsz)
                    .HasMaxLength(50)
                    .HasColumnName("FCQSZ");

                entity.Property(e => e.Fczl)
                    .HasMaxLength(250)
                    .HasColumnName("FCZL");

                entity.Property(e => e.Ftlx)
                    .HasMaxLength(50)
                    .HasColumnName("FTLX");

                entity.Property(e => e.Fwcb)
                    .HasMaxLength(50)
                    .HasColumnName("FWCB");

                entity.Property(e => e.Gazh)
                    .HasMaxLength(20)
                    .HasColumnName("GAZH");

                entity.Property(e => e.Jgrq)
                    .HasMaxLength(20)
                    .HasColumnName("JGRQ");

                entity.Property(e => e.OldItemId).HasMaxLength(20);

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(50)
                    .HasColumnName("SGZH");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT");

                entity.Property(e => e.Slbh).HasColumnName("SLBH");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(250)
                    .HasColumnName("XMMC");

                entity.Property(e => e.Zbh).HasColumnName("ZBH");

                entity.Property(e => e.ZbhDj).HasColumnName("ZBH_DJ");

                entity.Property(e => e.ZbhNew).HasColumnName("ZBH_NEW");

                entity.Property(e => e.Zid).HasColumnName("ZId");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("-------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VmTcchZhuangSendRemote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VM_TCCH_Zhuang_SendRemote");

                entity.Property(e => e.Cgbh)
                    .HasMaxLength(20)
                    .HasColumnName("CGBH");

                entity.Property(e => e.Dscs).HasColumnName("DSCS");

                entity.Property(e => e.Dxcs).HasColumnName("DXCS");

                entity.Property(e => e.Fcqsz)
                    .HasMaxLength(50)
                    .HasColumnName("FCQSZ");

                entity.Property(e => e.Fczl)
                    .HasMaxLength(250)
                    .HasColumnName("FCZL");

                entity.Property(e => e.Ftlx)
                    .HasMaxLength(50)
                    .HasColumnName("FTLX");

                entity.Property(e => e.Fwcb)
                    .HasMaxLength(50)
                    .HasColumnName("FWCB");

                entity.Property(e => e.Gazh)
                    .HasMaxLength(20)
                    .HasColumnName("GAZH");

                entity.Property(e => e.Jgrq)
                    .HasMaxLength(20)
                    .HasColumnName("JGRQ");

                entity.Property(e => e.Jzmj)
                    .HasColumnType("decimal(38, 4)")
                    .HasColumnName("JZMJ");

                entity.Property(e => e.Kfszjh)
                    .HasMaxLength(200)
                    .HasColumnName("KFSZJH");

                entity.Property(e => e.OldItemId).HasMaxLength(20);

                entity.Property(e => e.Qh)
                    .HasMaxLength(50)
                    .HasColumnName("QH");

                entity.Property(e => e.Sfyc).HasColumnName("SFYC");

                entity.Property(e => e.Sgzh)
                    .HasMaxLength(50)
                    .HasColumnName("SGZH");

                entity.Property(e => e.Sjyt)
                    .HasMaxLength(20)
                    .HasColumnName("SJYT");

                entity.Property(e => e.Slbh).HasColumnName("SLBH");

                entity.Property(e => e.Xmmc)
                    .HasMaxLength(250)
                    .HasColumnName("XMMC");

                entity.Property(e => e.Yccgbh)
                    .HasMaxLength(20)
                    .HasColumnName("YCCGBH");

                entity.Property(e => e.Zbh).HasColumnName("ZBH");

                entity.Property(e => e.ZbhDj).HasColumnName("ZBH_DJ");

                entity.Property(e => e.ZbhNew).HasColumnName("ZBH_NEW");

                entity.Property(e => e.Zid).HasColumnName("ZId");

                entity.Property(e => e.Zjg)
                    .HasMaxLength(20)
                    .HasColumnName("ZJG");

                entity.Property(e => e._)
                    .HasMaxLength(10)
                    .HasColumnName("-------")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Vm室导出>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VM_室导出");

                entity.Property(e => e.丘号).HasMaxLength(20);

                entity.Property(e => e.东墙).HasMaxLength(100);

                entity.Property(e => e.共有部位名称).HasMaxLength(100);

                entity.Property(e => e.分区号).HasMaxLength(20);

                entity.Property(e => e.分户图信息).HasColumnType("image");

                entity.Property(e => e.分户图文件名).HasMaxLength(200);

                entity.Property(e => e.分户图比例).HasMaxLength(50);

                entity.Property(e => e.分摊系数).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.北墙).HasMaxLength(100);

                entity.Property(e => e.区号).HasMaxLength(20);

                entity.Property(e => e.单元).HasMaxLength(50);

                entity.Property(e => e.南墙).HasMaxLength(100);

                entity.Property(e => e.图号).HasMaxLength(20);

                entity.Property(e => e.坐落).HasMaxLength(100);

                entity.Property(e => e.备案状态).HasMaxLength(50);

                entity.Property(e => e.层次).HasMaxLength(20);

                entity.Property(e => e.层编号).HasMaxLength(20);

                entity.Property(e => e.幢号).HasMaxLength(80);

                entity.Property(e => e.建成年份).HasMaxLength(20);

                entity.Property(e => e.建筑质量).HasMaxLength(20);

                entity.Property(e => e.总层数).HasMaxLength(20);

                entity.Property(e => e.户型).HasMaxLength(20);

                entity.Property(e => e.房号).HasMaxLength(50);

                entity.Property(e => e.房号标识).HasMaxLength(50);

                entity.Property(e => e.房屋性质).HasMaxLength(50);

                entity.Property(e => e.房屋所属区).HasMaxLength(50);

                entity.Property(e => e.房间住宅面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_住宅面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间使用面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_使用面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间分摊面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_分摊面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间基底面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_基底面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间套内面积)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("房间_套内面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间建筑面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_建筑面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间用途).HasMaxLength(50);

                entity.Property(e => e.房间部分产权面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_部分产权面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间阳台面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_阳台面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.房间非住宅面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_非住宅面积")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.所有权人).HasMaxLength(150);

                entity.Property(e => e.抵押剩余面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.抵押状态).HasMaxLength(50);

                entity.Property(e => e.旧产籍号).HasMaxLength(60);

                entity.Property(e => e.权证幢号).HasMaxLength(20);

                entity.Property(e => e.村).HasMaxLength(50);

                entity.Property(e => e.查封状态).HasMaxLength(50);

                entity.Property(e => e.特别号).HasMaxLength(20);

                entity.Property(e => e.登记状态).HasMaxLength(50);

                entity.Property(e => e.租赁状态).HasMaxLength(50);

                entity.Property(e => e.结构).HasMaxLength(20);

                entity.Property(e => e.街).HasMaxLength(50);

                entity.Property(e => e.西墙).HasMaxLength(100);

                entity.Property(e => e.设计用途).HasMaxLength(50);

                entity.Property(e => e.调查员).HasMaxLength(20);

                entity.Property(e => e.调查日期).HasColumnType("datetime");

                entity.Property(e => e.附属于).HasMaxLength(50);

                entity.Property(e => e.附属房).HasMaxLength(50);

                entity.Property(e => e.附房类型).HasMaxLength(50);
            });

            modelBuilder.Entity<受理表>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("受理表");

                entity.Property(e => e.业务类别).HasMaxLength(20);

                entity.Property(e => e.受理日期).HasMaxLength(250);

                entity.Property(e => e.受理编号).HasMaxLength(20);

                entity.Property(e => e.测绘公司).HasMaxLength(250);

                entity.Property(e => e.测绘成果编号).HasMaxLength(20);

                entity.Property(e => e.环节Id)
                    .HasMaxLength(20)
                    .HasColumnName("环节_ID");

                entity.Property(e => e.申请人一).HasMaxLength(250);

                entity.Property(e => e.申请人一证件名称).HasMaxLength(250);

                entity.Property(e => e.登记面积).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.项目名称).HasMaxLength(250);
            });

            modelBuilder.Entity<旧室数据>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("旧室数据");

                entity.Property(e => e.分摊系数).HasMaxLength(50);

                entity.Property(e => e.受理编号).HasMaxLength(50);

                entity.Property(e => e.层次).HasMaxLength(50);

                entity.Property(e => e.幢号).HasMaxLength(50);

                entity.Property(e => e.幢编号).HasMaxLength(50);

                entity.Property(e => e.房号).HasMaxLength(50);

                entity.Property(e => e.房号标识).HasMaxLength(50);

                entity.Property(e => e.房间分摊面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_分摊面积");

                entity.Property(e => e.房间套内面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_套内面积");

                entity.Property(e => e.房间建筑面积)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("房间_建筑面积");

                entity.Property(e => e.房间用途).HasMaxLength(50);

                entity.Property(e => e.房间编号).HasMaxLength(50);

                entity.Property(e => e.特别号).HasMaxLength(50);

                entity.Property(e => e.结构).HasMaxLength(50);
            });

            modelBuilder.Entity<旧幢数据>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("旧幢数据");

                entity.Property(e => e.产权单位).HasMaxLength(50);

                entity.Property(e => e.产权来源).HasMaxLength(50);

                entity.Property(e => e.使用面积).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.共有面积).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.分摊系数).HasMaxLength(50);

                entity.Property(e => e.受理编号).HasMaxLength(50);

                entity.Property(e => e.坐落).HasMaxLength(250);

                entity.Property(e => e.层数).HasMaxLength(50);

                entity.Property(e => e.幢号).HasMaxLength(50);

                entity.Property(e => e.幢编号).HasMaxLength(50);

                entity.Property(e => e.建筑结构).HasMaxLength(50);

                entity.Property(e => e.建筑面积).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.房屋所属区).HasMaxLength(250);

                entity.Property(e => e.房屋用途).HasMaxLength(50);

                entity.Property(e => e.权证幢号).HasMaxLength(50);

                entity.Property(e => e.特别号).HasMaxLength(50);

                entity.Property(e => e.竣工日期).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

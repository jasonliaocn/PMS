using System.Data.Entity;

namespace PMS.Models
{
    public class PMSDBContext : DbContext
    {
        // 您可以向此文件中添加自定义代码。更改不会被覆盖。
        // 
        // 如果您希望只要更改模型架构，Entity Framework
        // 就会自动删除并重新生成数据库，则将以下
        // 代码添加到 Global.asax 文件中的 Application_Start 方法。
        // 注意: 这将在每次更改模型时销毁并重新创建数据库。
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<PMS.Models.PMSDBContext>());

        public PMSDBContext() : base("name=PMSDBContext")
        {
        }

        public DbSet<ProjectModels> ProjectModels { get; set; }

        public DbSet<TaskModels> TaskModels { get; set; }

        public DbSet<EAinfoModels> EAinfoModels { get; set; }

        public DbSet<EaModels> EaModels { get; set; }

        public DbSet<IitemModels> IitemModels { get; set; }

        public DbSet<IncomeModels> IncomeModels { get; set; }

        public DbSet<MaterialDTLModels> MaterialDTLModels { get; set; }

        public DbSet<MaterialModels> MaterialModels { get; set; }

        public DbSet<Norm2Models> Norm2Models { get; set; }

        public DbSet<NormModels> NormModels { get; set; }

        public DbSet<TemplateModels> TemplateModels { get; set; }

        public DbSet<UnitModels> UnitModels { get; set; }

    }
}

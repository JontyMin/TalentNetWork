namespace TalentNetWork.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbhrm : DbContext
    {
        public dbhrm()
            : base("name=dbhrm")
        {
        }

        public virtual DbSet<Award> Award { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Hobbies> Hobbies { get; set; }
        public virtual DbSet<InternshipExp> InternshipExp { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Mailing> Mailing { get; set; }
        public virtual DbSet<ProjectExp> ProjectExp { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<V_Job> V_Job { get; set; }
        public virtual DbSet<V_JobInfo> V_JobInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Award>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Certificate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Hobbies>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hobbies>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<InternshipExp>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<InternshipExp>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.SalaryNegotiable)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.LowestSalaryUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.WorkingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.FunctionLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Descriptions)
                .IsUnicode(false);

            modelBuilder.Entity<ProjectExp>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ProjectExp>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.HeadImage)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.NativePlace)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.WeiXin)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.WeiBo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Qualifications)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.GraduateSchool)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Specialty)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Intension)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ExpectationSalary)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Evaluation)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.SalaryNegotiable)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.LowestSalaryUnit)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.WorkingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.FunctionLevel)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.CompanyIcon)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.NatureStr)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.SalaryStr)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<V_Job>()
                .Property(e => e.EndDateStr)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.SalaryNegotiable)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.LowestSalaryUnit)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.WorkingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.FunctionLevel)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.Descriptions)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.CompanyIcon)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.NatureStr)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.SalaryStr)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<V_JobInfo>()
                .Property(e => e.EndDateStr)
                .IsUnicode(false);
        }
    }
}

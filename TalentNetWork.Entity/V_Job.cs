namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Job
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? CompanyID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? Nature { get; set; }

        [StringLength(50)]
        public string SalaryNegotiable { get; set; }

        [StringLength(50)]
        public string LowestSalaryUnit { get; set; }

        public int? LowestSalary { get; set; }

        public int? HighestSalary { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string WorkingPlace { get; set; }

        [StringLength(50)]
        public string Rank { get; set; }

        [StringLength(50)]
        public string FunctionLevel { get; set; }

        public int? Hits { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CompanyIcon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string NatureStr { get; set; }

        [StringLength(50)]
        public string SalaryStr { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(10)]
        public string EndDateStr { get; set; }
    }
}

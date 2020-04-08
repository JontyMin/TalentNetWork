namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
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

        [Column(TypeName = "text")]
        public string Descriptions { get; set; }

        public int? Hits { get; set; }
    }
}

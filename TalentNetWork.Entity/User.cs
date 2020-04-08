namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string HeadImage { get; set; }

        [StringLength(4)]
        public string Sex { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string NativePlace { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(11)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string WeiXin { get; set; }

        [StringLength(50)]
        public string WeiBo { get; set; }

        [StringLength(50)]
        public string Qualifications { get; set; }

        [StringLength(50)]
        public string GraduateSchool { get; set; }

        [StringLength(50)]
        public string Specialty { get; set; }

        [StringLength(50)]
        public string Intension { get; set; }

        [StringLength(50)]
        public string ExpectationSalary { get; set; }

        [StringLength(50)]
        public string Evaluation { get; set; }

        public int? CategoryID { get; set; }
    }
}

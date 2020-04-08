namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InternshipExp")]
    public partial class InternshipExp
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public DateTime? Time { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int? SortNumber { get; set; }
    }
}

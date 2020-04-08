namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Award")]
    public partial class Award
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int? SortNumber { get; set; }
    }
}

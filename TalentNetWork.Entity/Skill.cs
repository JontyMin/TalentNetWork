namespace TalentNetWork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Skill")]
    public partial class Skill
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Percent { get; set; }

        public int? SortNumber { get; set; }
    }
}

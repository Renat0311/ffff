namespace gggg.ModelBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Construcrions
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [StringLength(50)]
        public string CLIENT { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }
    }
}

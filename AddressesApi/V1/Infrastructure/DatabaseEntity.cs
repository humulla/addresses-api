using Amazon.DynamoDBv2.DataModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseApi.V1.Infrastructure
{

    [Table("table")]
    public class DatabaseEntity
    {
        [Column("postcode")]
        [Required]
        public string Postcode { get; set; }

        [Column("line1")]
        public string Line1 { get; set; }

        [Column("line2")]
        public string Line2 { get; set; }

        [Column("line3")]
        public string Line3 { get; set; }

        [Column("line4")]
        public string Line4 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dapper.Models
{
    public class Partner
    {

        [Key]
        [Column("PartnerTypeId")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Partner Type ID")]
        public virtual int PartnerTypeId { get; set; }


        [Column("FirstName")]
        [Required]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }


        [Column("LastName")]
        [Required]
        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }


        [Column("Address")]
        [Required]
        [Display(Name = "Address")]
        public virtual string Address { get; set; }

        [Column("PartnerNumber")]
        [Required]
        [Display(Name = "Partner Number")]
        public virtual int PartnerNumber { get; set; }


        [Column("CroatianPIN")]
        [Required]
        [Display(Name = "Croatian PIN")]
        public virtual int CroatianPIN { get; set; }


        [Column("CreatedAtUtc")]
        [Required]
        [Display(Name = "Created At Utc")]
        public virtual DateTime CreatedAtUtc { get; set; }


        [Column("CreateByUser")]
        [Required]
        [Display(Name = "Create By User")]
        public virtual string CreateByUser { get; set; }

        [Column("IsForeign")]
        [Required]
        [Display(Name = "Is Foreign")]
        public virtual bool IsForeign { get; set; }


        [Column("ExternalCode")]
        [Required]
        [Display(Name = "External Code")]
        public virtual string ExternalCode { get; set; }

        [Column("Gender")]
        [Required]
        [Display(Name = "Gender")]
        public virtual string Gender { get; set; }
    }
}



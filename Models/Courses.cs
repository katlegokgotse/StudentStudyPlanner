using StudentPlanner.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlanner.Models
{
    public class Courses
    {
        [Key] 
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Code { set; get; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Name { set; get; }
        [Column(TypeName = "smallint")]
        public int NumberOfCredits { set; get; }

        [Column(TypeName = "smallint")]
        public int NumberOfHours { set; get; }

        [Column(TypeName = "smallint")]
        public int NumOfWeeks { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SemesterStart { set; get; }

        public virtual ApplicationUser? ApplicationUser { get; set; }

        public double CalcSelfStudyHours { get; set; }
        //public double calcSelfStudyHours(double classHrs, int numberOfCredits, int numberOfWeeks) => ((numberOfCredits * 10) / numberOfWeeks - classHrs);
    }
}
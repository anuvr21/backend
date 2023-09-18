using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class model2
    {
        [Key]
        public int PROVIDERID { get; set; }
        public string? LASTNAME { get; set; }

        public string? MIDDLEINITIAL { get; set; }
        public string? FIRSTNAME { get; set; }

        public string? TAXONOMYCODE1 { get; set; }

        public string? HPSPECIALITYCODE1 { get; set; }

        public string? PAYORID { get; set; }

        public string? CONTRACTED { get; set; }


    }
}
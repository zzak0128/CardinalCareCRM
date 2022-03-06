using System;
using System.ComponentModel.DataAnnotations;

namespace CardinalCare.Model
{
    public class VaccinationFile
    {
        [Key]
        public int VaccinationFileId { get; set; }
        [StringLength(100)]
        public string FileName { get; set; }
        public string FullFilePath { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
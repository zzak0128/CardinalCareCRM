using System;

namespace CardinalCare.Model
{
    public class VaccinationFile
    {
        public int VaccinationFileId { get; set; }
        public string FileName { get; set; }
        public string FullFilePath { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
namespace Service.Dtos
{
    public class JobDto
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public decimal Hours { get; set; }
        public string StarDate { get; set; }
        public string EndDate { get; set; }
        public string ConfirmationCode { get; set; }
        public string CRMProgramCode { get; set; }
        public string EmployeeId { get; set; }
    }
}
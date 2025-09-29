namespace RecruitmentTask.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int TeamId { get; set; }
        public Team? Team { get; set; }
        public int VacationPackageId { get; set; }
        public VacationPackage? VacationPackage { get; set; }
        public ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
    }
}

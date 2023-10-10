namespace AspMvcWebApplication.ViewModels.Employees
{
    public class IndexViewModel
    {
        public IEnumerable<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();

    }
}

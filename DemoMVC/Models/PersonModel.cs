namespace DemoMVC.Models
{
    public class PersonModel
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }

        public int Age => DateTime.Now.Year - BirthYear;
    }
}

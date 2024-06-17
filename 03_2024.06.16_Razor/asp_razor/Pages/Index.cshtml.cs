using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_razor.Pages
{
    public class IndexModel : PageModel
    {
        // начальные данные - список людей
        List<Person> students = new()
        {
            new Person ("Tom Smith", 23),
            new Person ("Sam Anderson", 23),
            new Person ("Bob Johnson", 25),
            new Person ("Tom Anderson", 25)
        };
        // отображаемые данные
        public List<Person> DisplayedPeople { get; set; } = new();

        public void OnGet()
        {
            DisplayedPeople = students;
        }

        public void OnGetByName(string name)
        {
            DisplayedPeople = students.Where(p => p.Name.Contains(name)).ToList();
        }
        public void OnGetByAge(int age)
        {
            DisplayedPeople = students.Where(p => p.Age == age).ToList();
        }
    }
    public record class Person(string Name, int Age);


}

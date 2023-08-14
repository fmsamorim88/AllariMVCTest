using SimpleMVC.Models;

namespace SimpleMVC.Services
{
	public class PersonService
	{
		public async Task<List<Person>> getPersons() {
            var p = new List<Person>
            {
                new Person { Id = 1, Name = "Jhon" },
                new Person { Id = 2, Name = "Mathew" },
                new Person { Id = 3, Name = "Ryan" },
                new Person { Id = 4, Name = "Steve" },
                new Person { Id = 5, Name = "Litle Richards" },
            };
            return await Task.FromResult(p);
        }
	}
}


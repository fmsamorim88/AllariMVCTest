using SimpleMVC.Models;

namespace SimpleMVC.Services
{
	public class PersonService
	{
		public async Task<List<Person>> getPersons() {
            var p = new List<Person>
            {
                new Person { Id = 1, Name = "Jhon" }
            };
            return await Task.FromResult(p);
        }
	}
}


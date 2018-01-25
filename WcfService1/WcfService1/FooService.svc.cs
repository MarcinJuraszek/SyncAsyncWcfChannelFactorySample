using System.Threading.Tasks;

namespace WcfService
{
    public class FooService : IFooService
    {
		public Task<string> GetBarAsync()
		{
			return Task.FromResult("Bar!");
		}

		public string GetFoo(int value)
        {
            return string.Format("You entered: {0}", value);
		}
	}
}

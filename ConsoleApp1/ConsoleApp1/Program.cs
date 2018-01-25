using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	[ServiceContract(Name = "IFooService")]
	public interface IFooServicePretender
	{
		[OperationContract]
		Task<string> GetFooAsync(int value);

		[OperationContract]
		string GetBar();
	}

	class Program
	{
		public static void Main(string[] args)
		{
			var factory = new ChannelFactory<IFooServicePretender>(new BasicHttpBinding());
			var channel = factory.CreateChannel(new EndpointAddress("http://localhost:51109/FooService.svc"));

			var fooResult = await channel.GetFooAsync(12345);
			var barResult = channel.GetBar();

			Console.WriteLine("GetFooAsync result: " + fooResult);
			Console.WriteLine("GetBar result: " + barResult);
		}
	}
}

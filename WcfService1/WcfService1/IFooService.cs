using System.ServiceModel;
using System.Threading.Tasks;

namespace WcfService
{
	[ServiceContract]
	public interface IFooService
	{
		[OperationContract]
		string GetFoo(int value);

		[OperationContract]
		Task<string> GetBarAsync();
	}
}

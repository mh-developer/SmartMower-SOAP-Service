using SmartMowerServiceLibrary;
using System.ServiceModel;

namespace Wcf_02
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Service1 : SmartMowerService
    {
    }
}
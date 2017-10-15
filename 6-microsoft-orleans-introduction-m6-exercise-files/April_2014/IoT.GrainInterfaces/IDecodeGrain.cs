using Orleans;
using System.Threading.Tasks;

namespace IoT.GrainInterfaces
{
    [StatelessWorker]
    public interface IDecodeGrain : IGrain
    {
        Task Decode(string message);
    }
}

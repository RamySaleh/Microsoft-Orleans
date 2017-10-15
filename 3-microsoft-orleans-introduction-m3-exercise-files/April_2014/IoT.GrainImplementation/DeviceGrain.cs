using IoT.GrainInterfaces;
using Orleans;
using System;
using System.Threading.Tasks;

namespace IoT.GrainImplementation
{

    public interface IDeviceGrainState : IGrainState
    {
        double LastValue { get; set; }
    }

    [StorageProvider(ProviderName = "AzureStore")]
    public class DeviceGrain : Orleans.GrainBase<IDeviceGrainState>, IDeviceGrain
    {
        public async Task SetTemperature(double value)
        {
            if (value > 100 && this.State.LastValue <= 100)
            {
                Console.WriteLine("It's hot! {0}", value);
            }
            if (value != this.State.LastValue)
            {
                Console.WriteLine("{0} -> {1}", this.State.LastValue, value);
                this.State.LastValue = value;
                await this.State.WriteStateAsync();
            }
        }
    }
}

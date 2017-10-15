using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using IoT.GrainInterfaces;

namespace IoT.GrainClasses
{
    /// <summary>
    /// Orleans grain implementation class Grain1.
    /// </summary>
    public class DeviceGrain : Orleans.GrainBase, IDeviceGrain
    {
        double lastValue;

        public override Task ActivateAsync()
        {
            var id = this.GetPrimaryKeyLong();
            Console.WriteLine("Activated {0}", id);
            return base.ActivateAsync();
        }

        public Task SetTemperature(double value)
        {
            if (lastValue < 100 && value >= 100)
            {
                Console.WriteLine("High temperature recorded {0}", value);
            }
            lastValue = value;
            return TaskDone.Done;
        }
    }
}

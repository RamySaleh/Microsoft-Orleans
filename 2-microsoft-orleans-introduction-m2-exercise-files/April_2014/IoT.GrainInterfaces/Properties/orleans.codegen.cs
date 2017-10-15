//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace IoT.GrainInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DeviceGrainFactory
    {
        

                        public static IDeviceGrain GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDeviceGrain), -1248350959, primaryKey));
                        }

                        public static IDeviceGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDeviceGrain), -1248350959, primaryKey, grainClassNamePrefix));
                        }

                        public static IDeviceGrain GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDeviceGrain), -1248350959, primaryKey));
                        }

                        public static IDeviceGrain GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDeviceGrain), -1248350959, primaryKey, grainClassNamePrefix));
                        }

            public static IDeviceGrain Cast(IAddressable grainRef)
            {
                
                return DeviceGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("IoT.GrainInterfaces.IDeviceGrain")]
        internal class DeviceGrainReference : Orleans.GrainReference, IDeviceGrain, Orleans.IAddressable
        {
            

            public static IDeviceGrain Cast(IAddressable grainRef)
            {
                
                return (IDeviceGrain) GrainReference.CastInternal(typeof(IDeviceGrain), (GrainReference gr) => { return new DeviceGrainReference(gr);}, grainRef, -1248350959);
            }

                protected override int InterfaceId { get { return -1248350959; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "IoT.GrainInterfaces.IDeviceGrain"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return DeviceGrainMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal DeviceGrainReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                return ((DeviceGrainReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DeviceGrainReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task SetTemperature(double value)
            {

                return base.InvokeMethodAsync<object>(-1788431855, new object[] {value}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("IoT.GrainInterfaces.IDeviceGrain", -1248350959)]
    internal class DeviceGrainMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return -1248350959;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1248350959:  // IDeviceGrain
                        switch (methodId)
                        {
                            case -1788431855: 
                                await ((IDeviceGrain)grain).SetTemperature((Double)arguments[0]);
                              return true;
                            default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1248350959:  // IDeviceGrain
                    switch (methodId)
                    {
                        case -1788431855:
                            return "SetTemperature";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DeviceGrainProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif

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
    using System.Reflection;
    using Orleans.Serialization;
    using IoT.GrainInterfaces;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DecodeGrainFactory
    {
        

                        public static IDecodeGrain GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDecodeGrain), 148814687, primaryKey));
                        }

                        public static IDecodeGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDecodeGrain), 148814687, primaryKey, grainClassNamePrefix));
                        }

                        public static IDecodeGrain GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDecodeGrain), 148814687, primaryKey));
                        }

                        public static IDecodeGrain GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IDecodeGrain), 148814687, primaryKey, grainClassNamePrefix));
                        }

            public static IDecodeGrain Cast(IAddressable grainRef)
            {
                
                return DecodeGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("IoT.GrainInterfaces.IDecodeGrain")]
        internal class DecodeGrainReference : Orleans.GrainReference, IDecodeGrain, Orleans.IAddressable
        {
            

            public static IDecodeGrain Cast(IAddressable grainRef)
            {
                
                return (IDecodeGrain) GrainReference.CastInternal(typeof(IDecodeGrain), (GrainReference gr) => { return new DecodeGrainReference(gr);}, grainRef, 148814687);
            }

                protected override int InterfaceId { get { return 148814687; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "IoT.GrainInterfaces.IDecodeGrain"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return DecodeGrainMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal DecodeGrainReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DecodeGrainReference input = ((DecodeGrainReference)(original));
                return ((DecodeGrainReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DecodeGrainReference input = ((DecodeGrainReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DecodeGrainReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task Decode(string message)
            {

                return base.InvokeMethodAsync<object>(1114664117, new object[] {message}, TimeSpan.Zero , options:  InvokeMethodOptions.Unordered);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("IoT.GrainInterfaces.IDecodeGrain", 148814687)]
    internal class DecodeGrainMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return 148814687;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 148814687:  // IDecodeGrain
                        switch (methodId)
                        {
                            case 1114664117: 
                                await ((IDecodeGrain)grain).Decode((String)arguments[0]);
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
                
                case 148814687:  // IDecodeGrain
                    switch (methodId)
                    {
                        case 1114664117:
                            return "Decode";
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
    public class DecodeGrainProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
    
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
            
            public System.Threading.Tasks.Task JoinSystem(string name)
            {

                return base.InvokeMethodAsync<object>(-1555867497, new object[] {name}, TimeSpan.Zero );
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
                            case -1555867497: 
                                await ((IDeviceGrain)grain).JoinSystem((String)arguments[0]);
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
                    case -1555867497:
                            return "JoinSystem";
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SystemGrainFactory
    {
        

                        public static ISystemGrain GetGrain(long primaryKey, string keyExt)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(ISystemGrain), 1021785371, primaryKey, keyExt));
                        }

                        public static ISystemGrain GetGrain(long primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(ISystemGrain), 1021785371, primaryKey, keyExt, grainClassNamePrefix));
                        }

                        public static ISystemGrain GetGrain(Guid primaryKey, string keyExt)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(ISystemGrain), 1021785371, primaryKey, keyExt));
                        }

                        public static ISystemGrain GetGrain(Guid primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(ISystemGrain), 1021785371, primaryKey, keyExt,grainClassNamePrefix));
                        }

            public static ISystemGrain Cast(IAddressable grainRef)
            {
                
                return SystemGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("IoT.GrainInterfaces.ISystemGrain")]
        internal class SystemGrainReference : Orleans.GrainReference, ISystemGrain, Orleans.IAddressable
        {
            

            public static ISystemGrain Cast(IAddressable grainRef)
            {
                
                return (ISystemGrain) GrainReference.CastInternal(typeof(ISystemGrain), (GrainReference gr) => { return new SystemGrainReference(gr);}, grainRef, 1021785371);
            }

                protected override int InterfaceId { get { return 1021785371; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "IoT.GrainInterfaces.ISystemGrain"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return SystemGrainMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal SystemGrainReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                SystemGrainReference input = ((SystemGrainReference)(original));
                return ((SystemGrainReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                SystemGrainReference input = ((SystemGrainReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return SystemGrainReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task SetTemperature(IoT.GrainInterfaces.TemperatureReading reading)
            {

                return base.InvokeMethodAsync<object>(997261292, new object[] {reading}, TimeSpan.Zero );
            }
            
            public System.Threading.Tasks.Task Subscribe(IoT.GrainInterfaces.ISystemObserver observer)
            {
GrainFactoryBase.CheckGrainObserverParamInternal(observer);

                return base.InvokeMethodAsync<object>(987286981, new object[] {observer is GrainBase ? IoT.GrainInterfaces.SystemObserverFactory.Cast(observer.AsReference()) : observer}, TimeSpan.Zero );
            }
            
            public System.Threading.Tasks.Task Unsubscribe(IoT.GrainInterfaces.ISystemObserver observer)
            {
GrainFactoryBase.CheckGrainObserverParamInternal(observer);

                return base.InvokeMethodAsync<object>(-1645784438, new object[] {observer is GrainBase ? IoT.GrainInterfaces.SystemObserverFactory.Cast(observer.AsReference()) : observer}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("IoT.GrainInterfaces.ISystemGrain", 1021785371)]
    internal class SystemGrainMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return 1021785371;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1021785371:  // ISystemGrain
                        switch (methodId)
                        {
                            case 997261292: 
                                await ((ISystemGrain)grain).SetTemperature((TemperatureReading)arguments[0]);
                              return true;
                            case 987286981: 
                                await ((ISystemGrain)grain).Subscribe((ISystemObserver)arguments[0]);
                              return true;
                            case -1645784438: 
                                await ((ISystemGrain)grain).Unsubscribe((ISystemObserver)arguments[0]);
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
                
                case 1021785371:  // ISystemGrain
                    switch (methodId)
                    {
                        case 997261292:
                            return "SetTemperature";
                    case 987286981:
                            return "Subscribe";
                    case -1645784438:
                            return "Unsubscribe";
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
    public class SystemGrainProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SystemObserverFactory
    {
        

            public static ISystemObserver Cast(IAddressable grainRef)
            {
                
                return SystemObserverReference.Cast(grainRef);
            }

        private static IGrainMethodInvoker methodInvoker;

        public async static System.Threading.Tasks.Task<ISystemObserver> CreateObjectReference(ISystemObserver obj)
        {
            if (methodInvoker == null) methodInvoker = new SystemObserverMethodInvoker();
            return SystemObserverFactory.Cast(await GrainReference.CreateObjectReference(obj, methodInvoker));
        }

        public static void DeleteObjectReference(ISystemObserver reference)
        {
            GrainReference.DeleteObjectReference(reference);
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("IoT.GrainInterfaces.ISystemObserver")]
        internal class SystemObserverReference : Orleans.GrainReference, ISystemObserver, Orleans.IAddressable
        {
            

            public static ISystemObserver Cast(IAddressable grainRef)
            {
                
                return (ISystemObserver) GrainReference.CastInternal(typeof(ISystemObserver), (GrainReference gr) => { return new SystemObserverReference(gr);}, grainRef, -1413064308);
            }

                protected override int InterfaceId { get { return -1413064308; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "IoT.GrainInterfaces.ISystemObserver"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return SystemObserverMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal SystemObserverReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                SystemObserverReference input = ((SystemObserverReference)(original));
                return ((SystemObserverReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                SystemObserverReference input = ((SystemObserverReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return SystemObserverReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public void HighTemperature(double value)
            {

                base.InvokeOneWayMethod(-2130055570, new object[] {value} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("IoT.GrainInterfaces.ISystemObserver", -1413064308)]
    internal class SystemObserverMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return -1413064308;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1413064308:  // ISystemObserver
                        switch (methodId)
                        {
                            case -2130055570: 
                                ((ISystemObserver)grain).HighTemperature((Double)arguments[0]); return true;
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
                
                case -1413064308:  // ISystemObserver
                    switch (methodId)
                    {
                        case -2130055570:
                            return "HighTemperature";
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
    public class SystemObserverProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
    
    [Orleans.RegisterSerializerAttribute()]
    internal class IoT_GrainInterfaces_TemperatureReadingSerialization
    {
        
        static IoT_GrainInterfaces_TemperatureReadingSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            return original;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            IoT.GrainInterfaces.TemperatureReading input = ((IoT.GrainInterfaces.TemperatureReading)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.DeviceId, stream, typeof(Int64));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Time, stream, typeof(DateTime));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Value, stream, typeof(Double));
        }
        
        public static object Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            IoT.GrainInterfaces.TemperatureReading result = new IoT.GrainInterfaces.TemperatureReading();
            result.DeviceId = ((Int64)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Int64), stream)));
            result.Time = ((DateTime)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(DateTime), stream)));
            result.Value = ((Double)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Double), stream)));
            return result;
        }
        
        public static void Register()
        {
            Orleans.Serialization.SerializationManager.Register(typeof(IoT.GrainInterfaces.TemperatureReading), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif

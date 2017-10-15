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
    using System.Reflection;
    using Orleans.Serialization;
    using IoT.GrainInterfaces;
    using Orleans;
    using Orleans.Runtime;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DecodeGrainFactory
    {
        

                        public static IoT.GrainInterfaces.IDecodeGrain GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDecodeGrain), 148814687, primaryKey));
                        }

                        public static IoT.GrainInterfaces.IDecodeGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDecodeGrain), 148814687, primaryKey, grainClassNamePrefix));
                        }

                        public static IoT.GrainInterfaces.IDecodeGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDecodeGrain), 148814687, primaryKey));
                        }

                        public static IoT.GrainInterfaces.IDecodeGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDecodeGrain), 148814687, primaryKey, grainClassNamePrefix));
                        }

            public static IoT.GrainInterfaces.IDecodeGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return DecodeGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.IDecodeGrain")]
        internal class DecodeGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, IoT.GrainInterfaces.IDecodeGrain
        {
            

            public static IoT.GrainInterfaces.IDecodeGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IoT.GrainInterfaces.IDecodeGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IoT.GrainInterfaces.IDecodeGrain), (global::Orleans.Runtime.GrainReference gr) => { return new DecodeGrainReference(gr);}, grainRef, 148814687);
            }
            
            protected internal DecodeGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal DecodeGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 148814687;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "IoT.GrainInterfaces.IoT.GrainInterfaces.IDecodeGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DecodeGrainReference input = ((DecodeGrainReference)(original));
                return ((DecodeGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DecodeGrainReference input = ((DecodeGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DecodeGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return DecodeGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task IoT.GrainInterfaces.IDecodeGrain.Decode(string message)
            {

                return base.InvokeMethodAsync<object>(1114664117, new object[] {message} , options:  global::Orleans.CodeGeneration.InvokeMethodOptions.Unordered);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.IDecodeGrain", 148814687)]
    internal class DecodeGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 148814687;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 148814687:  // IDecodeGrain
                        switch (methodId)
                        {
                            case 1114664117: 
                                return ((IDecodeGrain)grain).Decode((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
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
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DeviceGrainFactory
    {
        

                        public static IoT.GrainInterfaces.IDeviceGrain GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDeviceGrain), -1248350959, primaryKey));
                        }

                        public static IoT.GrainInterfaces.IDeviceGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDeviceGrain), -1248350959, primaryKey, grainClassNamePrefix));
                        }

                        public static IoT.GrainInterfaces.IDeviceGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDeviceGrain), -1248350959, primaryKey));
                        }

                        public static IoT.GrainInterfaces.IDeviceGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IoT.GrainInterfaces.IDeviceGrain), -1248350959, primaryKey, grainClassNamePrefix));
                        }

            public static IoT.GrainInterfaces.IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return DeviceGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.IDeviceGrain")]
        internal class DeviceGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, IoT.GrainInterfaces.IDeviceGrain
        {
            

            public static IoT.GrainInterfaces.IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IoT.GrainInterfaces.IDeviceGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IoT.GrainInterfaces.IDeviceGrain), (global::Orleans.Runtime.GrainReference gr) => { return new DeviceGrainReference(gr);}, grainRef, -1248350959);
            }
            
            protected internal DeviceGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal DeviceGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -1248350959;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "IoT.GrainInterfaces.IoT.GrainInterfaces.IDeviceGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                return ((DeviceGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DeviceGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return DeviceGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task IoT.GrainInterfaces.IDeviceGrain.SetTemperature(double value)
            {

                return base.InvokeMethodAsync<object>(-1788431855, new object[] {value} );
            }
            
            System.Threading.Tasks.Task IoT.GrainInterfaces.IDeviceGrain.JoinSystem(string name)
            {

                return base.InvokeMethodAsync<object>(-1555867497, new object[] {name} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.IDeviceGrain", -1248350959)]
    internal class DeviceGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -1248350959;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1248350959:  // IDeviceGrain
                        switch (methodId)
                        {
                            case -1788431855: 
                                return ((IDeviceGrain)grain).SetTemperature((Double)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -1555867497: 
                                return ((IDeviceGrain)grain).JoinSystem((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
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
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SystemGrainFactory
    {
        

                        public static IoT.GrainInterfaces.ISystemGrain GetGrain(long primaryKey, string keyExt)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IoT.GrainInterfaces.ISystemGrain), 1021785371, primaryKey, keyExt));
                        }

                        public static IoT.GrainInterfaces.ISystemGrain GetGrain(long primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IoT.GrainInterfaces.ISystemGrain), 1021785371, primaryKey, keyExt, grainClassNamePrefix));
                        }

                        public static IoT.GrainInterfaces.ISystemGrain GetGrain(System.Guid primaryKey, string keyExt)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IoT.GrainInterfaces.ISystemGrain), 1021785371, primaryKey, keyExt));
                        }

                        public static IoT.GrainInterfaces.ISystemGrain GetGrain(System.Guid primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IoT.GrainInterfaces.ISystemGrain), 1021785371, primaryKey, keyExt,grainClassNamePrefix));
                        }

            public static IoT.GrainInterfaces.ISystemGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return SystemGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.ISystemGrain")]
        internal class SystemGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, IoT.GrainInterfaces.ISystemGrain
        {
            

            public static IoT.GrainInterfaces.ISystemGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IoT.GrainInterfaces.ISystemGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IoT.GrainInterfaces.ISystemGrain), (global::Orleans.Runtime.GrainReference gr) => { return new SystemGrainReference(gr);}, grainRef, 1021785371);
            }
            
            protected internal SystemGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal SystemGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1021785371;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "IoT.GrainInterfaces.IoT.GrainInterfaces.ISystemGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                SystemGrainReference input = ((SystemGrainReference)(original));
                return ((SystemGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                SystemGrainReference input = ((SystemGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return SystemGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return SystemGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task IoT.GrainInterfaces.ISystemGrain.SetTemperature(IoT.GrainInterfaces.TemperatureReading reading)
            {

                return base.InvokeMethodAsync<object>(997261292, new object[] {reading} );
            }
            
            System.Threading.Tasks.Task IoT.GrainInterfaces.ISystemGrain.Subscribe(IoT.GrainInterfaces.ISystemObserver observer)
            {
global::Orleans.CodeGeneration.GrainFactoryBase.CheckGrainObserverParamInternal(observer);

                return base.InvokeMethodAsync<object>(987286981, new object[] {observer is global::Orleans.Grain ? IoT.GrainInterfaces.SystemObserverFactory.Cast(observer.AsReference()) : observer} );
            }
            
            System.Threading.Tasks.Task IoT.GrainInterfaces.ISystemGrain.Unsubscribe(IoT.GrainInterfaces.ISystemObserver observer)
            {
global::Orleans.CodeGeneration.GrainFactoryBase.CheckGrainObserverParamInternal(observer);

                return base.InvokeMethodAsync<object>(-1645784438, new object[] {observer is global::Orleans.Grain ? IoT.GrainInterfaces.SystemObserverFactory.Cast(observer.AsReference()) : observer} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.ISystemGrain", 1021785371)]
    internal class SystemGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1021785371;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1021785371:  // ISystemGrain
                        switch (methodId)
                        {
                            case 997261292: 
                                return ((ISystemGrain)grain).SetTemperature((TemperatureReading)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 987286981: 
                                return ((ISystemGrain)grain).Subscribe((ISystemObserver)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -1645784438: 
                                return ((ISystemGrain)grain).Unsubscribe((ISystemObserver)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
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
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SystemObserverFactory
    {
        

            public static IoT.GrainInterfaces.ISystemObserver Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return SystemObserverReference.Cast(grainRef);
            }

        private static global::Orleans.CodeGeneration.IGrainMethodInvoker methodInvoker;

        public async static System.Threading.Tasks.Task<IoT.GrainInterfaces.ISystemObserver> CreateObjectReference(IoT.GrainInterfaces.ISystemObserver obj)
        {
            if (methodInvoker == null) methodInvoker = new SystemObserverMethodInvoker();
            return SystemObserverFactory.Cast(await global::Orleans.Runtime.GrainReference.CreateObjectReference(obj, methodInvoker));
        }

        public static System.Threading.Tasks.Task DeleteObjectReference(IoT.GrainInterfaces.ISystemObserver reference)
        {
            return global::Orleans.Runtime.GrainReference.DeleteObjectReference(reference);
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.ISystemObserver")]
        internal class SystemObserverReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, IoT.GrainInterfaces.ISystemObserver
        {
            

            public static IoT.GrainInterfaces.ISystemObserver Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IoT.GrainInterfaces.ISystemObserver) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IoT.GrainInterfaces.ISystemObserver), (global::Orleans.Runtime.GrainReference gr) => { return new SystemObserverReference(gr);}, grainRef, -1413064308);
            }
            
            protected internal SystemObserverReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal SystemObserverReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -1413064308;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "IoT.GrainInterfaces.IoT.GrainInterfaces.ISystemObserver";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                SystemObserverReference input = ((SystemObserverReference)(original));
                return ((SystemObserverReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                SystemObserverReference input = ((SystemObserverReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return SystemObserverReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return SystemObserverMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            void IoT.GrainInterfaces.ISystemObserver.HighTemperature(double value)
            {

                base.InvokeOneWayMethod(-2130055570, new object[] {value} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("IoT.GrainInterfaces.IoT.GrainInterfaces.ISystemObserver", -1413064308)]
    internal class SystemObserverMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -1413064308;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {{                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1413064308:  // ISystemObserver
                        switch (methodId)
                        {
                            case -2130055570: 
                                ((ISystemObserver)grain).HighTemperature((Double)arguments[0]); return System.Threading.Tasks.Task.FromResult((object)true);
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }}
            catch(Exception ex)
            {{
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }}
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
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
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
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            IoT.GrainInterfaces.TemperatureReading result = new IoT.GrainInterfaces.TemperatureReading();
            result.DeviceId = ((Int64)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Int64), stream)));
            result.Time = ((DateTime)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(DateTime), stream)));
            result.Value = ((Double)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Double), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(IoT.GrainInterfaces.TemperatureReading), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
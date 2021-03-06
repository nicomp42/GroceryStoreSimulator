﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroceryStoreSimulator.CouponServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Coupon", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Coupon : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string couponField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string couponSourceField;
        
        private System.DateTime startDateField;
        
        private System.DateTime throughDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GroceryStoreSimulator.CouponServiceReference.CouponDetail[] couponDetailsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string coupon {
            get {
                return this.couponField;
            }
            set {
                if ((object.ReferenceEquals(this.couponField, value) != true)) {
                    this.couponField = value;
                    this.RaisePropertyChanged("coupon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string couponSource {
            get {
                return this.couponSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.couponSourceField, value) != true)) {
                    this.couponSourceField = value;
                    this.RaisePropertyChanged("couponSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                if ((this.startDateField.Equals(value) != true)) {
                    this.startDateField = value;
                    this.RaisePropertyChanged("startDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime throughDate {
            get {
                return this.throughDateField;
            }
            set {
                if ((this.throughDateField.Equals(value) != true)) {
                    this.throughDateField = value;
                    this.RaisePropertyChanged("throughDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public GroceryStoreSimulator.CouponServiceReference.CouponDetail[] couponDetails {
            get {
                return this.couponDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.couponDetailsField, value) != true)) {
                    this.couponDetailsField = value;
                    this.RaisePropertyChanged("couponDetails");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CouponDetail", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CouponDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string productField;
        
        private double amountOffField;
        
        private int percentageDiscountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string discountTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string product {
            get {
                return this.productField;
            }
            set {
                if ((object.ReferenceEquals(this.productField, value) != true)) {
                    this.productField = value;
                    this.RaisePropertyChanged("product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public double amountOff {
            get {
                return this.amountOffField;
            }
            set {
                if ((this.amountOffField.Equals(value) != true)) {
                    this.amountOffField = value;
                    this.RaisePropertyChanged("amountOff");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int percentageDiscount {
            get {
                return this.percentageDiscountField;
            }
            set {
                if ((this.percentageDiscountField.Equals(value) != true)) {
                    this.percentageDiscountField = value;
                    this.RaisePropertyChanged("percentageDiscount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string discountType {
            get {
                return this.discountTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.discountTypeField, value) != true)) {
                    this.discountTypeField = value;
                    this.RaisePropertyChanged("discountType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CouponServiceReference.CouponServiceSoap")]
    public interface CouponServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        GroceryStoreSimulator.CouponServiceReference.HelloWorldResponse HelloWorld(GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.HelloWorldResponse> HelloWorldAsync(GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name coupon from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateCoupon", ReplyAction="*")]
        GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponse ValidateCoupon(GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateCoupon", ReplyAction="*")]
        System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponse> ValidateCouponAsync(GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest request);
        
        // CODEGEN: Generating message contract since element name GetCouponInfoResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCouponInfo", ReplyAction="*")]
        GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponse GetCouponInfo(GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCouponInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponse> GetCouponInfoAsync(GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(GroceryStoreSimulator.CouponServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(GroceryStoreSimulator.CouponServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateCouponRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateCoupon", Namespace="http://tempuri.org/", Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequestBody Body;
        
        public ValidateCouponRequest() {
        }
        
        public ValidateCouponRequest(GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateCouponRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string coupon;
        
        public ValidateCouponRequestBody() {
        }
        
        public ValidateCouponRequestBody(string coupon) {
            this.coupon = coupon;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateCouponResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateCouponResponse", Namespace="http://tempuri.org/", Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponseBody Body;
        
        public ValidateCouponResponse() {
        }
        
        public ValidateCouponResponse(GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateCouponResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ValidateCouponResult;
        
        public ValidateCouponResponseBody() {
        }
        
        public ValidateCouponResponseBody(int ValidateCouponResult) {
            this.ValidateCouponResult = ValidateCouponResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCouponInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCouponInfo", Namespace="http://tempuri.org/", Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequestBody Body;
        
        public GetCouponInfoRequest() {
        }
        
        public GetCouponInfoRequest(GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCouponInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int couponID;
        
        public GetCouponInfoRequestBody() {
        }
        
        public GetCouponInfoRequestBody(int couponID) {
            this.couponID = couponID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCouponInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCouponInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponseBody Body;
        
        public GetCouponInfoResponse() {
        }
        
        public GetCouponInfoResponse(GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCouponInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public GroceryStoreSimulator.CouponServiceReference.Coupon GetCouponInfoResult;
        
        public GetCouponInfoResponseBody() {
        }
        
        public GetCouponInfoResponseBody(GroceryStoreSimulator.CouponServiceReference.Coupon GetCouponInfoResult) {
            this.GetCouponInfoResult = GetCouponInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CouponServiceSoapChannel : GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CouponServiceSoapClient : System.ServiceModel.ClientBase<GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap>, GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap {
        
        public CouponServiceSoapClient() {
        }
        
        public CouponServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CouponServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CouponServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CouponServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GroceryStoreSimulator.CouponServiceReference.HelloWorldResponse GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap.HelloWorld(GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest inValue = new GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest();
            inValue.Body = new GroceryStoreSimulator.CouponServiceReference.HelloWorldRequestBody();
            GroceryStoreSimulator.CouponServiceReference.HelloWorldResponse retVal = ((GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.HelloWorldResponse> GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap.HelloWorldAsync(GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.HelloWorldResponse> HelloWorldAsync() {
            GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest inValue = new GroceryStoreSimulator.CouponServiceReference.HelloWorldRequest();
            inValue.Body = new GroceryStoreSimulator.CouponServiceReference.HelloWorldRequestBody();
            return ((GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponse GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap.ValidateCoupon(GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest request) {
            return base.Channel.ValidateCoupon(request);
        }
        
        public int ValidateCoupon(string coupon) {
            GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest inValue = new GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest();
            inValue.Body = new GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequestBody();
            inValue.Body.coupon = coupon;
            GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponse retVal = ((GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap)(this)).ValidateCoupon(inValue);
            return retVal.Body.ValidateCouponResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponse> GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap.ValidateCouponAsync(GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest request) {
            return base.Channel.ValidateCouponAsync(request);
        }
        
        public System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.ValidateCouponResponse> ValidateCouponAsync(string coupon) {
            GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest inValue = new GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequest();
            inValue.Body = new GroceryStoreSimulator.CouponServiceReference.ValidateCouponRequestBody();
            inValue.Body.coupon = coupon;
            return ((GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap)(this)).ValidateCouponAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponse GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap.GetCouponInfo(GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest request) {
            return base.Channel.GetCouponInfo(request);
        }
        
        public GroceryStoreSimulator.CouponServiceReference.Coupon GetCouponInfo(int couponID) {
            GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest inValue = new GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest();
            inValue.Body = new GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequestBody();
            inValue.Body.couponID = couponID;
            GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponse retVal = ((GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap)(this)).GetCouponInfo(inValue);
            return retVal.Body.GetCouponInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponse> GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap.GetCouponInfoAsync(GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest request) {
            return base.Channel.GetCouponInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<GroceryStoreSimulator.CouponServiceReference.GetCouponInfoResponse> GetCouponInfoAsync(int couponID) {
            GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest inValue = new GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequest();
            inValue.Body = new GroceryStoreSimulator.CouponServiceReference.GetCouponInfoRequestBody();
            inValue.Body.couponID = couponID;
            return ((GroceryStoreSimulator.CouponServiceReference.CouponServiceSoap)(this)).GetCouponInfoAsync(inValue);
        }
    }
}

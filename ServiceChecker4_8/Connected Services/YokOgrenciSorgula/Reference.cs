//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceChecker4_8.YokOgrenciSorgula {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10", ConfigurationName="YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort")]
    public interface YuksekOgretimEgitimBilgisiPort {
        
        // CODEGEN: Generating message contract since the operation OgrenciOzet is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse1 OgrenciOzet(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse1> OgrenciOzetAsync(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10")]
    public partial class OgrenciOzetRequestType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private IstekBilgiTip istekField;
        
        private long tcKimlikNoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IstekBilgiTip Istek {
            get {
                return this.istekField;
            }
            set {
                this.istekField = value;
                this.RaisePropertyChanged("Istek");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long TcKimlikNo {
            get {
                return this.tcKimlikNoField;
            }
            set {
                this.tcKimlikNoField = value;
                this.RaisePropertyChanged("TcKimlikNo");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10")]
    public partial class IstekBilgiTip : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string istekTarihiField;
        
        private string istekIdField;
        
        private string kullaniciAdiField;
        
        private string uygulamaAdiField;
        
        private string uygulamaSunucuAdiField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
        public string IstekTarihi {
            get {
                return this.istekTarihiField;
            }
            set {
                this.istekTarihiField = value;
                this.RaisePropertyChanged("IstekTarihi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string IstekId {
            get {
                return this.istekIdField;
            }
            set {
                this.istekIdField = value;
                this.RaisePropertyChanged("IstekId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
        public string KullaniciAdi {
            get {
                return this.kullaniciAdiField;
            }
            set {
                this.kullaniciAdiField = value;
                this.RaisePropertyChanged("KullaniciAdi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
        public string UygulamaAdi {
            get {
                return this.uygulamaAdiField;
            }
            set {
                this.uygulamaAdiField = value;
                this.RaisePropertyChanged("UygulamaAdi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
        public string UygulamaSunucuAdi {
            get {
                return this.uygulamaSunucuAdiField;
            }
            set {
                this.uygulamaSunucuAdiField = value;
                this.RaisePropertyChanged("UygulamaSunucuAdi");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10")]
    public partial class SonucBilgiTip : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int sonucKodField;
        
        private string disSistemSonucKodField;
        
        private string sonucMesajField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int SonucKod {
            get {
                return this.sonucKodField;
            }
            set {
                this.sonucKodField = value;
                this.RaisePropertyChanged("SonucKod");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
        public string DisSistemSonucKod {
            get {
                return this.disSistemSonucKodField;
            }
            set {
                this.disSistemSonucKodField = value;
                this.RaisePropertyChanged("DisSistemSonucKod");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SonucMesaj {
            get {
                return this.sonucMesajField;
            }
            set {
                this.sonucMesajField = value;
                this.RaisePropertyChanged("SonucMesaj");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10")]
    public partial class OgrenciOzetBilgi : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long tcKimlikNoField;
        
        private bool tcKimlikNoFieldSpecified;
        
        private string adiField;
        
        private string soyadiField;
        
        private string universiteAdiField;
        
        private string ogrencilikHakkiVarMiField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long TcKimlikNo {
            get {
                return this.tcKimlikNoField;
            }
            set {
                this.tcKimlikNoField = value;
                this.RaisePropertyChanged("TcKimlikNo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TcKimlikNoSpecified {
            get {
                return this.tcKimlikNoFieldSpecified;
            }
            set {
                this.tcKimlikNoFieldSpecified = value;
                this.RaisePropertyChanged("TcKimlikNoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Adi {
            get {
                return this.adiField;
            }
            set {
                this.adiField = value;
                this.RaisePropertyChanged("Adi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Soyadi {
            get {
                return this.soyadiField;
            }
            set {
                this.soyadiField = value;
                this.RaisePropertyChanged("Soyadi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string UniversiteAdi {
            get {
                return this.universiteAdiField;
            }
            set {
                this.universiteAdiField = value;
                this.RaisePropertyChanged("UniversiteAdi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string OgrencilikHakkiVarMi {
            get {
                return this.ogrencilikHakkiVarMiField;
            }
            set {
                this.ogrencilikHakkiVarMiField = value;
                this.RaisePropertyChanged("OgrencilikHakkiVarMi");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10")]
    public partial class OgrenciOzetResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private OgrenciOzetBilgi[] ogrenciOzetBilgiField;
        
        private SonucBilgiTip sonucField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OgrenciOzetBilgi", Order=0)]
        public OgrenciOzetBilgi[] OgrenciOzetBilgi {
            get {
                return this.ogrenciOzetBilgiField;
            }
            set {
                this.ogrenciOzetBilgiField = value;
                this.RaisePropertyChanged("OgrenciOzetBilgi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SonucBilgiTip Sonuc {
            get {
                return this.sonucField;
            }
            set {
                this.sonucField = value;
                this.RaisePropertyChanged("Sonuc");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OgrenciOzetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OgrenciOzetRequest", Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10", Order=0)]
        public ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequestType OgrenciOzetRequest1;
        
        public OgrenciOzetRequest() {
        }
        
        public OgrenciOzetRequest(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequestType OgrenciOzetRequest1) {
            this.OgrenciOzetRequest1 = OgrenciOzetRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OgrenciOzetResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.yok.gov.tr/yuksekogretimegitimbilgisi/2019/10", Order=0)]
        public ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse OgrenciOzetResponse;
        
        public OgrenciOzetResponse1() {
        }
        
        public OgrenciOzetResponse1(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse OgrenciOzetResponse) {
            this.OgrenciOzetResponse = OgrenciOzetResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface YuksekOgretimEgitimBilgisiPortChannel : ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class YuksekOgretimEgitimBilgisiPortClient : System.ServiceModel.ClientBase<ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort>, ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort {
        
        public YuksekOgretimEgitimBilgisiPortClient() {
        }
        
        public YuksekOgretimEgitimBilgisiPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public YuksekOgretimEgitimBilgisiPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YuksekOgretimEgitimBilgisiPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YuksekOgretimEgitimBilgisiPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse1 ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort.OgrenciOzet(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest request) {
            return base.Channel.OgrenciOzet(request);
        }
        
        public ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse OgrenciOzet(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequestType OgrenciOzetRequest1) {
            ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest inValue = new ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest();
            inValue.OgrenciOzetRequest1 = OgrenciOzetRequest1;
            ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse1 retVal = ((ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort)(this)).OgrenciOzet(inValue);
            return retVal.OgrenciOzetResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse1> ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort.OgrenciOzetAsync(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest request) {
            return base.Channel.OgrenciOzetAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetResponse1> OgrenciOzetAsync(ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequestType OgrenciOzetRequest1) {
            ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest inValue = new ServiceChecker4_8.YokOgrenciSorgula.OgrenciOzetRequest();
            inValue.OgrenciOzetRequest1 = OgrenciOzetRequest1;
            return ((ServiceChecker4_8.YokOgrenciSorgula.YuksekOgretimEgitimBilgisiPort)(this)).OgrenciOzetAsync(inValue);
        }
    }
}

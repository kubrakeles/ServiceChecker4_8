//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceChecker4_8.YokAkademikPersonelSorgula {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.yok.gov.tr/personel/2020/01", ConfigurationName="YokAkademikPersonelSorgula.PersonelPort")]
    public interface PersonelPort {
        
        // CODEGEN: Generating message contract since the operation AkademikPersonelOzet is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse1 AkademikPersonelOzet(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse1> AkademikPersonelOzetAsync(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/personel/2020/01")]
    public partial class AkademikPersonelOzetRequestType : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/personel/2020/01")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/personel/2020/01")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.yok.gov.tr/personel/2020/01")]
    public partial class AkademikPersonelOzet : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long tcKimlikNoField;
        
        private bool tcKimlikNoFieldSpecified;
        
        private string adField;
        
        private string soyadField;
        
        private string kadroUnvanAdiField;
        
        private string universiteAdiField;
        
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
        public string Ad {
            get {
                return this.adField;
            }
            set {
                this.adField = value;
                this.RaisePropertyChanged("Ad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Soyad {
            get {
                return this.soyadField;
            }
            set {
                this.soyadField = value;
                this.RaisePropertyChanged("Soyad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string KadroUnvanAdi {
            get {
                return this.kadroUnvanAdiField;
            }
            set {
                this.kadroUnvanAdiField = value;
                this.RaisePropertyChanged("KadroUnvanAdi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string UniversiteAdi {
            get {
                return this.universiteAdiField;
            }
            set {
                this.universiteAdiField = value;
                this.RaisePropertyChanged("UniversiteAdi");
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.yok.gov.tr/personel/2020/01")]
    public partial class AkademikPersonelOzetResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AkademikPersonelOzet[] akademikPersonelOzetField;
        
        private SonucBilgiTip sonucField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AkademikPersonelOzet", Order=0)]
        public AkademikPersonelOzet[] AkademikPersonelOzet {
            get {
                return this.akademikPersonelOzetField;
            }
            set {
                this.akademikPersonelOzetField = value;
                this.RaisePropertyChanged("AkademikPersonelOzet");
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
    public partial class AkademikPersonelOzetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AkademikPersonelOzetRequest", Namespace="http://www.yok.gov.tr/personel/2020/01", Order=0)]
        public ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequestType AkademikPersonelOzetRequest1;
        
        public AkademikPersonelOzetRequest() {
        }
        
        public AkademikPersonelOzetRequest(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequestType AkademikPersonelOzetRequest1) {
            this.AkademikPersonelOzetRequest1 = AkademikPersonelOzetRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AkademikPersonelOzetResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.yok.gov.tr/personel/2020/01", Order=0)]
        public ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse AkademikPersonelOzetResponse;
        
        public AkademikPersonelOzetResponse1() {
        }
        
        public AkademikPersonelOzetResponse1(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse AkademikPersonelOzetResponse) {
            this.AkademikPersonelOzetResponse = AkademikPersonelOzetResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PersonelPortChannel : ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonelPortClient : System.ServiceModel.ClientBase<ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort>, ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort {
        
        public PersonelPortClient() {
        }
        
        public PersonelPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonelPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonelPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonelPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse1 ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort.AkademikPersonelOzet(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest request) {
            return base.Channel.AkademikPersonelOzet(request);
        }
        
        public ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse AkademikPersonelOzet(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequestType AkademikPersonelOzetRequest1) {
            ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest inValue = new ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest();
            inValue.AkademikPersonelOzetRequest1 = AkademikPersonelOzetRequest1;
            ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse1 retVal = ((ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort)(this)).AkademikPersonelOzet(inValue);
            return retVal.AkademikPersonelOzetResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse1> ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort.AkademikPersonelOzetAsync(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest request) {
            return base.Channel.AkademikPersonelOzetAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetResponse1> AkademikPersonelOzetAsync(ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequestType AkademikPersonelOzetRequest1) {
            ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest inValue = new ServiceChecker4_8.YokAkademikPersonelSorgula.AkademikPersonelOzetRequest();
            inValue.AkademikPersonelOzetRequest1 = AkademikPersonelOzetRequest1;
            return ((ServiceChecker4_8.YokAkademikPersonelSorgula.PersonelPort)(this)).AkademikPersonelOzetAsync(inValue);
        }
    }
}

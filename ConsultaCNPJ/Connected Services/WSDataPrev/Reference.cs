﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultaCNPJ.WSDataPrev {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSDataPrev.ServicosDataprevSoap")]
    public interface ServicosDataprevSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSituacaoFiscalPrevidenciaria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsultaCNPJ.WSDataPrev.consultaTO GetSituacaoFiscalPrevidenciaria(ConsultaCNPJ.WSDataPrev.parametrosTO parametrosReferencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSituacaoFiscalPrevidenciaria", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsultaCNPJ.WSDataPrev.consultaTO> GetSituacaoFiscalPrevidenciariaAsync(ConsultaCNPJ.WSDataPrev.parametrosTO parametrosReferencia);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class parametrosTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sistemaorigemField;
        
        private string tiponiField;
        
        private string niField;
        
        private string competfinalField;
        
        private string datarefField;
        
        private string meiField;
        
        private string datameiField;
        
        private string tipoconsultaField;
        
        private string reprocessamentoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sistema-origem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string sistemaorigem {
            get {
                return this.sistemaorigemField;
            }
            set {
                this.sistemaorigemField = value;
                this.RaisePropertyChanged("sistemaorigem");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-ni", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string tiponi {
            get {
                return this.tiponiField;
            }
            set {
                this.tiponiField = value;
                this.RaisePropertyChanged("tiponi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string ni {
            get {
                return this.niField;
            }
            set {
                this.niField = value;
                this.RaisePropertyChanged("ni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("compet-final", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string competfinal {
            get {
                return this.competfinalField;
            }
            set {
                this.competfinalField = value;
                this.RaisePropertyChanged("competfinal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-ref", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string dataref {
            get {
                return this.datarefField;
            }
            set {
                this.datarefField = value;
                this.RaisePropertyChanged("dataref");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string mei {
            get {
                return this.meiField;
            }
            set {
                this.meiField = value;
                this.RaisePropertyChanged("mei");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-mei", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string datamei {
            get {
                return this.datameiField;
            }
            set {
                this.datameiField = value;
                this.RaisePropertyChanged("datamei");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-consulta", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string tipoconsulta {
            get {
                return this.tipoconsultaField;
            }
            set {
                this.tipoconsultaField = value;
                this.RaisePropertyChanged("tipoconsulta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string reprocessamento {
            get {
                return this.reprocessamentoField;
            }
            set {
                this.reprocessamentoField = value;
                this.RaisePropertyChanged("reprocessamento");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class erroTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoField;
        
        private string descricaoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
                this.RaisePropertyChanged("descricao");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class debitoTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long numeroField;
        
        private bool numeroFieldSpecified;
        
        private int ambitoField;
        
        private bool ambitoFieldSpecified;
        
        private int codigosituacaofaseField;
        
        private bool codigosituacaofaseFieldSpecified;
        
        private string descricaosituacaofaseField;
        
        private bool exigivelField;
        
        private bool exigivelFieldSpecified;
        
        private string saldooriginalField;
        
        private string parcelamentoField;
        
        private int dataconsolidacaoField;
        
        private bool dataconsolidacaoFieldSpecified;
        
        private long debcadField;
        
        private bool debcadFieldSpecified;
        
        private int parcelasatrasadasField;
        
        private bool parcelasatrasadasFieldSpecified;
        
        private int datarequerimentoField;
        
        private bool datarequerimentoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroSpecified {
            get {
                return this.numeroFieldSpecified;
            }
            set {
                this.numeroFieldSpecified = value;
                this.RaisePropertyChanged("numeroSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int ambito {
            get {
                return this.ambitoField;
            }
            set {
                this.ambitoField = value;
                this.RaisePropertyChanged("ambito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ambitoSpecified {
            get {
                return this.ambitoFieldSpecified;
            }
            set {
                this.ambitoFieldSpecified = value;
                this.RaisePropertyChanged("ambitoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codigo-situacao-fase", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int codigosituacaofase {
            get {
                return this.codigosituacaofaseField;
            }
            set {
                this.codigosituacaofaseField = value;
                this.RaisePropertyChanged("codigosituacaofase");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigosituacaofaseSpecified {
            get {
                return this.codigosituacaofaseFieldSpecified;
            }
            set {
                this.codigosituacaofaseFieldSpecified = value;
                this.RaisePropertyChanged("codigosituacaofaseSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("descricao-situacao-fase", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string descricaosituacaofase {
            get {
                return this.descricaosituacaofaseField;
            }
            set {
                this.descricaosituacaofaseField = value;
                this.RaisePropertyChanged("descricaosituacaofase");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool exigivel {
            get {
                return this.exigivelField;
            }
            set {
                this.exigivelField = value;
                this.RaisePropertyChanged("exigivel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exigivelSpecified {
            get {
                return this.exigivelFieldSpecified;
            }
            set {
                this.exigivelFieldSpecified = value;
                this.RaisePropertyChanged("exigivelSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("saldo-original", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string saldooriginal {
            get {
                return this.saldooriginalField;
            }
            set {
                this.saldooriginalField = value;
                this.RaisePropertyChanged("saldooriginal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string parcelamento {
            get {
                return this.parcelamentoField;
            }
            set {
                this.parcelamentoField = value;
                this.RaisePropertyChanged("parcelamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-consolidacao", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int dataconsolidacao {
            get {
                return this.dataconsolidacaoField;
            }
            set {
                this.dataconsolidacaoField = value;
                this.RaisePropertyChanged("dataconsolidacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataconsolidacaoSpecified {
            get {
                return this.dataconsolidacaoFieldSpecified;
            }
            set {
                this.dataconsolidacaoFieldSpecified = value;
                this.RaisePropertyChanged("dataconsolidacaoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long debcad {
            get {
                return this.debcadField;
            }
            set {
                this.debcadField = value;
                this.RaisePropertyChanged("debcad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool debcadSpecified {
            get {
                return this.debcadFieldSpecified;
            }
            set {
                this.debcadFieldSpecified = value;
                this.RaisePropertyChanged("debcadSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parcelas-atrasadas", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int parcelasatrasadas {
            get {
                return this.parcelasatrasadasField;
            }
            set {
                this.parcelasatrasadasField = value;
                this.RaisePropertyChanged("parcelasatrasadas");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parcelasatrasadasSpecified {
            get {
                return this.parcelasatrasadasFieldSpecified;
            }
            set {
                this.parcelasatrasadasFieldSpecified = value;
                this.RaisePropertyChanged("parcelasatrasadasSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-requerimento", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int datarequerimento {
            get {
                return this.datarequerimentoField;
            }
            set {
                this.datarequerimentoField = value;
                this.RaisePropertyChanged("datarequerimento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool datarequerimentoSpecified {
            get {
                return this.datarequerimentoFieldSpecified;
            }
            set {
                this.datarequerimentoFieldSpecified = value;
                this.RaisePropertyChanged("datarequerimentoSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class divergenciaTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string competenciaField;
        
        private string situacaoField;
        
        private string fpasField;
        
        private string valorinssField;
        
        private string valorterceirosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string competencia {
            get {
                return this.competenciaField;
            }
            set {
                this.competenciaField = value;
                this.RaisePropertyChanged("competencia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string situacao {
            get {
                return this.situacaoField;
            }
            set {
                this.situacaoField = value;
                this.RaisePropertyChanged("situacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string fpas {
            get {
                return this.fpasField;
            }
            set {
                this.fpasField = value;
                this.RaisePropertyChanged("fpas");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("valor-inss", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string valorinss {
            get {
                return this.valorinssField;
            }
            set {
                this.valorinssField = value;
                this.RaisePropertyChanged("valorinss");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("valor-terceiros", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string valorterceiros {
            get {
                return this.valorterceirosField;
            }
            set {
                this.valorterceirosField = value;
                this.RaisePropertyChanged("valorterceiros");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class ausenciaTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string competenciaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string competencia {
            get {
                return this.competenciaField;
            }
            set {
                this.competenciaField = value;
                this.RaisePropertyChanged("competencia");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class estabelecimentoTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private tipoNi tiponiField;
        
        private bool tiponiFieldSpecified;
        
        private string niField;
        
        private ausenciaTO[] ausenciasgfipField;
        
        private divergenciaTO[] divergenciasgfipgpsField;
        
        private debitoTO[] debitosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-ni", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public tipoNi tiponi {
            get {
                return this.tiponiField;
            }
            set {
                this.tiponiField = value;
                this.RaisePropertyChanged("tiponi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tiponiSpecified {
            get {
                return this.tiponiFieldSpecified;
            }
            set {
                this.tiponiFieldSpecified = value;
                this.RaisePropertyChanged("tiponiSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ni {
            get {
                return this.niField;
            }
            set {
                this.niField = value;
                this.RaisePropertyChanged("ni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("ausencias-gfip", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ausencia", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ausenciaTO[] ausenciasgfip {
            get {
                return this.ausenciasgfipField;
            }
            set {
                this.ausenciasgfipField = value;
                this.RaisePropertyChanged("ausenciasgfip");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("divergencias-gfip-gps", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("divergencia", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public divergenciaTO[] divergenciasgfipgps {
            get {
                return this.divergenciasgfipgpsField;
            }
            set {
                this.divergenciasgfipgpsField = value;
                this.RaisePropertyChanged("divergenciasgfipgps");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("debito", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public debitoTO[] debitos {
            get {
                return this.debitosField;
            }
            set {
                this.debitosField = value;
                this.RaisePropertyChanged("debitos");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public enum tipoNi {
        
        /// <remarks/>
        OUTROS,
        
        /// <remarks/>
        CNPJ,
        
        /// <remarks/>
        CEI,
        
        /// <remarks/>
        CPF,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class resultadoTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int cprfbField;
        
        private bool cprfbFieldSpecified;
        
        private int cpdenrfbField;
        
        private bool cpdenrfbFieldSpecified;
        
        private int cppgfnField;
        
        private bool cppgfnFieldSpecified;
        
        private int cpdenpgfnField;
        
        private bool cpdenpgfnFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cp-rfb", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int cprfb {
            get {
                return this.cprfbField;
            }
            set {
                this.cprfbField = value;
                this.RaisePropertyChanged("cprfb");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cprfbSpecified {
            get {
                return this.cprfbFieldSpecified;
            }
            set {
                this.cprfbFieldSpecified = value;
                this.RaisePropertyChanged("cprfbSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cpden-rfb", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int cpdenrfb {
            get {
                return this.cpdenrfbField;
            }
            set {
                this.cpdenrfbField = value;
                this.RaisePropertyChanged("cpdenrfb");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpdenrfbSpecified {
            get {
                return this.cpdenrfbFieldSpecified;
            }
            set {
                this.cpdenrfbFieldSpecified = value;
                this.RaisePropertyChanged("cpdenrfbSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cp-pgfn", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int cppgfn {
            get {
                return this.cppgfnField;
            }
            set {
                this.cppgfnField = value;
                this.RaisePropertyChanged("cppgfn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cppgfnSpecified {
            get {
                return this.cppgfnFieldSpecified;
            }
            set {
                this.cppgfnFieldSpecified = value;
                this.RaisePropertyChanged("cppgfnSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cpden-pgfn", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int cpdenpgfn {
            get {
                return this.cpdenpgfnField;
            }
            set {
                this.cpdenpgfnField = value;
                this.RaisePropertyChanged("cpdenpgfn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpdenpgfnSpecified {
            get {
                return this.cpdenpgfnFieldSpecified;
            }
            set {
                this.cpdenpgfnFieldSpecified = value;
                this.RaisePropertyChanged("cpdenpgfnSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class cabecalhoTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tiponiField;
        
        private string niField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tipo-ni", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string tiponi {
            get {
                return this.tiponiField;
            }
            set {
                this.tiponiField = value;
                this.RaisePropertyChanged("tiponi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ni {
            get {
                return this.niField;
            }
            set {
                this.niField = value;
                this.RaisePropertyChanged("ni");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sisfpj.dataprev.gov.br/")]
    public partial class consultaTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private cabecalhoTO cabecalhoField;
        
        private resultadoTO resultadoField;
        
        private estabelecimentoTO[] detalhamentoField;
        
        private erroTO erroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public cabecalhoTO cabecalho {
            get {
                return this.cabecalhoField;
            }
            set {
                this.cabecalhoField = value;
                this.RaisePropertyChanged("cabecalho");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public resultadoTO resultado {
            get {
                return this.resultadoField;
            }
            set {
                this.resultadoField = value;
                this.RaisePropertyChanged("resultado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("estabelecimento", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public estabelecimentoTO[] detalhamento {
            get {
                return this.detalhamentoField;
            }
            set {
                this.detalhamentoField = value;
                this.RaisePropertyChanged("detalhamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public erroTO erro {
            get {
                return this.erroField;
            }
            set {
                this.erroField = value;
                this.RaisePropertyChanged("erro");
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
    public interface ServicosDataprevSoapChannel : ConsultaCNPJ.WSDataPrev.ServicosDataprevSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicosDataprevSoapClient : System.ServiceModel.ClientBase<ConsultaCNPJ.WSDataPrev.ServicosDataprevSoap>, ConsultaCNPJ.WSDataPrev.ServicosDataprevSoap {
        
        public ServicosDataprevSoapClient() {
        }
        
        public ServicosDataprevSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicosDataprevSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicosDataprevSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicosDataprevSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsultaCNPJ.WSDataPrev.consultaTO GetSituacaoFiscalPrevidenciaria(ConsultaCNPJ.WSDataPrev.parametrosTO parametrosReferencia) {
            return base.Channel.GetSituacaoFiscalPrevidenciaria(parametrosReferencia);
        }
        
        public System.Threading.Tasks.Task<ConsultaCNPJ.WSDataPrev.consultaTO> GetSituacaoFiscalPrevidenciariaAsync(ConsultaCNPJ.WSDataPrev.parametrosTO parametrosReferencia) {
            return base.Channel.GetSituacaoFiscalPrevidenciariaAsync(parametrosReferencia);
        }
    }
}

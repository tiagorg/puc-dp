﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.488.
// 
#pragma warning disable 1591

namespace Servicos.ProcessarPedidoService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ProcessarPedidoSoap", Namespace="http://tempuri.org/")]
    public partial class ProcessarPedido : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RegistrarVendaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProcessarPedido() {
            this.Url = global::Servicos.Properties.Settings.Default.Servicos_ProcessarPedidoService_ProcessarPedido;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event RegistrarVendaCompletedEventHandler RegistrarVendaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegistrarVenda", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Retorno RegistrarVenda(int idProduto, int quantidade) {
            object[] results = this.Invoke("RegistrarVenda", new object[] {
                        idProduto,
                        quantidade});
            return ((Retorno)(results[0]));
        }
        
        /// <remarks/>
        public void RegistrarVendaAsync(int idProduto, int quantidade) {
            this.RegistrarVendaAsync(idProduto, quantidade, null);
        }
        
        /// <remarks/>
        public void RegistrarVendaAsync(int idProduto, int quantidade, object userState) {
            if ((this.RegistrarVendaOperationCompleted == null)) {
                this.RegistrarVendaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegistrarVendaOperationCompleted);
            }
            this.InvokeAsync("RegistrarVenda", new object[] {
                        idProduto,
                        quantidade}, this.RegistrarVendaOperationCompleted, userState);
        }
        
        private void OnRegistrarVendaOperationCompleted(object arg) {
            if ((this.RegistrarVendaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegistrarVendaCompleted(this, new RegistrarVendaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Retorno {
        
        private System.DateTime dataEntregaField;
        
        private decimal valorTotalField;
        
        private bool fgProcessadoField;
        
        private int idPedidoField;
        
        private string mensagemRetornoField;
        
        /// <remarks/>
        public System.DateTime DataEntrega {
            get {
                return this.dataEntregaField;
            }
            set {
                this.dataEntregaField = value;
            }
        }
        
        /// <remarks/>
        public decimal ValorTotal {
            get {
                return this.valorTotalField;
            }
            set {
                this.valorTotalField = value;
            }
        }
        
        /// <remarks/>
        public bool FgProcessado {
            get {
                return this.fgProcessadoField;
            }
            set {
                this.fgProcessadoField = value;
            }
        }
        
        /// <remarks/>
        public int IdPedido {
            get {
                return this.idPedidoField;
            }
            set {
                this.idPedidoField = value;
            }
        }
        
        /// <remarks/>
        public string MensagemRetorno {
            get {
                return this.mensagemRetornoField;
            }
            set {
                this.mensagemRetornoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void RegistrarVendaCompletedEventHandler(object sender, RegistrarVendaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegistrarVendaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegistrarVendaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Retorno Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Retorno)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
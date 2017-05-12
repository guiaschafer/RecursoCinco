﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Recurso5.Recurso4 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebApiRecurso4Soap", Namespace="http://tempuri.org/")]
    public partial class WebApiRecurso4 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConcorrerOperationCompleted;
        
        private System.Threading.SendOrPostCallback VisualizarArquivoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SalvarArquivoOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditarArquivoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebApiRecurso4() {
            this.Url = global::Recurso5.Properties.Settings.Default.Recurso5_Recurso4_WebApiRecurso4;
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
        public event ConcorrerCompletedEventHandler ConcorrerCompleted;
        
        /// <remarks/>
        public event VisualizarArquivoCompletedEventHandler VisualizarArquivoCompleted;
        
        /// <remarks/>
        public event SalvarArquivoCompletedEventHandler SalvarArquivoCompleted;
        
        /// <remarks/>
        public event EditarArquivoCompletedEventHandler EditarArquivoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Concorrer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Concorrer(int id, string regiaoCritica, int count) {
            object[] results = this.Invoke("Concorrer", new object[] {
                        id,
                        regiaoCritica,
                        count});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ConcorrerAsync(int id, string regiaoCritica, int count) {
            this.ConcorrerAsync(id, regiaoCritica, count, null);
        }
        
        /// <remarks/>
        public void ConcorrerAsync(int id, string regiaoCritica, int count, object userState) {
            if ((this.ConcorrerOperationCompleted == null)) {
                this.ConcorrerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConcorrerOperationCompleted);
            }
            this.InvokeAsync("Concorrer", new object[] {
                        id,
                        regiaoCritica,
                        count}, this.ConcorrerOperationCompleted, userState);
        }
        
        private void OnConcorrerOperationCompleted(object arg) {
            if ((this.ConcorrerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConcorrerCompleted(this, new ConcorrerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VisualizarArquivo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string VisualizarArquivo() {
            object[] results = this.Invoke("VisualizarArquivo", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void VisualizarArquivoAsync() {
            this.VisualizarArquivoAsync(null);
        }
        
        /// <remarks/>
        public void VisualizarArquivoAsync(object userState) {
            if ((this.VisualizarArquivoOperationCompleted == null)) {
                this.VisualizarArquivoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVisualizarArquivoOperationCompleted);
            }
            this.InvokeAsync("VisualizarArquivo", new object[0], this.VisualizarArquivoOperationCompleted, userState);
        }
        
        private void OnVisualizarArquivoOperationCompleted(object arg) {
            if ((this.VisualizarArquivoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VisualizarArquivoCompleted(this, new VisualizarArquivoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SalvarArquivo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SalvarArquivo() {
            object[] results = this.Invoke("SalvarArquivo", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SalvarArquivoAsync() {
            this.SalvarArquivoAsync(null);
        }
        
        /// <remarks/>
        public void SalvarArquivoAsync(object userState) {
            if ((this.SalvarArquivoOperationCompleted == null)) {
                this.SalvarArquivoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSalvarArquivoOperationCompleted);
            }
            this.InvokeAsync("SalvarArquivo", new object[0], this.SalvarArquivoOperationCompleted, userState);
        }
        
        private void OnSalvarArquivoOperationCompleted(object arg) {
            if ((this.SalvarArquivoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SalvarArquivoCompleted(this, new SalvarArquivoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EditarArquivo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string EditarArquivo() {
            object[] results = this.Invoke("EditarArquivo", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EditarArquivoAsync() {
            this.EditarArquivoAsync(null);
        }
        
        /// <remarks/>
        public void EditarArquivoAsync(object userState) {
            if ((this.EditarArquivoOperationCompleted == null)) {
                this.EditarArquivoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditarArquivoOperationCompleted);
            }
            this.InvokeAsync("EditarArquivo", new object[0], this.EditarArquivoOperationCompleted, userState);
        }
        
        private void OnEditarArquivoOperationCompleted(object arg) {
            if ((this.EditarArquivoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditarArquivoCompleted(this, new EditarArquivoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ConcorrerCompletedEventHandler(object sender, ConcorrerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConcorrerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConcorrerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void VisualizarArquivoCompletedEventHandler(object sender, VisualizarArquivoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VisualizarArquivoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VisualizarArquivoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SalvarArquivoCompletedEventHandler(object sender, SalvarArquivoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SalvarArquivoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SalvarArquivoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void EditarArquivoCompletedEventHandler(object sender, EditarArquivoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditarArquivoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditarArquivoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
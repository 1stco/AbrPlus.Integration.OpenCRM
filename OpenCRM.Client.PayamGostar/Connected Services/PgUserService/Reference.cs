﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PgUserService
{
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperationResult", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PgUserService.UserTelephonySystemInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PgUserService.UserHelperExtensionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PgUserService.UserInfoResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PgUserService.UserInfo))]
    public partial class OperationResult : object
    {
        
        private string MessageField;
        
        private bool SuccessField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success
        {
            get
            {
                return this.SuccessField;
            }
            set
            {
                this.SuccessField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserTelephonySystemInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class UserTelephonySystemInfo : PgUserService.OperationResult
    {
        
        private PgUserService.TelephonySystemInfo[] TelephonySystemsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PgUserService.TelephonySystemInfo[] TelephonySystems
        {
            get
            {
                return this.TelephonySystemsField;
            }
            set
            {
                this.TelephonySystemsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserHelperExtensionInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class UserHelperExtensionInfo : PgUserService.OperationResult
    {
        
        private string HelperExtensionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HelperExtension
        {
            get
            {
                return this.HelperExtensionField;
            }
            set
            {
                this.HelperExtensionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfoResult", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class UserInfoResult : PgUserService.OperationResult
    {
        
        private PgUserService.UserInfoItem[] UsersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PgUserService.UserInfoItem[] Users
        {
            get
            {
                return this.UsersField;
            }
            set
            {
                this.UsersField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class UserInfo : PgUserService.OperationResult
    {
        
        private System.Guid IdField;
        
        private System.Nullable<System.Guid> IdentityIdField;
        
        private PgUserService.LineInfo[] LinesField;
        
        private string NickNameField;
        
        private string TelephonyPasswordField;
        
        private PgUserService.UserGroupInfo[] UserGroupsField;
        
        private string UserKeyField;
        
        private System.Nullable<PgUserService.UserType> UserTypeField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> IdentityId
        {
            get
            {
                return this.IdentityIdField;
            }
            set
            {
                this.IdentityIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PgUserService.LineInfo[] Lines
        {
            get
            {
                return this.LinesField;
            }
            set
            {
                this.LinesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName
        {
            get
            {
                return this.NickNameField;
            }
            set
            {
                this.NickNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelephonyPassword
        {
            get
            {
                return this.TelephonyPasswordField;
            }
            set
            {
                this.TelephonyPasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PgUserService.UserGroupInfo[] UserGroups
        {
            get
            {
                return this.UserGroupsField;
            }
            set
            {
                this.UserGroupsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserKey
        {
            get
            {
                return this.UserKeyField;
            }
            set
            {
                this.UserKeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<PgUserService.UserType> UserType
        {
            get
            {
                return this.UserTypeField;
            }
            set
            {
                this.UserTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LineInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class LineInfo : object
    {
        
        private bool CanReceiveField;
        
        private bool CanSendField;
        
        private System.Guid IdField;
        
        private bool IsActiveField;
        
        private bool IsOnlineField;
        
        private PgUserService.MediaType MediaTypeField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CanReceive
        {
            get
            {
                return this.CanReceiveField;
            }
            set
            {
                this.CanReceiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CanSend
        {
            get
            {
                return this.CanSendField;
            }
            set
            {
                this.CanSendField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive
        {
            get
            {
                return this.IsActiveField;
            }
            set
            {
                this.IsActiveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOnline
        {
            get
            {
                return this.IsOnlineField;
            }
            set
            {
                this.IsOnlineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PgUserService.MediaType MediaType
        {
            get
            {
                return this.MediaTypeField;
            }
            set
            {
                this.MediaTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserGroupInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class UserGroupInfo : object
    {
        
        private string GroupNameField;
        
        private System.Guid IdField;
        
        private string UserKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GroupName
        {
            get
            {
                return this.GroupNameField;
            }
            set
            {
                this.GroupNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserKey
        {
            get
            {
                return this.UserKeyField;
            }
            set
            {
                this.UserKeyField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public enum UserType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Operator = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Supplier = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Customer = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Agent = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Competitor = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelephonySystemInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class TelephonySystemInfo : object
    {
        
        private string BrevityNameField;
        
        private PgUserService.TelephonySystemExtensionInfo[] ExtensionsField;
        
        private string KeyField;
        
        private string NameField;
        
        private System.Guid OfficeIdField;
        
        private string ServerAddressField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BrevityName
        {
            get
            {
                return this.BrevityNameField;
            }
            set
            {
                this.BrevityNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PgUserService.TelephonySystemExtensionInfo[] Extensions
        {
            get
            {
                return this.ExtensionsField;
            }
            set
            {
                this.ExtensionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OfficeId
        {
            get
            {
                return this.OfficeIdField;
            }
            set
            {
                this.OfficeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerAddress
        {
            get
            {
                return this.ServerAddressField;
            }
            set
            {
                this.ServerAddressField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelephonySystemExtensionInfo", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class TelephonySystemExtensionInfo : object
    {
        
        private System.Guid IdField;
        
        private string NameField;
        
        private System.Guid TelephonySystemIdField;
        
        private System.Nullable<System.Guid> UserIdField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid TelephonySystemId
        {
            get
            {
                return this.TelephonySystemIdField;
            }
            set
            {
                this.TelephonySystemIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfoItem", Namespace="http://schemas.datacontract.org/2004/07/Septa.PayamGostar.ServiceLayer.Contract.P" +
        "GContracts.DataContracts")]
    public partial class UserInfoItem : object
    {
        
        private string EmailField;
        
        private System.Guid IdField;
        
        private System.Nullable<System.Guid> IdentityIdField;
        
        private string NickNameField;
        
        private string TelephonyPasswordField;
        
        private string UserKeyField;
        
        private System.Nullable<PgUserService.UserType> UserTypeField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> IdentityId
        {
            get
            {
                return this.IdentityIdField;
            }
            set
            {
                this.IdentityIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName
        {
            get
            {
                return this.NickNameField;
            }
            set
            {
                this.NickNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelephonyPassword
        {
            get
            {
                return this.TelephonyPasswordField;
            }
            set
            {
                this.TelephonyPasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserKey
        {
            get
            {
                return this.UserKeyField;
            }
            set
            {
                this.UserKeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<PgUserService.UserType> UserType
        {
            get
            {
                return this.UserTypeField;
            }
            set
            {
                this.UserTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MediaType", Namespace="http://schemas.datacontract.org/2004/07/SeptaNSFCore.MediaProxy")]
    public enum MediaType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sms = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Email = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fax = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Print = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SocialSms = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PgUserService.IUser")]
    public interface IUser
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        PgUserService.UserInfo GetUser(string userName, string password, string targetUsername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        System.Threading.Tasks.Task<PgUserService.UserInfo> GetUserAsync(string userName, string password, string targetUsername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserByExtension", ReplyAction="http://tempuri.org/IUser/GetUserByExtensionResponse")]
        PgUserService.UserInfo GetUserByExtension(string userName, string password, string telephonyKey, string extension);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserByExtension", ReplyAction="http://tempuri.org/IUser/GetUserByExtensionResponse")]
        System.Threading.Tasks.Task<PgUserService.UserInfo> GetUserByExtensionAsync(string userName, string password, string telephonyKey, string extension);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserByIdentityId", ReplyAction="http://tempuri.org/IUser/GetUserByIdentityIdResponse")]
        PgUserService.UserInfo GetUserByIdentityId(string userName, string password, System.Guid identityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserByIdentityId", ReplyAction="http://tempuri.org/IUser/GetUserByIdentityIdResponse")]
        System.Threading.Tasks.Task<PgUserService.UserInfo> GetUserByIdentityIdAsync(string userName, string password, System.Guid identityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserExtensions", ReplyAction="http://tempuri.org/IUser/GetUserExtensionsResponse")]
        PgUserService.UserTelephonySystemInfo GetUserExtensions(string username, string password, string targetUsername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserExtensions", ReplyAction="http://tempuri.org/IUser/GetUserExtensionsResponse")]
        System.Threading.Tasks.Task<PgUserService.UserTelephonySystemInfo> GetUserExtensionsAsync(string username, string password, string targetUsername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/CheckUserAuthentication", ReplyAction="http://tempuri.org/IUser/CheckUserAuthenticationResponse")]
        bool CheckUserAuthentication(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/CheckUserAuthentication", ReplyAction="http://tempuri.org/IUser/CheckUserAuthenticationResponse")]
        System.Threading.Tasks.Task<bool> CheckUserAuthenticationAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/UpdateTelephonyPassword", ReplyAction="http://tempuri.org/IUser/UpdateTelephonyPasswordResponse")]
        bool UpdateTelephonyPassword(string userName, string password, string targetUsername, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/UpdateTelephonyPassword", ReplyAction="http://tempuri.org/IUser/UpdateTelephonyPasswordResponse")]
        System.Threading.Tasks.Task<bool> UpdateTelephonyPasswordAsync(string userName, string password, string targetUsername, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserHelperExtensionBy", ReplyAction="http://tempuri.org/IUser/GetUserHelperExtensionByResponse")]
        PgUserService.UserHelperExtensionInfo GetUserHelperExtensionBy(string username, string password, string userExtension);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserHelperExtensionBy", ReplyAction="http://tempuri.org/IUser/GetUserHelperExtensionByResponse")]
        System.Threading.Tasks.Task<PgUserService.UserHelperExtensionInfo> GetUserHelperExtensionByAsync(string username, string password, string userExtension);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserList", ReplyAction="http://tempuri.org/IUser/GetUserListResponse")]
        PgUserService.UserInfoResult GetUserList(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserList", ReplyAction="http://tempuri.org/IUser/GetUserListResponse")]
        System.Threading.Tasks.Task<PgUserService.UserInfoResult> GetUserListAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/ResendRecoverPasswordEmail", ReplyAction="http://tempuri.org/IUser/ResendRecoverPasswordEmailResponse")]
        bool ResendRecoverPasswordEmail(string userName, string password, string targetUsername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/ResendRecoverPasswordEmail", ReplyAction="http://tempuri.org/IUser/ResendRecoverPasswordEmailResponse")]
        System.Threading.Tasks.Task<bool> ResendRecoverPasswordEmailAsync(string userName, string password, string targetUsername);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IUserChannel : PgUserService.IUser, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<PgUserService.IUser>, PgUserService.IUser
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserClient() : 
                base(UserClient.GetDefaultBinding(), UserClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUser.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserClient(EndpointConfiguration endpointConfiguration) : 
                base(UserClient.GetBindingForEndpoint(endpointConfiguration), UserClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public PgUserService.UserInfo GetUser(string userName, string password, string targetUsername)
        {
            return base.Channel.GetUser(userName, password, targetUsername);
        }
        
        public System.Threading.Tasks.Task<PgUserService.UserInfo> GetUserAsync(string userName, string password, string targetUsername)
        {
            return base.Channel.GetUserAsync(userName, password, targetUsername);
        }
        
        public PgUserService.UserInfo GetUserByExtension(string userName, string password, string telephonyKey, string extension)
        {
            return base.Channel.GetUserByExtension(userName, password, telephonyKey, extension);
        }
        
        public System.Threading.Tasks.Task<PgUserService.UserInfo> GetUserByExtensionAsync(string userName, string password, string telephonyKey, string extension)
        {
            return base.Channel.GetUserByExtensionAsync(userName, password, telephonyKey, extension);
        }
        
        public PgUserService.UserInfo GetUserByIdentityId(string userName, string password, System.Guid identityId)
        {
            return base.Channel.GetUserByIdentityId(userName, password, identityId);
        }
        
        public System.Threading.Tasks.Task<PgUserService.UserInfo> GetUserByIdentityIdAsync(string userName, string password, System.Guid identityId)
        {
            return base.Channel.GetUserByIdentityIdAsync(userName, password, identityId);
        }
        
        public PgUserService.UserTelephonySystemInfo GetUserExtensions(string username, string password, string targetUsername)
        {
            return base.Channel.GetUserExtensions(username, password, targetUsername);
        }
        
        public System.Threading.Tasks.Task<PgUserService.UserTelephonySystemInfo> GetUserExtensionsAsync(string username, string password, string targetUsername)
        {
            return base.Channel.GetUserExtensionsAsync(username, password, targetUsername);
        }
        
        public bool CheckUserAuthentication(string userName, string password)
        {
            return base.Channel.CheckUserAuthentication(userName, password);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAuthenticationAsync(string userName, string password)
        {
            return base.Channel.CheckUserAuthenticationAsync(userName, password);
        }
        
        public bool UpdateTelephonyPassword(string userName, string password, string targetUsername, string newPassword)
        {
            return base.Channel.UpdateTelephonyPassword(userName, password, targetUsername, newPassword);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateTelephonyPasswordAsync(string userName, string password, string targetUsername, string newPassword)
        {
            return base.Channel.UpdateTelephonyPasswordAsync(userName, password, targetUsername, newPassword);
        }
        
        public PgUserService.UserHelperExtensionInfo GetUserHelperExtensionBy(string username, string password, string userExtension)
        {
            return base.Channel.GetUserHelperExtensionBy(username, password, userExtension);
        }
        
        public System.Threading.Tasks.Task<PgUserService.UserHelperExtensionInfo> GetUserHelperExtensionByAsync(string username, string password, string userExtension)
        {
            return base.Channel.GetUserHelperExtensionByAsync(username, password, userExtension);
        }
        
        public PgUserService.UserInfoResult GetUserList(string username, string password)
        {
            return base.Channel.GetUserList(username, password);
        }
        
        public System.Threading.Tasks.Task<PgUserService.UserInfoResult> GetUserListAsync(string username, string password)
        {
            return base.Channel.GetUserListAsync(username, password);
        }
        
        public bool ResendRecoverPasswordEmail(string userName, string password, string targetUsername)
        {
            return base.Channel.ResendRecoverPasswordEmail(userName, password, targetUsername);
        }
        
        public System.Threading.Tasks.Task<bool> ResendRecoverPasswordEmailAsync(string userName, string password, string targetUsername)
        {
            return base.Channel.ResendRecoverPasswordEmailAsync(userName, password, targetUsername);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUser))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUser))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.11.9/Services/API/IUser.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUser);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUser);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUser,
        }
    }
}

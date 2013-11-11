using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NodeApi.NodeMailer
{
    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public interface ITransportOptions
    {

    }


    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class TransportOptions : ITransportOptions
    {
        [ScriptName("host")]
        public string Host;
        [ScriptName("secureConnection")]
        public bool SecureConnection;
        [ScriptName("port")]
        public int Port;
        [ScriptName("auth")]
        public AuthDetails Auth;
        public TransportOptions(string host,bool secureconnection,int port, AuthDetails auth)
        {
            Host = host;
            SecureConnection = secureconnection;
            Port = port;
            Auth = auth;
        }
    }


    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class ServiceTransportOptions : ITransportOptions
    {
        [ScriptName("service")]
        public string Service;
        [ScriptName("auth")]
        public AuthDetails Auth;
        public ServiceTransportOptions(string service, AuthDetails auth)
        {
            Service = service;
            Auth = auth;
        }
    }

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class AuthDetails {
        [ScriptName("user")]
        public string User;
        [ScriptName("pass")]
        public string Pass;
        public AuthDetails(string user, string pass){
            this.User = user; this.Pass = pass;
        }
    }
}

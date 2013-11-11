// MongoClient.cs
// Script#/Libraries/Node/Mongo
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NodeApi.NodeMailer {

    [Imported]
    [IgnoreNamespace]
    [GlobalMethods]
    public static class NodeMailer {

        public static SMTPTransport createTransport(TransportTypes type, ITransportOptions options) { return null; }
       
    }

    [NamedValues]
    public enum TransportTypes
    {
        Sendmail,
        SMTP,
        SES,

    }
}

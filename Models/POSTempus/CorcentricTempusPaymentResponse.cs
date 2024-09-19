﻿namespace tempus.service.core.api.Models.POSTempus
{
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using tempus.service.core.api.Models.Abstract;

    [XmlRoot("TTMESSAGE")]
    public class CorcentricTempusPaymentResponse : TempusPaymentResponse
    {
        public string TTMSGTRANSUCCESS { get; set; }
        public string TTMSGTRANRESPMESSAGE { get; set; }
        public string TTMSGPROFILE { get; set; }
        public string TTMSGCHAINCODE { get; set; }
        public string TTMSGSERVERDATE { get; set; }
        public string TTMSGSERVERTIME { get; set; }
        public CONCENTRICTRANRESP TRANRESP { get; set; }
        public string SESSIONID { get; set; }
    }

    public class CONCENTRICTRANRESP
    {
        public string RESPTYPE { get; set; }
        public string TRANSUCCESS { get; set; }
        public string TRANRESPMESSAGE { get; set; }
        public string SIGDATA { get; set; }
        public string SIGDATATYPE { get; set; }
        public string INTERACTIVERESPTYPE { get; set; }
    }

}

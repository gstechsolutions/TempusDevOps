﻿namespace tempus.service.core.api.Models.POSTempus
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;


    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "TTMESSAGE")]
    public class InteractiveCancelTempusResponse
    {
        [XmlElement(ElementName = "TTMSGTRANSUCCESS")]
        public bool TTMSGTRANSUCCESS { get; set; }

        [XmlElement(ElementName = "TTMSGTRANRESPMESSAGE")]
        public string TTMSGTRANRESPMESSAGE { get; set; }

        [XmlElement(ElementName = "TTMSGPROFILE")]
        public string TTMSGPROFILE { get; set; }

        [XmlElement(ElementName = "TTMSGCHAINCODE")]
        public string TTMSGCHAINCODE { get; set; }

        [XmlElement(ElementName = "TTMSGSERVERDATE")]
        public string TTMSGSERVERDATE { get; set; }

        [XmlElement(ElementName = "TTMSGSERVERTIME")]
        public string TTMSGSERVERTIME { get; set; }

        [XmlArray("TTMESSAGEERRORS")]
        [XmlArrayItem("TTMESSAGEERROR")]
        public List<INTERACTIVETTMESSAGEERROR> TTMESSAGEERRORS { get; set; }

        [XmlElement(ElementName = "TRANRESP")]
        public INTERACTIVETRANRESP TRANRESP { get; set; }

        [XmlElement(ElementName = "SESSIONID")]
        public Guid SESSIONID { get; set; }
    }

    public class INTERACTIVETTMESSAGEERROR
    {
        [XmlElement(ElementName = "ERRORCODE")]
        public int ERRORCODE { get; set; }

        [XmlElement(ElementName = "ERRORDESCRIPTION")]
        public string ERRORDESCRIPTION { get; set; }
    }

    public class INTERACTIVETRANRESP
    {
        [XmlElement(ElementName = "TRANSUCCESS")]
        public bool TRANSUCCESS { get; set; }

        [XmlElement(ElementName = "TRANRESPMESSAGE")]
        public string TRANRESPMESSAGE { get; set; }

        [XmlElement(ElementName = "PROFILE")]
        public string PROFILE { get; set; }

        [XmlElement(ElementName = "SERVERDATE")]
        public string SERVERDATE { get; set; }

        [XmlElement(ElementName = "SERVERTIME")]
        public string SERVERTIME { get; set; }
    }


    //[XmlRoot(ElementName = "TTMESSAGE")]
    //public class InteractiveCancelTempusResponse
    //{        
    //    public string TTMSGTRANSUCCESS { get; set; }

    //    public string TTMSGTRANRESPMESSAGE { get; set; }

    //    public string TTMSGPROFILE { get; set; }

    //    public string TTMSGCHAINCODE { get; set; }

    //    public string TTMSGSERVERDATE { get; set; }

    //    public string TTMSGSERVERTIME { get; set; }

    //    public List<INTERACTIVETTMESSAGEERROR> TTMESSAGEERRORS { get; set; }

    //    public TRANRESP TRANRESP { get; set; }
    //}

    //public class INTERACTIVETTMESSAGEERROR
    //{

    //    public int ERRORCODE { get; set; }

    //    public string ERRORDESCRIPTION { get; set; }
    //}

    //public class INTERACTIVETRANRESP
    //{        
    //    public string TRANSUCCESS { get; set; }

    //    public string TRANRESPMESSAGE { get; set; }

    //    public string PROFILE { get; set; }

    //    public string SERVERDATE { get; set; }

    //    public string SERVERTIME { get; set; }
    //}

}

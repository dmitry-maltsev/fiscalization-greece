﻿using System;
using System.Xml.Serialization;

namespace Mews.Fiscalization.Greece.Dto.Xsd
{
    [Serializable]
    internal enum StatusCode
    {
        [XmlEnum("Success")]
        Success,
        [XmlEnum("ValidationError")]
        ValidationError,
        [XmlEnum("TechnicalError")]
        TechnicalError,
        [XmlEnum("XMLSyntaxError")]
        XmlSyntaxError
    }
}

﻿using System;
using System.Xml.Serialization;

namespace Mews.Fiscalization.Greece.Dto.Xsd
{
    [Serializable]
    internal enum TransmissionFailure
    {
        [XmlEnum("1")]
        ProviderCommunicationIssue = 1,
        [XmlEnum("2")]
        MyDataCommunicationIssue = 2
    }
}

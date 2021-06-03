﻿using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Irene.Solutions.Edi.Babel.Facturae.V31
{

    [Serializable()]
    [XmlType(Namespace = "http://www.facturae.es/Facturae/2007/v3.1/Facturae")]
    public class TaxOutputType
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public TaxTypeCodeType TaxTypeCode { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TaxRate { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public AmountType TaxableBase { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public AmountType TaxAmount { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public AmountType SpecialTaxableBase { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public AmountType SpecialTaxAmount { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double EquivalenceSurcharge { get; set; }

        [XmlIgnore()]
        public bool EquivalenceSurchargeSpecified { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public AmountType EquivalenceSurchargeAmount { get; set; }

    }
}

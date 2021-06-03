﻿using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Irene.Solutions.Edi.Babel.Facturae.V322
{

    [Serializable()]
    [XmlType(Namespace = "http://www.facturae.gob.es/formato/Versiones/Facturaev3_2_2.xml")]
    public class InvoiceType
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public InvoiceHeaderType InvoiceHeader { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public InvoiceIssueDataType InvoiceIssueData { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Tax", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public TaxOutputType[] TaxesOutputs { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Tax", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public TaxType[] TaxesWithheld { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public InvoiceTotalsType InvoiceTotals { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("InvoiceLine", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public InvoiceLineType[] Items { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Installment", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public InstallmentType[] PaymentDetails { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("LegalReference", Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public string[] LegalLiterals { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public AdditionalDataType AdditionalData { get; set; }

    }
}

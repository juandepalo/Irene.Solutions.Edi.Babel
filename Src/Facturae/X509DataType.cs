﻿/*
    This file is part of the Irene.Solutions.Edi.Babel (R) project.
    Copyright (c) 2019-2020 Irene Solutions SL
    Authors: Irene Solutions SL.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    IRENE SOLUTIONS SL. IRENE SOLUTIONS SL DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS
    
    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.
    
    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the Kivu software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving Irene.Solutions.Edi.Babel services on the fly in a web application, 
    shipping Irene.Solutions.Edi.Babel with a closed source product.
    
    For more information, please contact Irene Solutions SL. at this
    address: info@irenesolutions.com
 */

using System;
using System.Xml.Serialization;

namespace Irene.Solutions.Edi.Babel.Facturae
{

    /// <summary>
    /// Datos del certificado.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class X509DataType
    {

        #region Public Properties

        [XmlElement("X509CRL", DataType = "base64Binary")]
        public byte[] X509CRL { get; set; }

        [XmlElement("X509Certificate")]
        public string X509Certificate { get; set; }

        public X509IssuerSerialType X509IssuerSerial { get; set; }

        public byte[] X509SKI { get; set; }

        public string X509SubjectName { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Representación textual de la instancia de X509DataType.
        /// </summary>
        /// <returns>Representación textual de la instancia de X509DataType.</returns>
        public override string ToString()
        {
            return $"{X509SubjectName}";
        }

        #endregion

    }

}

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
    /// Código numérico que identifica el criterio empleado en cada caso para una rectificación. 
    /// <para>"01" - se reflejan todos los detalles a rectificar de la factura original. </para>
    /// <para>"02" - sólo se anotan los detalles ya rectificados.</para>  
    /// <para>"03" - Rectificación por descuento por volumen de operaciones durante un periodo.</para> 
    /// <para>"04" - Autorizadas por la Agencia Tributaria".</para> 
    /// </summary>
    [Serializable()]
    public enum CorrectionMethodType
    {

        /// <summary>
        /// Se reflejan todos los detalles a rectificar de la factura original.
        /// </summary>
        [XmlEnum("01")]
        RectificacionIntegra,

        /// <summary>
        /// Sólo se anotan los detalles ya rectificados
        /// </summary>
        [XmlEnum("02")]
        RectificacionPorDiferencias,

        /// <summary>
        /// Rectificación por descuento por volumen de operaciones durante un periodo.
        /// </summary>
        [XmlEnum("03")]
        RectificacionPordescuentoPorVolumenDeOperacionesDuranteUnPeriodo,

        /// <summary>
        /// Autorizadas por la Agencia Tributaria
        /// </summary>
        [XmlEnum("04")]
        AutorizadasPorlaAgenciaTributaria,
    }
}

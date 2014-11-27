﻿using JsonLD.Entities;
using VDS.RDF.Writing.Formatting;

namespace Nancy.RDF.Responses
{
    /// <summary>
    /// Serializer for RDF/XML format
    /// </summary>
    public class RdfXmlSerializer : RdfSerializer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RdfXmlSerializer"/> class.
        /// </summary>
        public RdfXmlSerializer(IContextProvider contextProvider)
            : base(RdfSerialization.RdfXml, contextProvider)
        {
        }

        /// <summary>
        /// Creates the triple formatter for RDF/XML.
        /// </summary>
        protected override ITripleFormatter CreateFormatter()
        {
            return new RdfXmlFormatter();
        }
    }
}

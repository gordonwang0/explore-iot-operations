/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class SetMetadataConfigurationRequestPayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command request argument.
        /// </summary>
        [JsonPropertyName("SetMetadataConfiguration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public SetMetadataConfiguration SetMetadataConfiguration { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (SetMetadataConfiguration is null)
            {
                throw new ArgumentNullException("SetMetadataConfiguration field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (SetMetadataConfiguration is null)
            {
                throw new ArgumentNullException("SetMetadataConfiguration field cannot be null");
            }
        }
    }
}

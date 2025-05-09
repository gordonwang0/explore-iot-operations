/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class AudioSourceConfigurationOptions : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// Tokens of the audio source the configuration can be used for.
        /// </summary>
        [JsonPropertyName("InputTokensAvailable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public List<string> InputTokensAvailable { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (InputTokensAvailable is null)
            {
                throw new ArgumentNullException("InputTokensAvailable field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (InputTokensAvailable is null)
            {
                throw new ArgumentNullException("InputTokensAvailable field cannot be null");
            }
        }
    }
}

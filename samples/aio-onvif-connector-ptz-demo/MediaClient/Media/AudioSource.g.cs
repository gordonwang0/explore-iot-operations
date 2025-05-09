/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class AudioSource : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// Number of available audio channels. (1: mono, 2: stereo)
        /// </summary>
        [JsonPropertyName("Channels")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public int Channels { get; set; } = default!;

        /// <summary>
        /// Unique identifier referencing the physical entity.
        /// </summary>
        [JsonPropertyName("Token")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public string Token { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (Token is null)
            {
                throw new ArgumentNullException("Token field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (Token is null)
            {
                throw new ArgumentNullException("Token field cannot be null");
            }
        }
    }
}

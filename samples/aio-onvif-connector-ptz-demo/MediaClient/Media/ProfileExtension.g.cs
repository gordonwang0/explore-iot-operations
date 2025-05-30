/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class ProfileExtension
    {
        /// <summary>
        /// Optional configuration of the Audio decoder.
        /// </summary>
        [JsonPropertyName("AudioDecoderConfiguration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AudioDecoderConfiguration? AudioDecoderConfiguration { get; set; } = default;

        /// <summary>
        /// Optional configuration of the Audio output.
        /// </summary>
        [JsonPropertyName("AudioOutputConfiguration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AudioOutputConfiguration? AudioOutputConfiguration { get; set; } = default;

    }
}

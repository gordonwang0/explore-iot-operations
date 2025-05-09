/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class VideoEncoderConfigurationOptions : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The 'Extension' Field.
        /// </summary>
        [JsonPropertyName("Extension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public VideoEncoderConfigurationOptionsExtension? Extension { get; set; } = default;

        /// <summary>
        /// Indicates the support for the GuaranteedFrameRate attribute on the VideoEncoderConfiguration element.
        /// </summary>
        [JsonPropertyName("GuaranteedFrameRateSupported")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool? GuaranteedFrameRateSupported { get; set; } = default;

        /// <summary>
        /// Optional H264 encoder settings ranges (See also Extension element).
        /// </summary>
        [JsonPropertyName("H264")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public H264options? H264 { get; set; } = default;

        /// <summary>
        /// Optional JPEG encoder settings ranges (See also Extension element).
        /// </summary>
        [JsonPropertyName("JPEG")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public JpegOptions? Jpeg { get; set; } = default;

        /// <summary>
        /// Optional MPEG4 encoder settings ranges (See also Extension element).
        /// </summary>
        [JsonPropertyName("MPEG4")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Mpeg4options? Mpeg4 { get; set; } = default;

        /// <summary>
        /// Supported range for the quality factor.
        /// </summary>
        [JsonPropertyName("QualityRange")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public IntRange QualityRange { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (QualityRange is null)
            {
                throw new ArgumentNullException("QualityRange field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (QualityRange is null)
            {
                throw new ArgumentNullException("QualityRange field cannot be null");
            }
        }
    }
}

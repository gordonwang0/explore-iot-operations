/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class ContinuousMoveRequestPayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command request argument.
        /// </summary>
        [JsonPropertyName("ContinuousMove")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public Object_Onvif_Ptz_ContinuousMove__1 ContinuousMove { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (ContinuousMove is null)
            {
                throw new ArgumentNullException("ContinuousMove field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (ContinuousMove is null)
            {
                throw new ArgumentNullException("ContinuousMove field cannot be null");
            }
        }
    }
}

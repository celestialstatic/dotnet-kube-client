using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     ClientIPConfig represents the configurations of Client IP based session affinity.
    /// </summary>
    [KubeObject("ClientIPConfig", "v1")]
    public partial class ClientIPConfigV1
    {
        /// <summary>
        ///     timeoutSeconds specifies the seconds of ClientIP type session sticky time. The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).
        /// </summary>
        [JsonProperty("timeoutSeconds")]
        public int TimeoutSeconds { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     FSGroupStrategyOptions defines the strategy type and options used to create the strategy.
    /// </summary>
    [KubeObject("FSGroupStrategyOptions", "v1beta1")]
    public partial class FSGroupStrategyOptionsV1Beta1
    {
        /// <summary>
        ///     Rule is the strategy that will dictate what FSGroup is used in the SecurityContext.
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; }

        /// <summary>
        ///     Ranges are the allowed ranges of fs groups.  If you would like to force a single fs group then supply a single range with the same start and end.
        /// </summary>
        [JsonProperty("ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<IDRangeV1Beta1> Ranges { get; set; } = new List<IDRangeV1Beta1>();
    }
}

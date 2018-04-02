using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.
    /// </summary>
    [KubeObject("ResourceMetricSource", "v2beta1")]
    public partial class ResourceMetricSourceV2Beta1
    {
        /// <summary>
        ///     name is the name of the resource in question.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     targetAverageValue is the target value of the average of the resource metric across all relevant pods, as a raw value (instead of as a percentage of the request), similar to the "pods" metric source type.
        /// </summary>
        [JsonProperty("targetAverageValue")]
        public string TargetAverageValue { get; set; }

        /// <summary>
        ///     targetAverageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.
        /// </summary>
        [JsonProperty("targetAverageUtilization")]
        public int TargetAverageUtilization { get; set; }
    }
}

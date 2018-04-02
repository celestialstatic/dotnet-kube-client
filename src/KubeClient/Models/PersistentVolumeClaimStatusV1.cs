using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     PersistentVolumeClaimStatus is the current status of a persistent volume claim.
    /// </summary>
    [KubeObject("PersistentVolumeClaimStatus", "v1")]
    public partial class PersistentVolumeClaimStatusV1
    {
        /// <summary>
        ///     Phase represents the current phase of PersistentVolumeClaim.
        /// </summary>
        [JsonProperty("phase")]
        public string Phase { get; set; }

        /// <summary>
        ///     AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
        /// </summary>
        [JsonProperty("accessModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessModes { get; set; } = new List<string>();

        /// <summary>
        ///     Current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to 'ResizeStarted'.
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PersistentVolumeClaimConditionV1> Conditions { get; set; } = new List<PersistentVolumeClaimConditionV1>();

        /// <summary>
        ///     Represents the actual resources of the underlying volume.
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Capacity { get; set; } = new Dictionary<string, string>();
    }
}

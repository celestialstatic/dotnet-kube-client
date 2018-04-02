using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    [KubeObject("AzureFilePersistentVolumeSource", "v1")]
    public partial class AzureFilePersistentVolumeSourceV1
    {
        /// <summary>
        ///     the name of secret that contains Azure Storage Account Name and Key
        /// </summary>
        [JsonProperty("secretName")]
        public string SecretName { get; set; }

        /// <summary>
        ///     the namespace of the secret that contains Azure Storage Account Name and Key default is the same as the Pod
        /// </summary>
        [JsonProperty("secretNamespace")]
        public string SecretNamespace { get; set; }

        /// <summary>
        ///     Share Name
        /// </summary>
        [JsonProperty("shareName")]
        public string ShareName { get; set; }

        /// <summary>
        ///     Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }
}

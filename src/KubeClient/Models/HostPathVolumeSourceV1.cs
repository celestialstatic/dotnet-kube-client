using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     Represents a host path mapped into a pod. Host path volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    [KubeObject("HostPathVolumeSource", "v1")]
    public partial class HostPathVolumeSourceV1
    {
        /// <summary>
        ///     Type for HostPath Volume Defaults to "" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Path of the directory on the host. If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}

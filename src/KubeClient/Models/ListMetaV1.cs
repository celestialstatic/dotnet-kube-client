using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.
    /// </summary>
    [KubeObject("ListMeta", "v1")]
    public partial class ListMetaV1
    {
        /// <summary>
        ///     continue may be set if the user set a limit on the number of items returned, and indicates that the server has more data available. The value is opaque and may be used to issue another request to the endpoint that served this list to retrieve the next set of available objects. Continuing a list may not be possible if the server configuration has changed or more than a few minutes have passed. The resourceVersion field returned when using this continue value will be identical to the value in the first response.
        /// </summary>
        [JsonProperty("continue")]
        public string Continue { get; set; }

        /// <summary>
        ///     selfLink is a URL representing this object. Populated by the system. Read-only.
        /// </summary>
        [JsonProperty("selfLink")]
        public string SelfLink { get; set; }

        /// <summary>
        ///     String that identifies the server's internal version of this object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        [JsonProperty("resourceVersion")]
        public string ResourceVersion { get; set; }
    }
}

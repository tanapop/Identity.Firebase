﻿using Newtonsoft.Json;

namespace Aguacongas.Firebase
{
    /// <summary>
    /// Collection of Firebase index
    /// </summary>
    public class FirebaseIndexes
    {
        /// <summary>
        /// Gets or sets the .indexOn property
        /// </summary>
        [JsonProperty(PropertyName = ".indexOn")]
        public string[] On { get; set; }
    }

    /// <summary>
    /// Firebase index
    /// </summary>
    public class FirebaseIndex
    {
        /// <summary>
        /// Gets or sets the .indexOn property
        /// </summary>
        [JsonProperty(PropertyName = ".indexOn")]
        public string On { get; set; }
    }
}

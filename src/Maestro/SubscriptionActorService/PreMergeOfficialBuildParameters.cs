// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Asset = Maestro.Contracts.Asset;

namespace SubscriptionActorService
{
    [DataContract]
    public class PreMergeOfficialBuildParameters
    {
        [DataMember]
        public Guid SubscriptionId { get; set; }

        [DataMember]
        public string Account { get; set; }

        [DataMember]
        public string Project { get; set; }

        [DataMember]
        public int Definition { get; set; }

        [DataMember]
        public long BuildId { get; set; }

        [DataMember]
        public string UpdatesBranch { get; set; }
    }
}

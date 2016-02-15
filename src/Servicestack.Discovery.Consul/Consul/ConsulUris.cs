// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
namespace ServiceStack.Discovery.Consul
{
    using System;

    public static class ConsulUris
    {
        public const string LocalAgent = "http://127.0.0.1:8500";

        public static readonly Func<string, string> DeregisterService = serviceId => $"{LocalAgent}/v1/agent/service/deregister/{serviceId}";

        public static readonly string GetServices = $"{LocalAgent}/v1/agent/services";
    }
}
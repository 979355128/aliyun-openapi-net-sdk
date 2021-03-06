/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeConcernNecessityResponseUnmarshaller
    {
        public static DescribeConcernNecessityResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConcernNecessityResponse describeConcernNecessityResponse = new DescribeConcernNecessityResponse();

			describeConcernNecessityResponse.HttpResponse = context.HttpResponse;
			describeConcernNecessityResponse.RequestId = context.StringValue("DescribeConcernNecessity.RequestId");

			List<string> describeConcernNecessityResponse_concernNecessity = new List<string>();
			for (int i = 0; i < context.Length("DescribeConcernNecessity.ConcernNecessity.Length"); i++) {
				describeConcernNecessityResponse_concernNecessity.Add(context.StringValue("DescribeConcernNecessity.ConcernNecessity["+ i +"]"));
			}
			describeConcernNecessityResponse.ConcernNecessity = describeConcernNecessityResponse_concernNecessity;
        
			return describeConcernNecessityResponse;
        }
    }
}

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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class CreateSmartAccessGatewaySoftwareRequest : RpcAcsRequest<CreateSmartAccessGatewaySoftwareResponse>
    {
        public CreateSmartAccessGatewaySoftwareRequest()
            : base("Smartag", "2018-03-13", "CreateSmartAccessGatewaySoftware", "smartag", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private int? period;

		private bool? autoPay;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? userCount;

		private string chargeType;

		private long? ownerId;

		private long? dataPlan;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? UserCount
		{
			get
			{
				return userCount;
			}
			set	
			{
				userCount = value;
				DictionaryUtil.Add(QueryParameters, "UserCount", value.ToString());
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public long? DataPlan
		{
			get
			{
				return dataPlan;
			}
			set	
			{
				dataPlan = value;
				DictionaryUtil.Add(QueryParameters, "DataPlan", value.ToString());
			}
		}

        public override CreateSmartAccessGatewaySoftwareResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSmartAccessGatewaySoftwareResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

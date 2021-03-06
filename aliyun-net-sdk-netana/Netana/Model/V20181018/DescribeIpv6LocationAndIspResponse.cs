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

namespace Aliyun.Acs.Netana.Model.V20181018
{
	public class DescribeIpv6LocationAndIspResponse : AcsResponse
	{

		private string requestId;

		private string ipAddress;

		private string country;

		private string city;

		private string iSP;

		private string countryCode;

		private string cityCode;

		private string iSPCode;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string IpAddress
		{
			get
			{
				return ipAddress;
			}
			set	
			{
				ipAddress = value;
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
			}
		}

		public string ISP
		{
			get
			{
				return iSP;
			}
			set	
			{
				iSP = value;
			}
		}

		public string CountryCode
		{
			get
			{
				return countryCode;
			}
			set	
			{
				countryCode = value;
			}
		}

		public string CityCode
		{
			get
			{
				return cityCode;
			}
			set	
			{
				cityCode = value;
			}
		}

		public string ISPCode
		{
			get
			{
				return iSPCode;
			}
			set	
			{
				iSPCode = value;
			}
		}
	}
}

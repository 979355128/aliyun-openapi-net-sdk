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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetRecordOssUploadParamResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private string ossAccessKeyId;

		private string policy;

		private string signature;

		private string expires;

		private string dir;

		private string host;

		private string ossFileName;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string OssAccessKeyId
		{
			get
			{
				return ossAccessKeyId;
			}
			set	
			{
				ossAccessKeyId = value;
			}
		}

		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
			}
		}

		public string Signature
		{
			get
			{
				return signature;
			}
			set	
			{
				signature = value;
			}
		}

		public string Expires
		{
			get
			{
				return expires;
			}
			set	
			{
				expires = value;
			}
		}

		public string Dir
		{
			get
			{
				return dir;
			}
			set	
			{
				dir = value;
			}
		}

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
			}
		}

		public string OssFileName
		{
			get
			{
				return ossFileName;
			}
			set	
			{
				ossFileName = value;
			}
		}
	}
}

﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using System.Collections.Generic;

namespace Smartsheet.Api.Internal
{
    using Api.Models;
    using Smartsheet.Api.Internal.Util;
    using Smartsheet.Api.OAuth;
    using System;
    using System.Text;

    /// <summary>
    /// This is the implementation of TokenResources.
    /// 
    /// Thread Safety: This class is thread safe because it is immutable and its base class is thread safe.
    /// </summary>
    public class TokenResourcesImpl : AbstractResources, TokenResources
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="smartsheet"> the SmartsheetImpl </param>
        /// <exception cref="InvalidOperationException">if any argument is null</exception>
        public TokenResourcesImpl(SmartsheetImpl smartsheet)
            : base(smartsheet)
        {
        }

        /// <summary>
        /// <para> Please use OAuthFlowBuilder class to build an instance of an OAuthFlow class. </para>
        /// <para> Will throw exception. </para>
        /// <para>It mirrors to the following Smartsheet REST API method: POST /token</para>
        /// </summary>
        /// <exception cref="System.NotSupportedException"> This exception is always thrown since this operation is not supported by the Token Resources.
        /// Instead, see OAuthFlow. </exception>
        public virtual void GetAccessToken()
        {
            throw new System.NotSupportedException("Please use the OAuthFlow class to get an access token.");
        }

        /// <summary>
        /// <para> Please use OAuthFlowBuilder class to build an instance of an OAuthFlow class. </para>
        /// <para> Will throw exception. </para>
        /// <para>It mirrors to the following Smartsheet REST API method: POST /token</para>
        /// </summary>
        /// <exception cref="System.NotSupportedException"> This exception is always thrown since this operation is not supported by the Token Resources.
        /// Instead, see OAuthFlow. </exception>
        public virtual void RefreshAccessToken()
        {
            throw new System.NotSupportedException("Please use the OAuthFlow class to refresh an access token.");
        }

        /// <summary>
        /// <para>Revokes the access token used to make this request. The access token will no longer be valid, and subsequent API calls made using the token will fail.</para>
        /// <para>It mirrors to the following Smartsheet REST API method:<br />
        /// DELETE /token</para>
        /// </summary>
        /// 
        /// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
        /// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
        /// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
        /// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
        /// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
        /// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
        public virtual void RevokeAccessToken(bool? deleteAllForApiClient)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            if (deleteAllForApiClient != null)
            {
                parameters.Add("deleteAllForApiClient", deleteAllForApiClient.ToString());
            }
            this.DeleteResource<Token>("token" + QueryUtil.GenerateUrl(null, parameters), typeof(Token));
        }
    }

}
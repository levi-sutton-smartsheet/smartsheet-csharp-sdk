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
    using System.Text;

    /// <summary>
    /// This is the implementation of the TemplateResources.
    /// 
    /// Thread Safety: This class is thread safe because it is immutable and its base class is thread safe.
    /// </summary>
    public class TemplateResourcesImpl : AbstractResources, TemplateResources
    {

        /// <summary>
        /// Constructor.
        /// 
        /// Exceptions: - IllegalArgumentException : if any argument is
        /// </summary>
        /// <param name="smartsheet"> the Smartsheet </param>
        public TemplateResourcesImpl(SmartsheetImpl smartsheet) : base(smartsheet)
        {
        }

        /// <summary>
        /// <para>Gets the list of public Templates to which the user has access.</para>
        /// <remarks>This operation supports pagination of results. For more information, see Paging.</remarks>
        /// <para>It mirrors to the following Smartsheet REST API method: GET /templates/public</para>
        /// </summary>
        /// <returns> the list of Templates (note that an empty list will be returned if there are none). </returns>
        /// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
        /// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
        /// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
        /// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
        /// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
        /// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
        public virtual PaginatedResult<Template> ListPublicTemplates(PaginationParameters? paging)
        {
            StringBuilder path = new StringBuilder("templates/public");
            if (paging != null)
            {
                path.Append(paging.ToQueryString());
            }
            return this.ListResourcesWithWrapper<Template>(path.ToString());
        }

        /// <summary>
        /// <para>Gets the list of user-created Templates to which the user has access.</para>
        /// <remarks>This operation supports pagination of results. For more information, see Paging.</remarks>
        /// <para>It mirrors to the following Smartsheet REST API method: GET /templates</para>
        /// </summary>
        /// <returns> the list of Templates (note that an empty list will be returned if there are none). </returns>
        /// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
        /// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
        /// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
        /// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
        /// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
        /// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
        public virtual PaginatedResult<Template> ListUserCreatedTemplates(PaginationParameters? paging)
        {
            StringBuilder path = new StringBuilder("templates");
            if (paging != null)
            {
                path.Append(paging.ToQueryString());
            }
            return this.ListResourcesWithWrapper<Template>(path.ToString());
        }
    }
}
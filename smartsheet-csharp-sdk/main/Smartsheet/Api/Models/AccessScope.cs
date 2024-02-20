//    #[license]
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

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Represents the Type of access that is granted on a given sheet. </summary>
    /// <seealso href="http://www.Smartsheet.com/developers/Api-documentation#h.89hb3ivv7eum">Access Scopes Help</seealso>
    public enum AccessScope
    {
        /// <summary>
        /// Read sheets access scope
        /// </summary>
        READ_SHEETS,
        /// <summary>
        /// Write sheets access scope
        /// </summary>
        WRITE_SHEETS,
        /// <summary>
        /// share sheets access scope
        /// </summary>
        SHARE_SHEETS,
        /// <summary>
        /// Delete sheets access scope
        /// </summary>
        DELETE_SHEETS,
        /// <summary>
        /// Create sheets access scope
        /// </summary>
        CREATE_SHEETS,
        /// <summary>
        /// Admin users access scope
        /// </summary>
        ADMIN_USERS,
        /// <summary>
        /// Admin sheets access scope
        /// </summary>
        ADMIN_SHEETS,
        /// <summary>
        /// Admin workspaces access scope
        /// </summary>
        ADMIN_WORKSPACES
    }
}
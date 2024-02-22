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
    /// Represents access levels that Users can have. </summary>
    /// <seealso href="http://www.Smartsheet.com/developers/Api-documentation#h.umfgm4xt25dq">Access Level Help</seealso>
    public enum AccessLevel
    {
        /// <summary>
        /// Viewer access level
        /// </summary>
        VIEWER,
        /// <summary>
        /// Editor access level
        /// </summary>
        EDITOR,
        /// <summary>
        /// Editor with share access level
        /// </summary>
        EDITOR_SHARE,
        /// <summary>
        /// Admin access level
        /// </summary>
        ADMIN,
        /// <summary>
        /// Owner access level
        /// </summary>
        OWNER
    }
}
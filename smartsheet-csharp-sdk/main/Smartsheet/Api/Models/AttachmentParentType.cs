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
    /// Represents the attachment parent Type.
    /// </summary>
    public enum AttachmentParentType
    {
        /// <summary>
        /// Attachment parent is a sheet
        /// </summary>
        SHEET,
        /// <summary>
        /// Attachment parent is a row
        /// </summary>
        ROW,
        /// <summary>
        /// Attachment parent is a comment
        /// </summary>
        COMMENT
    }
}
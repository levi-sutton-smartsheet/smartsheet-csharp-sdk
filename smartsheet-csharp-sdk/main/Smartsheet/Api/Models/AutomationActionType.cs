﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2018 SmartsheetClient
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Enum holding all types of automation actions.
    /// </summary>
    public enum AutomationActionType
    {
        /// <summary>
        /// Action is to send notification
        /// </summary>
        NOTIFICATION_ACTION,
        /// <summary>
        /// Action is to request an update
        /// </summary>
        UPDATE_REQUEST_ACTION,
        /// <summary>
        /// Action is to request approval
        /// </summary>
        APPROVAL_REQUEST_ACTION
    }
}

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Represents the Link types.
    /// </summary>
    public enum ScheduleType
    {
        /// <summary>
        /// Schedule only to happen once
        /// </summary>
        ONCE,
        /// <summary>
        /// Schedule to recur daily
        /// </summary>
        DAILY,
        /// <summary>
        /// Schedule to recur weekly
        /// </summary>
        WEEKLY,
        /// <summary>
        /// Schedule to recur monthly
        /// </summary>
        MONTHLY,
        /// <summary>
        /// Schedule to recur yearly
        /// </summary>
        YEARLY
    }
}

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
using System.Text;

namespace Smartsheet.Api.Internal.Utility
{
    /// <summary>
    /// Helper class for building query strings
    /// </summary>
    public sealed class QueryStringBuilder
    {
        private readonly StringBuilder _querryString;
        /// <summary>
        /// Default constructor
        /// </summary>
        public QueryStringBuilder()
        {
            _querryString = new StringBuilder();
        }

        /// <summary>
        /// Add a paramter to the string builder.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddParameter<T>(string name, T value)
        {
            _querryString.AppendFormat(_querryString.Length == 0 ? "?{0}={1}" : "&{0}={1}", name, Uri.EscapeDataString(value.ToString()));
        }
        /// <summary>
        /// Function to get string built by string builder
        /// </summary>
        public string QueryString { get { return _querryString.ToString(); } }

    }
}

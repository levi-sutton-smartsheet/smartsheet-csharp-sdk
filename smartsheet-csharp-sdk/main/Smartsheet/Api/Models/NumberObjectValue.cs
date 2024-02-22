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
using Newtonsoft.Json;

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Implmentation of the number object value type
    /// </summary>
    public class NumberObjectValue : IPrimitiveObjectValue<double>
    {
        /// <summary>
        /// Value held by the object.
        /// </summary>
        private double value;

        /// <summary>
        /// Constructor for taking a double and holding it.
        /// </summary>
        /// <param name="value"></param>
        public NumberObjectValue(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Getter/setter for the numeric value.
        /// </summary>
        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Method to return the type of object this is.
        /// </summary>
        public ObjectValueType ObjectType
        {
            get { return ObjectValueType.NUMBER; }
        }

        /// <summary>
        /// Serialize function that returns nothing but writes object using writer passed in.
        /// </summary>
        /// <param name="writer"></param>
        public void Serialize(JsonWriter writer)
        {
            writer.WriteValue(value);
        }

    }
}

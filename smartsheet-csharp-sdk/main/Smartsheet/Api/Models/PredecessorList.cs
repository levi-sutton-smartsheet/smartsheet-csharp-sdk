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

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Wrapper to encapsulate a list of Predecessors.
    /// </summary>
    public class PredecessorList : ObjectValue
    {
        private IList<Predecessor> predecessors;

        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public PredecessorList() { }
        /// <summary>
        /// Constructor to set list of predecessors on construction.
        /// </summary>
        /// <param name="predecessors"></param>
        public PredecessorList(IList<Predecessor> predecessors)
        {
            this.predecessors = predecessors;
        }

        /// <summary>
        /// Gets the array of Predecessor objects.
        /// </summary>
        /// <returns> the array </returns>
        public IList<Predecessor> Predecessors
        {
            get { return predecessors; }
            set { this.predecessors = value; }
        }

        /// <summary>
        /// Public accessor for what type of object this is.
        /// </summary>
        public ObjectValueType ObjectType
        {
            get { return ObjectValueType.PREDECESSOR_LIST; }
        }
    }
}


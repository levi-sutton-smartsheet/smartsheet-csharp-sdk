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

using System.IO;
using System.Text;
using System.Collections.Generic;
namespace Smartsheet.Api.Internal.Http
{

    /// <summary>
    /// This class represents an HTTP Entity (http://www.w3.org/Protocols/rfc2616/rfc2616-sec7.html).
    /// 
    /// Thread Safety: This class is not thread safe since it's mutable.
    /// </summary>
    public class HttpEntity
    {
        /// <summary>
        /// Represents the content Type.
        /// 
        /// It has a pair of setter/getter (not shown on class diagram for brevity).
        /// </summary>
        private string contentType;

        /// <summary>
        /// Represents the content length.
        /// 
        /// It has a pair of setter/getter (not shown on class diagram for brevity).
        /// </summary>
        private long contentLength;

        /// <summary>
        /// Represents the content as an InputStream.
        /// 
        /// It has a pair of setter/getter (not shown on class diagram for brevity).
        /// </summary>
          //TODO: would be better to have the content in a stream so that all data is not stored in memory.
        private byte[] content;

        /// <summary>
        /// Gets the content Type.
        /// </summary>
        /// <returns> the content Type </returns>
        public string ContentType
        {
            get { return contentType; }
            set { contentType = value; }
        }

        /// <summary>
        /// Gets the content length.
        /// </summary>
        /// <returns> the content length </returns>
        public long ContentLength
        {
            get { return contentLength; }
            set { contentLength = value; }
        }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <returns> the content </returns>
        public byte[] Content
        {
            get { return content; }
            set { content = value; }
        }
        
        /// <summary>
        /// Gets the content as a stream
        /// </summary>
        /// <returns></returns>
        public StreamReader GetContent()
        {
            if (content == null) { content = new byte[0]; }

            return new StreamReader(new MemoryStream(content));
        }

        /// <summary>
        /// Helper method to get content as a string
        /// </summary>
        /// <returns></returns>
        public string GetContentAsString() 
        {
            StreamReader reader = this.GetContent();
            string line;
    
            List<string> lines = new List<string>();

            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return string.Concat(lines);
        }

        /// <summary>
        /// Get content in the form of a binary reader
        /// </summary>
        /// <returns></returns>
        public BinaryReader GetBinaryContent()
        {
            if (content == null) { content = new byte[0]; }

            return new BinaryReader(new MemoryStream(content));
        }
    }
}
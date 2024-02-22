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
    /// Represents the contents of the widget. </summary>
    /// <seealso href="http://smartsheet-platform.github.io/api-docs/#widgetcontent-object">Widget Content Help</seealso>
    public enum WidgetType
    {
        /// <summary>
        /// ChartWidgetContent object
        /// </summary>
        CHART,

        /// <summary>
        /// ImageWidgetContent object
        /// </summary>
        IMAGE,

        /// <summary>
        /// CellLinkWidgetContent object
        /// </summary>
        METRIC,

        /// <summary>
        /// ReportWidgetContent object
        /// </summary>
        GRIDGANTT,

        /// <summary>
        /// RichTextWidgetContent object
        /// </summary>
        RICHTEXT,

        /// <summary>
        /// ShortcutWidgetContent object
        /// </summary>
        SHORTCUT,

        /// <summary>
        /// TitleWidgetContent object
        /// </summary>
        TITLE,

        /// <summary>
        /// WebContent object
        /// </summary>
        WEBCONTENT,
        
        /// NOTE: These are level=0 widget types that should be supported for now
        
        /// <summary>
        /// SHORTCUTLIST, SHORTCUTICON (both now SHORTCUT) decode to ShortcutWidgetContent object
        /// </summary>
        SHORTCUTLIST,
        /// <summary>
        /// SHORTCUTLIST, SHORTCUTICON (both now SHORTCUT) decode to ShortcutWidgetContent object
        /// </summary>
        SHORTCUTICON,

        /// <summary>
        /// SHEETSUMMARY (is now METRIC) decodes to CellLinkWidgetContent object
        /// </summary>
        SHEETSUMMARY
    }
}

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

namespace Smartsheet.Api.Models
{
    /// <summary>
    /// Class encapsulating a duration object value.
    /// </summary>
    public class Duration : ObjectValue
    {
        /// <summary>
        /// Default/empty constructor.
        /// </summary>
        public Duration() {}

        /// <summary>
        /// Constructor that takes time in weeks, days, hours, minutes, seconds, and milliseconds. 
        /// There is also a boolean for negative and elapsed.
        /// </summary>
        /// <param name="negative"></param>
        /// <param name="elapsed"></param>
        /// <param name="weeks"></param>
        /// <param name="days"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <param name="milliseconds"></param>
        public Duration(bool negative, bool elapsed, double weeks, double days, double hours, double minutes, 
            double seconds, double milliseconds)
        {
            this.negative = negative;
            this.elapsed = elapsed;
            this.weeks = weeks;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            this.milliseconds = milliseconds;
        }

        /// <summary>
        /// The number of days for this duration.
        /// </summary>
        private double? days;

        /// <summary>
        /// If true, indicates this duration represents elapsed time, which ignores non-working time.
        /// </summary>
        private bool? elapsed;

        /// <summary>
        /// The number of hours for this duration.
        /// </summary>
        private double? hours;

        /// <summary>
        /// The number of milliseconds for this duration.
        /// </summary>
        private double? milliseconds;

        /// <summary>
        /// The number of minutes for this duration.
        /// </summary>
        private double? minutes;

        /// <summary>
        /// When used as a predecessor’s lag value, indicates whether the lag is negative (if true), or positive (false).
        /// </summary>
        private bool? negative;

        /// <summary>
        /// The number of seconds for this duration.
        /// </summary>
        private double? seconds;

        /// <summary>
        /// The number of weeks for this duration.
        /// </summary>
        private double? weeks;

        /// <summary>
        /// The number of days for this duration.
        /// </summary>
        /// <returns> the number of days in duration </returns>
        public double? Days
        {
            get { return days; }
            set { days = value; }
        }

        /// <summary>
        /// If true, indicates this duration represents elapsed time, which ignores non-working time.
        /// </summary>
        /// <returns> the elapsed flag </returns>
        public bool? Elapsed
        {
            get { return elapsed; }
            set { elapsed = value; }
        }

        /// <summary>
        /// The number of hours for this duration.
        /// </summary>
        /// <returns> the number of hours in duration </returns>
        public double? Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        /// <summary>
        /// The number of milliseconds for this duration.
        /// </summary>
        /// <returns> the number of milliseconds in duration </returns>
        public double? Milliseconds
        {
            get { return milliseconds; }
            set { milliseconds = value; }
        }
        /// <summary>
        /// The number of minutes for this duration.
        /// </summary>
        /// <returns> the number of minutes in duration </returns>
        public double? Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        /// <summary>
        /// When used as a predecessor’s lag value, indicates whether the lag is negative (if true), or positive (false).
        /// </summary>
        /// <returns> the negative flag </returns>
        public bool? Negative
        {
            get { return negative; }
            set { negative = value; }
        }

        /// <summary>
        /// The number of seconds for this duration.
        /// </summary>
        /// <returns> the number of seconds in duration </returns>
        public double? Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        /// <summary>
        /// The number of weeks for this duration.
        /// </summary>
        /// <returns> the number of weeks in duration </returns>
        public double? Weeks
        {
            get { return weeks; }
            set { weeks = value; }
        }

        /// <summary>
        /// Method to return the type of object this is.
        /// </summary>
        public ObjectValueType ObjectType
        {
            get { return ObjectValueType.DURATION; }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Log Settings for Firewall. </summary>
    public partial class LogSettings
    {
        /// <summary> Initializes a new instance of LogSettings. </summary>
        public LogSettings()
        {
        }

        /// <summary> Initializes a new instance of LogSettings. </summary>
        /// <param name="logType"> One of possible log type. </param>
        /// <param name="logOption"> Log option SAME/INDIVIDUAL. </param>
        /// <param name="applicationInsights"> Application Insight details. </param>
        /// <param name="commonDestination"> Common destination configurations. </param>
        /// <param name="trafficLogDestination"> Traffic destination configurations. </param>
        /// <param name="threatLogDestination"> Threat destination configurations. </param>
        /// <param name="decryptLogDestination"> Decrypt destination configurations. </param>
        internal LogSettings(LogType? logType, LogOption? logOption, ApplicationInsights applicationInsights, LogDestination commonDestination, LogDestination trafficLogDestination, LogDestination threatLogDestination, LogDestination decryptLogDestination)
        {
            LogType = logType;
            LogOption = logOption;
            ApplicationInsights = applicationInsights;
            CommonDestination = commonDestination;
            TrafficLogDestination = trafficLogDestination;
            ThreatLogDestination = threatLogDestination;
            DecryptLogDestination = decryptLogDestination;
        }

        /// <summary> One of possible log type. </summary>
        public LogType? LogType { get; set; }
        /// <summary> Log option SAME/INDIVIDUAL. </summary>
        public LogOption? LogOption { get; set; }
        /// <summary> Application Insight details. </summary>
        public ApplicationInsights ApplicationInsights { get; set; }
        /// <summary> Common destination configurations. </summary>
        public LogDestination CommonDestination { get; set; }
        /// <summary> Traffic destination configurations. </summary>
        public LogDestination TrafficLogDestination { get; set; }
        /// <summary> Threat destination configurations. </summary>
        public LogDestination ThreatLogDestination { get; set; }
        /// <summary> Decrypt destination configurations. </summary>
        public LogDestination DecryptLogDestination { get; set; }
    }
}

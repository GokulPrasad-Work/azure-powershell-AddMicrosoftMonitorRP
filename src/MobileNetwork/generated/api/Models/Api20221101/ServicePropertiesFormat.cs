// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Service properties.</summary>
    public partial class ServicePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal
    {

        /// <summary>Downlink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string MaximumBitRateDownlink { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).MaximumBitRateDownlink; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).MaximumBitRateDownlink = value ?? null; }

        /// <summary>Uplink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string MaximumBitRateUplink { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).MaximumBitRateUplink; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).MaximumBitRateUplink = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServiceQoPolicyMaximumBitRate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal.ServiceQoPolicyMaximumBitRate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).MaximumBitRate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).MaximumBitRate = value; }

        /// <summary>Internal Acessors for ServiceQosPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicy Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal.ServiceQosPolicy { get => (this._serviceQosPolicy = this._serviceQosPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.QosPolicy()); set { {_serviceQosPolicy = value;} } }

        /// <summary>Backing field for <see cref="PccRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration[] _pccRule;

        /// <summary>The set of data flow policy rules that make up this service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration[] PccRule { get => this._pccRule; set => this._pccRule = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the service resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ServicePrecedence" /> property.</summary>
        private int _servicePrecedence;

        /// <summary>
        /// A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM.
        /// A lower value means a higher priority. This value should be unique among all services configured in the mobile network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public int ServicePrecedence { get => this._servicePrecedence; set => this._servicePrecedence = value; }

        /// <summary>
        /// QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority,
        /// if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority.
        /// If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full
        /// description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public int? ServiceQoPolicyAllocationAndRetentionPriorityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).AllocationAndRetentionPriorityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).AllocationAndRetentionPriorityLevel = value ?? default(int); }

        /// <summary>
        /// QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This
        /// must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values
        /// are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full
        /// description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public int? ServiceQoPolicyFiveQi { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).FiveQi; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).FiveQi = value ?? default(int); }

        /// <summary>
        /// QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow
        /// with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability? ServiceQoPolicyPreemptionCapability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).PreemptionCapability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).PreemptionCapability = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability)""); }

        /// <summary>
        /// QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by
        /// a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability? ServiceQoPolicyPreemptionVulnerability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).PreemptionVulnerability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)ServiceQosPolicy).PreemptionVulnerability = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability)""); }

        /// <summary>Backing field for <see cref="ServiceQosPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicy _serviceQosPolicy;

        /// <summary>
        /// The QoS policy to use for packets matching this service. This can be overridden for particular flows using the ruleQosPolicy
        /// field in a PccRuleConfiguration. If this field is null then the UE's SIM policy will define the QoS settings.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicy ServiceQosPolicy { get => (this._serviceQosPolicy = this._serviceQosPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.QosPolicy()); set => this._serviceQosPolicy = value; }

        /// <summary>Creates an new <see cref="ServicePropertiesFormat" /> instance.</summary>
        public ServicePropertiesFormat()
        {

        }
    }
    /// Service properties.
    public partial interface IServicePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>Downlink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Downlink bit rate.",
        SerializedName = @"downlink",
        PossibleTypes = new [] { typeof(string) })]
        string MaximumBitRateDownlink { get; set; }
        /// <summary>Uplink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uplink bit rate.",
        SerializedName = @"uplink",
        PossibleTypes = new [] { typeof(string) })]
        string MaximumBitRateUplink { get; set; }
        /// <summary>The set of data flow policy rules that make up this service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The set of data flow policy rules that make up this service.",
        SerializedName = @"pccRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration[] PccRule { get; set; }
        /// <summary>The provisioning state of the service resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the service resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM.
        /// A lower value means a higher priority. This value should be unique among all services configured in the mobile network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all services configured in the mobile network.",
        SerializedName = @"servicePrecedence",
        PossibleTypes = new [] { typeof(int) })]
        int ServicePrecedence { get; set; }
        /// <summary>
        /// QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority,
        /// if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority.
        /// If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full
        /// description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.",
        SerializedName = @"allocationAndRetentionPriorityLevel",
        PossibleTypes = new [] { typeof(int) })]
        int? ServiceQoPolicyAllocationAndRetentionPriorityLevel { get; set; }
        /// <summary>
        /// QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This
        /// must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values
        /// are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full
        /// description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.",
        SerializedName = @"5qi",
        PossibleTypes = new [] { typeof(int) })]
        int? ServiceQoPolicyFiveQi { get; set; }
        /// <summary>
        /// QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow
        /// with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.",
        SerializedName = @"preemptionCapability",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability? ServiceQoPolicyPreemptionCapability { get; set; }
        /// <summary>
        /// QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by
        /// a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.",
        SerializedName = @"preemptionVulnerability",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability? ServiceQoPolicyPreemptionVulnerability { get; set; }

    }
    /// Service properties.
    internal partial interface IServicePropertiesFormatInternal

    {
        /// <summary>Downlink bit rate.</summary>
        string MaximumBitRateDownlink { get; set; }
        /// <summary>Uplink bit rate.</summary>
        string MaximumBitRateUplink { get; set; }
        /// <summary>The set of data flow policy rules that make up this service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration[] PccRule { get; set; }
        /// <summary>The provisioning state of the service resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM.
        /// A lower value means a higher priority. This value should be unique among all services configured in the mobile network.
        /// </summary>
        int ServicePrecedence { get; set; }
        /// <summary>
        /// QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority,
        /// if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority.
        /// If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full
        /// description of the ARP parameters.
        /// </summary>
        int? ServiceQoPolicyAllocationAndRetentionPriorityLevel { get; set; }
        /// <summary>
        /// QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This
        /// must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values
        /// are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full
        /// description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
        /// </summary>
        int? ServiceQoPolicyFiveQi { get; set; }
        /// <summary>
        /// The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr ServiceQoPolicyMaximumBitRate { get; set; }
        /// <summary>
        /// QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow
        /// with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability? ServiceQoPolicyPreemptionCapability { get; set; }
        /// <summary>
        /// QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by
        /// a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability? ServiceQoPolicyPreemptionVulnerability { get; set; }
        /// <summary>
        /// The QoS policy to use for packets matching this service. This can be overridden for particular flows using the ruleQosPolicy
        /// field in a PccRuleConfiguration. If this field is null then the UE's SIM policy will define the QoS settings.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicy ServiceQosPolicy { get; set; }

    }
}
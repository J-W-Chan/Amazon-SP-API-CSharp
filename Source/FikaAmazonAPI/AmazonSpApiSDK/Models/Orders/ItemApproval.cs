﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// Generic item approval. Check the applicable restrictions at the specific approval type schemas.
    /// </summary>
    [DataContract]
    public partial class ItemApproval : IEquatable<ItemApproval>, IValidatableObject
    {
        /// <summary>
        /// High level actors involved in the approval process.
        /// </summary>
        /// <value>High level actors involved in the approval process.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActorEnum
        {

            /// <summary>
            /// Enum SELLINGPARTNER for value: SELLING_PARTNER
            /// </summary>
            [EnumMember(Value = "SELLING_PARTNER")]
            SELLINGPARTNER = 1,

            /// <summary>
            /// Enum AMAZON for value: AMAZON
            /// </summary>
            [EnumMember(Value = "AMAZON")]
            AMAZON = 2
        }

        /// <summary>
        /// High level actors involved in the approval process.
        /// </summary>
        /// <value>High level actors involved in the approval process.</value>
        [DataMember(Name = "Actor", EmitDefaultValue = false)]
        public ActorEnum Actor { get; set; }
        /// <summary>
        /// Status of approval action.
        /// </summary>
        /// <value>Status of approval action.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApprovalActionProcessStatusEnum
        {

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING = 1,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 2,

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3
        }

        /// <summary>
        /// Status of approval action.
        /// </summary>
        /// <value>Status of approval action.</value>
        [DataMember(Name = "ApprovalActionProcessStatus", EmitDefaultValue = false)]
        public ApprovalActionProcessStatusEnum ApprovalActionProcessStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApproval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemApproval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApproval" /> class.
        /// </summary>
        /// <param name="sequenceId">Sequence number of the item approval. Each ItemApproval gets its sequenceId automatically from a monotonic increasing function. (required).</param>
        /// <param name="timestamp">Timestamp when the ItemApproval was recorded by Amazon&#39;s internal order approvals system. In ISO 8601 date time format. (required).</param>
        /// <param name="actor">High level actors involved in the approval process. (required).</param>
        /// <param name="approver">Person or system that triggers the approval actions on behalf of the actor..</param>
        /// <param name="approvalAction">Approval action that defines the behavior of the ItemApproval. (required).</param>
        /// <param name="approvalActionProcessStatus">Status of approval action. (required).</param>
        /// <param name="approvalActionProcessStatusMessage">Optional message to communicate optional additional context about the current status of the approval action..</param>
        public ItemApproval(int? sequenceId = default(int?), string timestamp = default(string), ActorEnum actor = default(ActorEnum), string approver = default(string), ItemApprovalAction approvalAction = default(ItemApprovalAction), ApprovalActionProcessStatusEnum approvalActionProcessStatus = default(ApprovalActionProcessStatusEnum), string approvalActionProcessStatusMessage = default(string))
        {
            // to ensure "sequenceId" is required (not null)
            if (sequenceId == null)
            {
                throw new InvalidDataException("sequenceId is a required property for ItemApproval and cannot be null");
            }
            else
            {
                this.SequenceId = sequenceId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for ItemApproval and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "actor" is required (not null)
            if (actor == null)
            {
                throw new InvalidDataException("actor is a required property for ItemApproval and cannot be null");
            }
            else
            {
                this.Actor = actor;
            }
            // to ensure "approvalAction" is required (not null)
            if (approvalAction == null)
            {
                throw new InvalidDataException("approvalAction is a required property for ItemApproval and cannot be null");
            }
            else
            {
                this.ApprovalAction = approvalAction;
            }
            // to ensure "approvalActionProcessStatus" is required (not null)
            if (approvalActionProcessStatus == null)
            {
                throw new InvalidDataException("approvalActionProcessStatus is a required property for ItemApproval and cannot be null");
            }
            else
            {
                this.ApprovalActionProcessStatus = approvalActionProcessStatus;
            }
            this.Approver = approver;
            this.ApprovalActionProcessStatusMessage = approvalActionProcessStatusMessage;
        }

        /// <summary>
        /// Sequence number of the item approval. Each ItemApproval gets its sequenceId automatically from a monotonic increasing function.
        /// </summary>
        /// <value>Sequence number of the item approval. Each ItemApproval gets its sequenceId automatically from a monotonic increasing function.</value>
        [DataMember(Name = "SequenceId", EmitDefaultValue = false)]
        public int? SequenceId { get; set; }

        /// <summary>
        /// Timestamp when the ItemApproval was recorded by Amazon&#39;s internal order approvals system. In ISO 8601 date time format.
        /// </summary>
        /// <value>Timestamp when the ItemApproval was recorded by Amazon&#39;s internal order approvals system. In ISO 8601 date time format.</value>
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
        public string Timestamp { get; set; }


        /// <summary>
        /// Person or system that triggers the approval actions on behalf of the actor.
        /// </summary>
        /// <value>Person or system that triggers the approval actions on behalf of the actor.</value>
        [DataMember(Name = "Approver", EmitDefaultValue = false)]
        public string Approver { get; set; }

        /// <summary>
        /// Approval action that defines the behavior of the ItemApproval.
        /// </summary>
        /// <value>Approval action that defines the behavior of the ItemApproval.</value>
        [DataMember(Name = "ApprovalAction", EmitDefaultValue = false)]
        public ItemApprovalAction ApprovalAction { get; set; }


        /// <summary>
        /// Optional message to communicate optional additional context about the current status of the approval action.
        /// </summary>
        /// <value>Optional message to communicate optional additional context about the current status of the approval action.</value>
        [DataMember(Name = "ApprovalActionProcessStatusMessage", EmitDefaultValue = false)]
        public string ApprovalActionProcessStatusMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemApproval {\n");
            sb.Append("  SequenceId: ").Append(SequenceId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  Approver: ").Append(Approver).Append("\n");
            sb.Append("  ApprovalAction: ").Append(ApprovalAction).Append("\n");
            sb.Append("  ApprovalActionProcessStatus: ").Append(ApprovalActionProcessStatus).Append("\n");
            sb.Append("  ApprovalActionProcessStatusMessage: ").Append(ApprovalActionProcessStatusMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemApproval);
        }

        /// <summary>
        /// Returns true if ItemApproval instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApproval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApproval input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SequenceId == input.SequenceId ||
                    (this.SequenceId != null &&
                    this.SequenceId.Equals(input.SequenceId))
                ) &&
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) &&
                (
                    this.Actor == input.Actor ||
                    (this.Actor != null &&
                    this.Actor.Equals(input.Actor))
                ) &&
                (
                    this.Approver == input.Approver ||
                    (this.Approver != null &&
                    this.Approver.Equals(input.Approver))
                ) &&
                (
                    this.ApprovalAction == input.ApprovalAction ||
                    (this.ApprovalAction != null &&
                    this.ApprovalAction.Equals(input.ApprovalAction))
                ) &&
                (
                    this.ApprovalActionProcessStatus == input.ApprovalActionProcessStatus ||
                    (this.ApprovalActionProcessStatus != null &&
                    this.ApprovalActionProcessStatus.Equals(input.ApprovalActionProcessStatus))
                ) &&
                (
                    this.ApprovalActionProcessStatusMessage == input.ApprovalActionProcessStatusMessage ||
                    (this.ApprovalActionProcessStatusMessage != null &&
                    this.ApprovalActionProcessStatusMessage.Equals(input.ApprovalActionProcessStatusMessage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SequenceId != null)
                    hashCode = hashCode * 59 + this.SequenceId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Actor != null)
                    hashCode = hashCode * 59 + this.Actor.GetHashCode();
                if (this.Approver != null)
                    hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.ApprovalAction != null)
                    hashCode = hashCode * 59 + this.ApprovalAction.GetHashCode();
                if (this.ApprovalActionProcessStatus != null)
                    hashCode = hashCode * 59 + this.ApprovalActionProcessStatus.GetHashCode();
                if (this.ApprovalActionProcessStatusMessage != null)
                    hashCode = hashCode * 59 + this.ApprovalActionProcessStatusMessage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
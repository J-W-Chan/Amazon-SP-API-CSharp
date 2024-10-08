/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Contains the type and rate of tax.
    /// </summary>
    [DataContract]
    public partial class TaxRate :  IEquatable<TaxRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRate" /> class.
        /// </summary>
        /// <param name="cessRate">Rate of cess tax..</param>
        /// <param name="gstRate">Rate of gst tax..</param>
        /// <param name="taxType">Type of tax. Can be: CGST, SGST, IGST, TOTAL_TAX.</param>
        public TaxRate(double? cessRate = default(double?), double? gstRate = default(double?), TaxType? taxType = default(TaxType?))
        {
            this.CessRate = cessRate;
            this.GstRate = gstRate;
            this.TaxType = taxType;
        }
        
        /// <summary>
        /// Rate of cess tax.
        /// </summary>
        /// <value>Rate of cess tax.</value>
        [DataMember(Name="cessRate", EmitDefaultValue=false)]
        public double? CessRate { get; set; }

        /// <summary>
        /// Rate of gst tax.
        /// </summary>
        /// <value>Rate of gst tax.</value>
        [DataMember(Name="gstRate", EmitDefaultValue=false)]
        public double? GstRate { get; set; }

        /// <summary>
        /// Type of tax. Can be: CGST, SGST, IGST, TOTAL_TAX.
        /// </summary>
        /// <value>Type of tax. Can be: CGST, SGST, IGST, TOTAL_TAX.</value>
        [DataMember(Name="taxType", EmitDefaultValue=false)]
        public TaxType? TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRate {\n");
            sb.Append("  CessRate: ").Append(CessRate).Append("\n");
            sb.Append("  GstRate: ").Append(GstRate).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as TaxRate);
        }

        /// <summary>
        /// Returns true if TaxRate instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CessRate == input.CessRate ||
                    (this.CessRate != null &&
                    this.CessRate.Equals(input.CessRate))
                ) && 
                (
                    this.GstRate == input.GstRate ||
                    (this.GstRate != null &&
                    this.GstRate.Equals(input.GstRate))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.CessRate != null)
                    hashCode = hashCode * 59 + this.CessRate.GetHashCode();
                if (this.GstRate != null)
                    hashCode = hashCode * 59 + this.GstRate.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
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

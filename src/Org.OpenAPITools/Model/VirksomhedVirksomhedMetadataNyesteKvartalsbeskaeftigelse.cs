/*
 * cvr.dev API dokumentation
 *
 * # Introduktion Velkommen til [cvr.dev](https://cvr.dev)'s HTTP API dokumentation.  Dette dokument beskriver, hvordan du kan benytte vores API til at hente CVR-data. Vi henter og cacher data fra Virks CVR-database en gang i minuttet, så vi altid kan levere så nøjagtig data som muligt.  Udover at være beskrevet på denne sige, er vores API også [beskrevet i OpenAPI 3.0 format](https://docs.cvr.dev/cvrdev_openapi.yml) og som [Postman-dokumentation](https://documenter.getpostman.com/view/13435475/TVejiqUr).  For at benytte vores API skal du have en [cvr.dev-konto](https://cvr.dev/#/auth/signup) med et aktivt abonnement, som du kan [prøve gratis de første 30 dage](https://cvr.dev/#/prices). 
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse
    /// </summary>
    [DataContract(Name = "Virksomhed_virksomhedMetadata_nyesteKvartalsbeskaeftigelse")]
    public partial class VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse" /> class.
        /// </summary>
        /// <param name="aar">aar (required).</param>
        /// <param name="antalAarsvaerk">antalAarsvaerk (required).</param>
        /// <param name="antalAnsatte">antalAnsatte (required).</param>
        /// <param name="intervalKodeAntalAarsvaerk">intervalKodeAntalAarsvaerk (required).</param>
        /// <param name="intervalKodeAntalAnsatte">intervalKodeAntalAnsatte (required).</param>
        /// <param name="kvartal">kvartal (required).</param>
        /// <param name="sidstOpdateret">Seneste tidspunkt hvor dette objekt blev opdateret  (required).</param>
        public VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse(long aar = default(long), long? antalAarsvaerk = default(long?), long? antalAnsatte = default(long?), string intervalKodeAntalAarsvaerk = default(string), string intervalKodeAntalAnsatte = default(string), int kvartal = default(int), string sidstOpdateret = default(string))
        {
            this.Aar = aar;
            // to ensure "antalAarsvaerk" is required (not null)
            if (antalAarsvaerk == null)
            {
                throw new ArgumentNullException("antalAarsvaerk is a required property for VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse and cannot be null");
            }
            this.AntalAarsvaerk = antalAarsvaerk;
            // to ensure "antalAnsatte" is required (not null)
            if (antalAnsatte == null)
            {
                throw new ArgumentNullException("antalAnsatte is a required property for VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse and cannot be null");
            }
            this.AntalAnsatte = antalAnsatte;
            // to ensure "intervalKodeAntalAarsvaerk" is required (not null)
            if (intervalKodeAntalAarsvaerk == null)
            {
                throw new ArgumentNullException("intervalKodeAntalAarsvaerk is a required property for VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse and cannot be null");
            }
            this.IntervalKodeAntalAarsvaerk = intervalKodeAntalAarsvaerk;
            // to ensure "intervalKodeAntalAnsatte" is required (not null)
            if (intervalKodeAntalAnsatte == null)
            {
                throw new ArgumentNullException("intervalKodeAntalAnsatte is a required property for VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse and cannot be null");
            }
            this.IntervalKodeAntalAnsatte = intervalKodeAntalAnsatte;
            this.Kvartal = kvartal;
            // to ensure "sidstOpdateret" is required (not null)
            if (sidstOpdateret == null)
            {
                throw new ArgumentNullException("sidstOpdateret is a required property for VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse and cannot be null");
            }
            this.SidstOpdateret = sidstOpdateret;
        }

        /// <summary>
        /// Gets or Sets Aar
        /// </summary>
        /// <example>2014</example>
        [DataMember(Name = "aar", IsRequired = true, EmitDefaultValue = true)]
        public long Aar { get; set; }

        /// <summary>
        /// Gets or Sets AntalAarsvaerk
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "antalAarsvaerk", IsRequired = true, EmitDefaultValue = true)]
        public long? AntalAarsvaerk { get; set; }

        /// <summary>
        /// Gets or Sets AntalAnsatte
        /// </summary>
        /// <example>15</example>
        [DataMember(Name = "antalAnsatte", IsRequired = true, EmitDefaultValue = true)]
        public long? AntalAnsatte { get; set; }

        /// <summary>
        /// Gets or Sets IntervalKodeAntalAarsvaerk
        /// </summary>
        /// <example>ANTAL_0_0</example>
        [DataMember(Name = "intervalKodeAntalAarsvaerk", IsRequired = true, EmitDefaultValue = true)]
        public string IntervalKodeAntalAarsvaerk { get; set; }

        /// <summary>
        /// Gets or Sets IntervalKodeAntalAnsatte
        /// </summary>
        /// <example>ANTAL_2_4</example>
        [DataMember(Name = "intervalKodeAntalAnsatte", IsRequired = true, EmitDefaultValue = true)]
        public string IntervalKodeAntalAnsatte { get; set; }

        /// <summary>
        /// Gets or Sets Kvartal
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "kvartal", IsRequired = true, EmitDefaultValue = true)]
        public int Kvartal { get; set; }

        /// <summary>
        /// Seneste tidspunkt hvor dette objekt blev opdateret 
        /// </summary>
        /// <value>Seneste tidspunkt hvor dette objekt blev opdateret </value>
        /// <example>2020-04-08T00:10:47.000Z</example>
        [DataMember(Name = "sidstOpdateret", IsRequired = true, EmitDefaultValue = true)]
        public string SidstOpdateret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse {\n");
            sb.Append("  Aar: ").Append(Aar).Append("\n");
            sb.Append("  AntalAarsvaerk: ").Append(AntalAarsvaerk).Append("\n");
            sb.Append("  AntalAnsatte: ").Append(AntalAnsatte).Append("\n");
            sb.Append("  IntervalKodeAntalAarsvaerk: ").Append(IntervalKodeAntalAarsvaerk).Append("\n");
            sb.Append("  IntervalKodeAntalAnsatte: ").Append(IntervalKodeAntalAnsatte).Append("\n");
            sb.Append("  Kvartal: ").Append(Kvartal).Append("\n");
            sb.Append("  SidstOpdateret: ").Append(SidstOpdateret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

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
    /// VirksomhedVirksomhedMetadataNyesteBibranche1
    /// </summary>
    [DataContract(Name = "Virksomhed_virksomhedMetadata_nyesteBibranche1")]
    public partial class VirksomhedVirksomhedMetadataNyesteBibranche1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedVirksomhedMetadataNyesteBibranche1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VirksomhedVirksomhedMetadataNyesteBibranche1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedVirksomhedMetadataNyesteBibranche1" /> class.
        /// </summary>
        /// <param name="branchekode">Numerisk id, der identificerer en branche  (required).</param>
        /// <param name="branchetekst">Tekststreng, der beskriver en branche  (required).</param>
        /// <param name="periode">periode (required).</param>
        /// <param name="sidstOpdateret">Seneste tidspunkt hvor dette objekt blev opdateret  (required).</param>
        public VirksomhedVirksomhedMetadataNyesteBibranche1(string branchekode = default(string), string branchetekst = default(string), Periode periode = default(Periode), string sidstOpdateret = default(string))
        {
            // to ensure "branchekode" is required (not null)
            if (branchekode == null)
            {
                throw new ArgumentNullException("branchekode is a required property for VirksomhedVirksomhedMetadataNyesteBibranche1 and cannot be null");
            }
            this.Branchekode = branchekode;
            // to ensure "branchetekst" is required (not null)
            if (branchetekst == null)
            {
                throw new ArgumentNullException("branchetekst is a required property for VirksomhedVirksomhedMetadataNyesteBibranche1 and cannot be null");
            }
            this.Branchetekst = branchetekst;
            // to ensure "periode" is required (not null)
            if (periode == null)
            {
                throw new ArgumentNullException("periode is a required property for VirksomhedVirksomhedMetadataNyesteBibranche1 and cannot be null");
            }
            this.Periode = periode;
            // to ensure "sidstOpdateret" is required (not null)
            if (sidstOpdateret == null)
            {
                throw new ArgumentNullException("sidstOpdateret is a required property for VirksomhedVirksomhedMetadataNyesteBibranche1 and cannot be null");
            }
            this.SidstOpdateret = sidstOpdateret;
        }

        /// <summary>
        /// Numerisk id, der identificerer en branche 
        /// </summary>
        /// <value>Numerisk id, der identificerer en branche </value>
        /// <example>342000</example>
        [DataMember(Name = "branchekode", IsRequired = true, EmitDefaultValue = true)]
        public string Branchekode { get; set; }

        /// <summary>
        /// Tekststreng, der beskriver en branche 
        /// </summary>
        /// <value>Tekststreng, der beskriver en branche </value>
        /// <example>Udvikling og konsulentbistand i forbindelse med software</example>
        [DataMember(Name = "branchetekst", IsRequired = true, EmitDefaultValue = true)]
        public string Branchetekst { get; set; }

        /// <summary>
        /// Gets or Sets Periode
        /// </summary>
        [DataMember(Name = "periode", IsRequired = true, EmitDefaultValue = true)]
        public Periode Periode { get; set; }

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
            sb.Append("class VirksomhedVirksomhedMetadataNyesteBibranche1 {\n");
            sb.Append("  Branchekode: ").Append(Branchekode).Append("\n");
            sb.Append("  Branchetekst: ").Append(Branchetekst).Append("\n");
            sb.Append("  Periode: ").Append(Periode).Append("\n");
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

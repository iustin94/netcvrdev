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
    /// En opsummering af den gældende information vedrørende virksomheden. Dette er meget ofte denne information, man ønsker at benytte. 
    /// </summary>
    [DataContract(Name = "Virksomhed_virksomhedMetadata")]
    public partial class VirksomhedVirksomhedMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedVirksomhedMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VirksomhedVirksomhedMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedVirksomhedMetadata" /> class.
        /// </summary>
        /// <param name="antalPenheder">antalPenheder (required).</param>
        /// <param name="nyesteAarsbeskaeftigelse">nyesteAarsbeskaeftigelse (required).</param>
        /// <param name="nyesteBeliggenhedsadresse">nyesteBeliggenhedsadresse (required).</param>
        /// <param name="nyesteBibranche1">nyesteBibranche1 (required).</param>
        /// <param name="nyesteBibranche2">nyesteBibranche2 (required).</param>
        /// <param name="nyesteBibranche3">nyesteBibranche3 (required).</param>
        /// <param name="nyesteBinavne">nyesteBinavne.</param>
        /// <param name="nyesteErstMaanedsbeskaeftigelse">nyesteErstMaanedsbeskaeftigelse.</param>
        /// <param name="nyesteHovedbranche">nyesteHovedbranche (required).</param>
        /// <param name="nyesteKontaktoplysninger">Kan indeholde enhver form for kontaktoplysning, e.g. email adresse, telefonnummer, postadresse.  (required).</param>
        /// <param name="nyesteKvartalsbeskaeftigelse">nyesteKvartalsbeskaeftigelse (required).</param>
        /// <param name="nyesteMaanedsbeskaeftigelse">nyesteMaanedsbeskaeftigelse (required).</param>
        /// <param name="nyesteNavn">nyesteNavn (required).</param>
        /// <param name="nyesteStatus">nyesteStatus (required).</param>
        /// <param name="nyesteVirksomhedsform">nyesteVirksomhedsform (required).</param>
        public VirksomhedVirksomhedMetadata(long antalPenheder = default(long), VirksomhedVirksomhedMetadataNyesteAarsbeskaeftigelse nyesteAarsbeskaeftigelse = default(VirksomhedVirksomhedMetadataNyesteAarsbeskaeftigelse), VirksomhedVirksomhedMetadataNyesteBeliggenhedsadresse nyesteBeliggenhedsadresse = default(VirksomhedVirksomhedMetadataNyesteBeliggenhedsadresse), VirksomhedVirksomhedMetadataNyesteBibranche1 nyesteBibranche1 = default(VirksomhedVirksomhedMetadataNyesteBibranche1), VirksomhedVirksomhedMetadataNyesteBibranche1 nyesteBibranche2 = default(VirksomhedVirksomhedMetadataNyesteBibranche1), VirksomhedVirksomhedMetadataNyesteBibranche1 nyesteBibranche3 = default(VirksomhedVirksomhedMetadataNyesteBibranche1), List<string> nyesteBinavne = default(List<string>), VirksomhedVirksomhedMetadataNyesteErstMaanedsbeskaeftigelse nyesteErstMaanedsbeskaeftigelse = default(VirksomhedVirksomhedMetadataNyesteErstMaanedsbeskaeftigelse), VirksomhedVirksomhedMetadataNyesteBibranche1 nyesteHovedbranche = default(VirksomhedVirksomhedMetadataNyesteBibranche1), List<string> nyesteKontaktoplysninger = default(List<string>), VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse nyesteKvartalsbeskaeftigelse = default(VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse), VirksomhedVirksomhedMetadataNyesteMaanedsbeskaeftigelse nyesteMaanedsbeskaeftigelse = default(VirksomhedVirksomhedMetadataNyesteMaanedsbeskaeftigelse), VirksomhedVirksomhedMetadataNyesteNavn nyesteNavn = default(VirksomhedVirksomhedMetadataNyesteNavn), VirksomhedVirksomhedMetadataNyesteStatus nyesteStatus = default(VirksomhedVirksomhedMetadataNyesteStatus), VirksomhedVirksomhedMetadataNyesteVirksomhedsform nyesteVirksomhedsform = default(VirksomhedVirksomhedMetadataNyesteVirksomhedsform))
        {
            this.AntalPenheder = antalPenheder;
            // to ensure "nyesteAarsbeskaeftigelse" is required (not null)
            if (nyesteAarsbeskaeftigelse == null)
            {
                throw new ArgumentNullException("nyesteAarsbeskaeftigelse is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteAarsbeskaeftigelse = nyesteAarsbeskaeftigelse;
            // to ensure "nyesteBeliggenhedsadresse" is required (not null)
            if (nyesteBeliggenhedsadresse == null)
            {
                throw new ArgumentNullException("nyesteBeliggenhedsadresse is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteBeliggenhedsadresse = nyesteBeliggenhedsadresse;
            // to ensure "nyesteBibranche1" is required (not null)
            if (nyesteBibranche1 == null)
            {
                throw new ArgumentNullException("nyesteBibranche1 is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteBibranche1 = nyesteBibranche1;
            // to ensure "nyesteBibranche2" is required (not null)
            if (nyesteBibranche2 == null)
            {
                throw new ArgumentNullException("nyesteBibranche2 is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteBibranche2 = nyesteBibranche2;
            // to ensure "nyesteBibranche3" is required (not null)
            if (nyesteBibranche3 == null)
            {
                throw new ArgumentNullException("nyesteBibranche3 is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteBibranche3 = nyesteBibranche3;
            // to ensure "nyesteHovedbranche" is required (not null)
            if (nyesteHovedbranche == null)
            {
                throw new ArgumentNullException("nyesteHovedbranche is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteHovedbranche = nyesteHovedbranche;
            // to ensure "nyesteKontaktoplysninger" is required (not null)
            if (nyesteKontaktoplysninger == null)
            {
                throw new ArgumentNullException("nyesteKontaktoplysninger is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteKontaktoplysninger = nyesteKontaktoplysninger;
            // to ensure "nyesteKvartalsbeskaeftigelse" is required (not null)
            if (nyesteKvartalsbeskaeftigelse == null)
            {
                throw new ArgumentNullException("nyesteKvartalsbeskaeftigelse is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteKvartalsbeskaeftigelse = nyesteKvartalsbeskaeftigelse;
            // to ensure "nyesteMaanedsbeskaeftigelse" is required (not null)
            if (nyesteMaanedsbeskaeftigelse == null)
            {
                throw new ArgumentNullException("nyesteMaanedsbeskaeftigelse is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteMaanedsbeskaeftigelse = nyesteMaanedsbeskaeftigelse;
            // to ensure "nyesteNavn" is required (not null)
            if (nyesteNavn == null)
            {
                throw new ArgumentNullException("nyesteNavn is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteNavn = nyesteNavn;
            // to ensure "nyesteStatus" is required (not null)
            if (nyesteStatus == null)
            {
                throw new ArgumentNullException("nyesteStatus is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteStatus = nyesteStatus;
            // to ensure "nyesteVirksomhedsform" is required (not null)
            if (nyesteVirksomhedsform == null)
            {
                throw new ArgumentNullException("nyesteVirksomhedsform is a required property for VirksomhedVirksomhedMetadata and cannot be null");
            }
            this.NyesteVirksomhedsform = nyesteVirksomhedsform;
            this.NyesteBinavne = nyesteBinavne;
            this.NyesteErstMaanedsbeskaeftigelse = nyesteErstMaanedsbeskaeftigelse;
        }

        /// <summary>
        /// Gets or Sets AntalPenheder
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "antalPenheder", IsRequired = true, EmitDefaultValue = true)]
        public long AntalPenheder { get; set; }

        /// <summary>
        /// Gets or Sets NyesteAarsbeskaeftigelse
        /// </summary>
        [DataMember(Name = "nyesteAarsbeskaeftigelse", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteAarsbeskaeftigelse NyesteAarsbeskaeftigelse { get; set; }

        /// <summary>
        /// Gets or Sets NyesteBeliggenhedsadresse
        /// </summary>
        [DataMember(Name = "nyesteBeliggenhedsadresse", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteBeliggenhedsadresse NyesteBeliggenhedsadresse { get; set; }

        /// <summary>
        /// Gets or Sets NyesteBibranche1
        /// </summary>
        [DataMember(Name = "nyesteBibranche1", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteBibranche1 NyesteBibranche1 { get; set; }

        /// <summary>
        /// Gets or Sets NyesteBibranche2
        /// </summary>
        [DataMember(Name = "nyesteBibranche2", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteBibranche1 NyesteBibranche2 { get; set; }

        /// <summary>
        /// Gets or Sets NyesteBibranche3
        /// </summary>
        [DataMember(Name = "nyesteBibranche3", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteBibranche1 NyesteBibranche3 { get; set; }

        /// <summary>
        /// Gets or Sets NyesteBinavne
        /// </summary>
        [DataMember(Name = "nyesteBinavne", EmitDefaultValue = false)]
        public List<string> NyesteBinavne { get; set; }

        /// <summary>
        /// Gets or Sets NyesteErstMaanedsbeskaeftigelse
        /// </summary>
        [DataMember(Name = "nyesteErstMaanedsbeskaeftigelse", EmitDefaultValue = false)]
        public VirksomhedVirksomhedMetadataNyesteErstMaanedsbeskaeftigelse NyesteErstMaanedsbeskaeftigelse { get; set; }

        /// <summary>
        /// Gets or Sets NyesteHovedbranche
        /// </summary>
        [DataMember(Name = "nyesteHovedbranche", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteBibranche1 NyesteHovedbranche { get; set; }

        /// <summary>
        /// Kan indeholde enhver form for kontaktoplysning, e.g. email adresse, telefonnummer, postadresse. 
        /// </summary>
        /// <value>Kan indeholde enhver form for kontaktoplysning, e.g. email adresse, telefonnummer, postadresse. </value>
        [DataMember(Name = "nyesteKontaktoplysninger", IsRequired = true, EmitDefaultValue = true)]
        public List<string> NyesteKontaktoplysninger { get; set; }

        /// <summary>
        /// Gets or Sets NyesteKvartalsbeskaeftigelse
        /// </summary>
        [DataMember(Name = "nyesteKvartalsbeskaeftigelse", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteKvartalsbeskaeftigelse NyesteKvartalsbeskaeftigelse { get; set; }

        /// <summary>
        /// Gets or Sets NyesteMaanedsbeskaeftigelse
        /// </summary>
        [DataMember(Name = "nyesteMaanedsbeskaeftigelse", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteMaanedsbeskaeftigelse NyesteMaanedsbeskaeftigelse { get; set; }

        /// <summary>
        /// Gets or Sets NyesteNavn
        /// </summary>
        [DataMember(Name = "nyesteNavn", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteNavn NyesteNavn { get; set; }

        /// <summary>
        /// Gets or Sets NyesteStatus
        /// </summary>
        [DataMember(Name = "nyesteStatus", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteStatus NyesteStatus { get; set; }

        /// <summary>
        /// Gets or Sets NyesteVirksomhedsform
        /// </summary>
        [DataMember(Name = "nyesteVirksomhedsform", IsRequired = true, EmitDefaultValue = true)]
        public VirksomhedVirksomhedMetadataNyesteVirksomhedsform NyesteVirksomhedsform { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VirksomhedVirksomhedMetadata {\n");
            sb.Append("  AntalPenheder: ").Append(AntalPenheder).Append("\n");
            sb.Append("  NyesteAarsbeskaeftigelse: ").Append(NyesteAarsbeskaeftigelse).Append("\n");
            sb.Append("  NyesteBeliggenhedsadresse: ").Append(NyesteBeliggenhedsadresse).Append("\n");
            sb.Append("  NyesteBibranche1: ").Append(NyesteBibranche1).Append("\n");
            sb.Append("  NyesteBibranche2: ").Append(NyesteBibranche2).Append("\n");
            sb.Append("  NyesteBibranche3: ").Append(NyesteBibranche3).Append("\n");
            sb.Append("  NyesteBinavne: ").Append(NyesteBinavne).Append("\n");
            sb.Append("  NyesteErstMaanedsbeskaeftigelse: ").Append(NyesteErstMaanedsbeskaeftigelse).Append("\n");
            sb.Append("  NyesteHovedbranche: ").Append(NyesteHovedbranche).Append("\n");
            sb.Append("  NyesteKontaktoplysninger: ").Append(NyesteKontaktoplysninger).Append("\n");
            sb.Append("  NyesteKvartalsbeskaeftigelse: ").Append(NyesteKvartalsbeskaeftigelse).Append("\n");
            sb.Append("  NyesteMaanedsbeskaeftigelse: ").Append(NyesteMaanedsbeskaeftigelse).Append("\n");
            sb.Append("  NyesteNavn: ").Append(NyesteNavn).Append("\n");
            sb.Append("  NyesteStatus: ").Append(NyesteStatus).Append("\n");
            sb.Append("  NyesteVirksomhedsform: ").Append(NyesteVirksomhedsform).Append("\n");
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

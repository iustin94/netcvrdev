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
    /// ProduktionsenhedDeltagerRelationInner
    /// </summary>
    [DataContract(Name = "Produktionsenhed_deltagerRelation_inner")]
    public partial class ProduktionsenhedDeltagerRelationInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProduktionsenhedDeltagerRelationInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProduktionsenhedDeltagerRelationInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProduktionsenhedDeltagerRelationInner" /> class.
        /// </summary>
        /// <param name="deltager">deltager (required).</param>
        /// <param name="kontorsteder">kontorsteder.</param>
        /// <param name="organisationer">organisationer (required).</param>
        public ProduktionsenhedDeltagerRelationInner(Deltager deltager = default(Deltager), List<Kontorsted> kontorsteder = default(List<Kontorsted>), List<Organisation> organisationer = default(List<Organisation>))
        {
            // to ensure "deltager" is required (not null)
            if (deltager == null)
            {
                throw new ArgumentNullException("deltager is a required property for ProduktionsenhedDeltagerRelationInner and cannot be null");
            }
            this.Deltager = deltager;
            // to ensure "organisationer" is required (not null)
            if (organisationer == null)
            {
                throw new ArgumentNullException("organisationer is a required property for ProduktionsenhedDeltagerRelationInner and cannot be null");
            }
            this.Organisationer = organisationer;
            this.Kontorsteder = kontorsteder;
        }

        /// <summary>
        /// Gets or Sets Deltager
        /// </summary>
        [DataMember(Name = "deltager", IsRequired = true, EmitDefaultValue = true)]
        public Deltager Deltager { get; set; }

        /// <summary>
        /// Gets or Sets Kontorsteder
        /// </summary>
        [DataMember(Name = "kontorsteder", EmitDefaultValue = false)]
        public List<Kontorsted> Kontorsteder { get; set; }

        /// <summary>
        /// Gets or Sets Organisationer
        /// </summary>
        [DataMember(Name = "organisationer", IsRequired = true, EmitDefaultValue = true)]
        public List<Organisation> Organisationer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProduktionsenhedDeltagerRelationInner {\n");
            sb.Append("  Deltager: ").Append(Deltager).Append("\n");
            sb.Append("  Kontorsteder: ").Append(Kontorsteder).Append("\n");
            sb.Append("  Organisationer: ").Append(Organisationer).Append("\n");
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

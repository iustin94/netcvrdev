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
    /// Kontorsted
    /// </summary>
    [DataContract(Name = "Kontorsted")]
    public partial class Kontorsted : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kontorsted" /> class.
        /// </summary>
        /// <param name="attributter">Værdier, der er tilknyttet en entitet. Det kan være næsten hvad som helst; kontaktoplysninger, adresser, numeriske værdier, selskabers formål mv. Betydningen af de forskellige attributter bør kunne tydes fra konteksten .</param>
        /// <param name="penhed">penhed.</param>
        public Kontorsted(List<Attribut> attributter = default(List<Attribut>), Deltager penhed = default(Deltager))
        {
            this.Attributter = attributter;
            this.Penhed = penhed;
        }

        /// <summary>
        /// Værdier, der er tilknyttet en entitet. Det kan være næsten hvad som helst; kontaktoplysninger, adresser, numeriske værdier, selskabers formål mv. Betydningen af de forskellige attributter bør kunne tydes fra konteksten 
        /// </summary>
        /// <value>Værdier, der er tilknyttet en entitet. Det kan være næsten hvad som helst; kontaktoplysninger, adresser, numeriske værdier, selskabers formål mv. Betydningen af de forskellige attributter bør kunne tydes fra konteksten </value>
        [DataMember(Name = "attributter", EmitDefaultValue = false)]
        public List<Attribut> Attributter { get; set; }

        /// <summary>
        /// Gets or Sets Penhed
        /// </summary>
        [DataMember(Name = "penhed", EmitDefaultValue = false)]
        public Deltager Penhed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Kontorsted {\n");
            sb.Append("  Attributter: ").Append(Attributter).Append("\n");
            sb.Append("  Penhed: ").Append(Penhed).Append("\n");
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

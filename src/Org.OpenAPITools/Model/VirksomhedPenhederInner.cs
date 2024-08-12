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
    /// VirksomhedPenhederInner
    /// </summary>
    [DataContract(Name = "Virksomhed_penheder_inner")]
    public partial class VirksomhedPenhederInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirksomhedPenhederInner" /> class.
        /// </summary>
        /// <param name="pNummer">pNummer.</param>
        /// <param name="periode">periode.</param>
        /// <param name="sidstOpdateret">Seneste tidspunkt hvor dette objekt blev opdateret .</param>
        public VirksomhedPenhederInner(long pNummer = default(long), Periode periode = default(Periode), string sidstOpdateret = default(string))
        {
            this.PNummer = pNummer;
            this.Periode = periode;
            this.SidstOpdateret = sidstOpdateret;
        }

        /// <summary>
        /// Gets or Sets PNummer
        /// </summary>
        /// <example>1005054535</example>
        [DataMember(Name = "pNummer", EmitDefaultValue = false)]
        public long PNummer { get; set; }

        /// <summary>
        /// Gets or Sets Periode
        /// </summary>
        [DataMember(Name = "periode", EmitDefaultValue = false)]
        public Periode Periode { get; set; }

        /// <summary>
        /// Seneste tidspunkt hvor dette objekt blev opdateret 
        /// </summary>
        /// <value>Seneste tidspunkt hvor dette objekt blev opdateret </value>
        /// <example>2020-04-08T00:10:47.000Z</example>
        [DataMember(Name = "sidstOpdateret", EmitDefaultValue = true)]
        public string SidstOpdateret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VirksomhedPenhederInner {\n");
            sb.Append("  PNummer: ").Append(PNummer).Append("\n");
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

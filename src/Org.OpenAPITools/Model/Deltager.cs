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
    /// Deltager
    /// </summary>
    [DataContract(Name = "Deltager")]
    public partial class Deltager : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deltager" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Deltager() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deltager" /> class.
        /// </summary>
        /// <param name="adresseHemmelig">adresseHemmelig.</param>
        /// <param name="adresseHemmeligUndtagelse">adresseHemmeligUndtagelse.</param>
        /// <param name="adresseOpdateringOphoert">adresseOpdateringOphoert.</param>
        /// <param name="beliggenhedsadresse">Fysiske adresser, som oftest i Danmark .</param>
        /// <param name="enhedsNummer">Et unikt id, der identificerer en given enhed i CVR. Enhedsnumre benyttes ofte til at indikere relationer mellem enheder. Dog benyttes CVR-numre og P-numre også  (required).</param>
        /// <param name="enhedstype">Typen af enhed, der er tale om. Kan være &#x60;ANDEN DELTAGER&#x60;, &#x60;PERSON&#x60;, &#x60;PRODUKTIONSENHED&#x60; og &#x60;VIRKSOMHED&#x60;  (required).</param>
        /// <param name="forretningsnoegle">forretningsnoegle.</param>
        /// <param name="navne">Navne tilknyttet den givne enhed  (required).</param>
        /// <param name="postadresse">Fysiske adresser, som oftest i Danmark .</param>
        /// <param name="sidstIndlaest">Seneste tidspunkt hvor dette objekt er blevet indlæst i Virks Elastic Search  (required).</param>
        /// <param name="sidstOpdateret">Seneste tidspunkt hvor dette objekt blev opdateret .</param>
        public Deltager(bool? adresseHemmelig = default(bool?), bool? adresseHemmeligUndtagelse = default(bool?), bool? adresseOpdateringOphoert = default(bool?), List<Adresse> beliggenhedsadresse = default(List<Adresse>), long enhedsNummer = default(long), string enhedstype = default(string), long? forretningsnoegle = default(long?), List<Navn> navne = default(List<Navn>), List<Adresse> postadresse = default(List<Adresse>), DateTime? sidstIndlaest = default(DateTime?), string sidstOpdateret = default(string))
        {
            this.EnhedsNummer = enhedsNummer;
            // to ensure "enhedstype" is required (not null)
            if (enhedstype == null)
            {
                throw new ArgumentNullException("enhedstype is a required property for Deltager and cannot be null");
            }
            this.Enhedstype = enhedstype;
            // to ensure "navne" is required (not null)
            if (navne == null)
            {
                throw new ArgumentNullException("navne is a required property for Deltager and cannot be null");
            }
            this.Navne = navne;
            // to ensure "sidstIndlaest" is required (not null)
            if (sidstIndlaest == null)
            {
                throw new ArgumentNullException("sidstIndlaest is a required property for Deltager and cannot be null");
            }
            this.SidstIndlaest = sidstIndlaest;
            this.AdresseHemmelig = adresseHemmelig;
            this.AdresseHemmeligUndtagelse = adresseHemmeligUndtagelse;
            this.AdresseOpdateringOphoert = adresseOpdateringOphoert;
            this.Beliggenhedsadresse = beliggenhedsadresse;
            this.Forretningsnoegle = forretningsnoegle;
            this.Postadresse = postadresse;
            this.SidstOpdateret = sidstOpdateret;
        }

        /// <summary>
        /// Gets or Sets AdresseHemmelig
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "adresseHemmelig", EmitDefaultValue = true)]
        public bool? AdresseHemmelig { get; set; }

        /// <summary>
        /// Gets or Sets AdresseHemmeligUndtagelse
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "adresseHemmeligUndtagelse", EmitDefaultValue = true)]
        public bool? AdresseHemmeligUndtagelse { get; set; }

        /// <summary>
        /// Gets or Sets AdresseOpdateringOphoert
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "adresseOpdateringOphoert", EmitDefaultValue = true)]
        public bool? AdresseOpdateringOphoert { get; set; }

        /// <summary>
        /// Fysiske adresser, som oftest i Danmark 
        /// </summary>
        /// <value>Fysiske adresser, som oftest i Danmark </value>
        [DataMember(Name = "beliggenhedsadresse", EmitDefaultValue = false)]
        public List<Adresse> Beliggenhedsadresse { get; set; }

        /// <summary>
        /// Et unikt id, der identificerer en given enhed i CVR. Enhedsnumre benyttes ofte til at indikere relationer mellem enheder. Dog benyttes CVR-numre og P-numre også 
        /// </summary>
        /// <value>Et unikt id, der identificerer en given enhed i CVR. Enhedsnumre benyttes ofte til at indikere relationer mellem enheder. Dog benyttes CVR-numre og P-numre også </value>
        /// <example>4009416462</example>
        [DataMember(Name = "enhedsNummer", IsRequired = true, EmitDefaultValue = true)]
        public long EnhedsNummer { get; set; }

        /// <summary>
        /// Typen af enhed, der er tale om. Kan være &#x60;ANDEN DELTAGER&#x60;, &#x60;PERSON&#x60;, &#x60;PRODUKTIONSENHED&#x60; og &#x60;VIRKSOMHED&#x60; 
        /// </summary>
        /// <value>Typen af enhed, der er tale om. Kan være &#x60;ANDEN DELTAGER&#x60;, &#x60;PERSON&#x60;, &#x60;PRODUKTIONSENHED&#x60; og &#x60;VIRKSOMHED&#x60; </value>
        /// <example>PERSON</example>
        [DataMember(Name = "enhedstype", IsRequired = true, EmitDefaultValue = true)]
        public string Enhedstype { get; set; }

        /// <summary>
        /// Gets or Sets Forretningsnoegle
        /// </summary>
        /// <example>4006308802</example>
        [DataMember(Name = "forretningsnoegle", EmitDefaultValue = true)]
        public long? Forretningsnoegle { get; set; }

        /// <summary>
        /// Navne tilknyttet den givne enhed 
        /// </summary>
        /// <value>Navne tilknyttet den givne enhed </value>
        [DataMember(Name = "navne", IsRequired = true, EmitDefaultValue = true)]
        public List<Navn> Navne { get; set; }

        /// <summary>
        /// Fysiske adresser, som oftest i Danmark 
        /// </summary>
        /// <value>Fysiske adresser, som oftest i Danmark </value>
        [DataMember(Name = "postadresse", EmitDefaultValue = false)]
        public List<Adresse> Postadresse { get; set; }

        /// <summary>
        /// Seneste tidspunkt hvor dette objekt er blevet indlæst i Virks Elastic Search 
        /// </summary>
        /// <value>Seneste tidspunkt hvor dette objekt er blevet indlæst i Virks Elastic Search </value>
        /// <example>2019-09-14T10:52:32+02:00</example>
        [DataMember(Name = "sidstIndlaest", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? SidstIndlaest { get; set; }

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
            sb.Append("class Deltager {\n");
            sb.Append("  AdresseHemmelig: ").Append(AdresseHemmelig).Append("\n");
            sb.Append("  AdresseHemmeligUndtagelse: ").Append(AdresseHemmeligUndtagelse).Append("\n");
            sb.Append("  AdresseOpdateringOphoert: ").Append(AdresseOpdateringOphoert).Append("\n");
            sb.Append("  Beliggenhedsadresse: ").Append(Beliggenhedsadresse).Append("\n");
            sb.Append("  EnhedsNummer: ").Append(EnhedsNummer).Append("\n");
            sb.Append("  Enhedstype: ").Append(Enhedstype).Append("\n");
            sb.Append("  Forretningsnoegle: ").Append(Forretningsnoegle).Append("\n");
            sb.Append("  Navne: ").Append(Navne).Append("\n");
            sb.Append("  Postadresse: ").Append(Postadresse).Append("\n");
            sb.Append("  SidstIndlaest: ").Append(SidstIndlaest).Append("\n");
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

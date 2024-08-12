/*
 * cvr.dev API dokumentation
 *
 * # Introduktion Velkommen til [cvr.dev](https://cvr.dev)'s HTTP API dokumentation.  Dette dokument beskriver, hvordan du kan benytte vores API til at hente CVR-data. Vi henter og cacher data fra Virks CVR-database en gang i minuttet, så vi altid kan levere så nøjagtig data som muligt.  Udover at være beskrevet på denne sige, er vores API også [beskrevet i OpenAPI 3.0 format](https://docs.cvr.dev/cvrdev_openapi.yml) og som [Postman-dokumentation](https://documenter.getpostman.com/view/13435475/TVejiqUr).  For at benytte vores API skal du have en [cvr.dev-konto](https://cvr.dev/#/auth/signup) med et aktivt abonnement, som du kan [prøve gratis de første 30 dage](https://cvr.dev/#/prices). 
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing VirksomhedVirksomhedMetadataNyesteBibranche1
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VirksomhedVirksomhedMetadataNyesteBibranche1Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VirksomhedVirksomhedMetadataNyesteBibranche1
        //private VirksomhedVirksomhedMetadataNyesteBibranche1 instance;

        public VirksomhedVirksomhedMetadataNyesteBibranche1Tests()
        {
            // TODO uncomment below to create an instance of VirksomhedVirksomhedMetadataNyesteBibranche1
            //instance = new VirksomhedVirksomhedMetadataNyesteBibranche1();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VirksomhedVirksomhedMetadataNyesteBibranche1
        /// </summary>
        [Fact]
        public void VirksomhedVirksomhedMetadataNyesteBibranche1InstanceTest()
        {
            // TODO uncomment below to test "IsType" VirksomhedVirksomhedMetadataNyesteBibranche1
            //Assert.IsType<VirksomhedVirksomhedMetadataNyesteBibranche1>(instance);
        }

        /// <summary>
        /// Test the property 'Branchekode'
        /// </summary>
        [Fact]
        public void BranchekodeTest()
        {
            // TODO unit test for the property 'Branchekode'
        }

        /// <summary>
        /// Test the property 'Branchetekst'
        /// </summary>
        [Fact]
        public void BranchetekstTest()
        {
            // TODO unit test for the property 'Branchetekst'
        }

        /// <summary>
        /// Test the property 'Periode'
        /// </summary>
        [Fact]
        public void PeriodeTest()
        {
            // TODO unit test for the property 'Periode'
        }

        /// <summary>
        /// Test the property 'SidstOpdateret'
        /// </summary>
        [Fact]
        public void SidstOpdateretTest()
        {
            // TODO unit test for the property 'SidstOpdateret'
        }
    }
}

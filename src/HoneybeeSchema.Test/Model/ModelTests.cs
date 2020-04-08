/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

using HB = HoneybeeSchema;
using System.Reflection;
using Newtonsoft.Json;
using System.Net;

namespace HoneybeeSchema.Test
{
    /// <summary>
    ///  Class for testing Model
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModelTests
    {
        // TODO uncomment below to declare an instance variable for Model
        private Model instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            var url = @"https://raw.githubusercontent.com/ladybug-tools/honeybee-schema/master/samples/model/model_complete_single_zone_office.json";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                this.instance = HB.Model.FromJson(json);
            }
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Model
        /// </summary>
        [Test]
        public void ModelInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Model
            Assert.IsInstanceOf(typeof(HB.Model), instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            Assert.AreEqual(this.instance.Identifier, "Tiny_House");
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            Assert.AreEqual(this.instance.DisplayName, "Tiny_House");
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Rooms'
        /// </summary>
        [Test]
        public void RoomsTest()
        {
            Assert.AreEqual(this.instance.Rooms.Count, 1);
        }
        /// <summary>
        /// Test the property 'OrphanedFaces'
        /// </summary>
        [Test]
        public void OrphanedFacesTest()
        {
            Assert.AreEqual(this.instance.OrphanedShades.Count, 1);
            Assert.AreEqual(this.instance.OrphanedShades[0].Identifier, "Tree_Canopy");
        }
        /// <summary>
        /// Test the property 'OrphanedShades'
        /// </summary>
        [Test]
        public void OrphanedShadesTest()
        {
            // TODO unit test for the property 'OrphanedShades'
        }
        /// <summary>
        /// Test the property 'OrphanedApertures'
        /// </summary>
        [Test]
        public void OrphanedAperturesTest()
        {
            // TODO unit test for the property 'OrphanedApertures'
        }
        /// <summary>
        /// Test the property 'OrphanedDoors'
        /// </summary>
        [Test]
        public void OrphanedDoorsTest()
        {
            // TODO unit test for the property 'OrphanedDoors'
        }
        /// <summary>
        /// Test the property 'NorthAngle'
        /// </summary>
        [Test]
        public void NorthAngleTest()
        {
            Assert.AreEqual(this.instance.NorthAngle, 15);
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            var obj = this.instance.Properties.Energy.ProgramTypes.First();
            var prop = obj.Obj as ProgramTypeAbridged; 
            Assert.AreEqual(prop.Identifier, "Generic Office Program");
            Assert.AreEqual(prop.Lighting.WattsPerArea, 10.55);
            Assert.AreEqual(prop.ElectricEquipment.LatentFraction, 0);
            Assert.AreEqual(prop.People.LatentFraction, new Autocalculate());
            Assert.AreEqual(prop.Infiltration.FlowPerExteriorArea, 0.0002266);
            Assert.AreEqual(prop.Setpoint.HeatingSchedule, "Generic Office Heating");


            var hvac = this.instance.Properties.Energy.Hvacs.First();
            Assert.AreEqual(hvac.HeatingAirTemperature, 50);
            Assert.AreEqual(hvac.HeatingLimit, new Autosize());
        }

    }

}

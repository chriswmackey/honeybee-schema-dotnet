
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HoneybeeSchema.Test
{
    /// <summary>
    ///  Class for testing ModifierBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModifierBaseTests
    {
        // TODO uncomment below to declare an instance variable for ModifierBase
        private ModifierBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModifierBase
            instance = new Plastic("newID");
        }

     


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            Assert.AreEqual(this.instance.Type, typeof(Plastic).Name);
        }

        [Test]
        public void DuplicateModifierBaseTest()
        {
            var dup = this.instance.DuplicateModifierBase();
            Assert.IsTrue(dup is Plastic);
        }
        [Test]
        public void DuplicateTest()
        {
            var dup = this.instance.Duplicate();
            Assert.IsTrue(dup is Plastic);
        }
        [Test]
        public void DuplicateIDdRadianceBaseModelTest()
        {
            var dup = this.instance.DuplicateIDdRadianceBaseModel();
            Assert.IsTrue(dup is Plastic);
        }


        [Test]
        public void VisualPropertiesTest()
        {

            var mats = ModelRadianceProperties.Default.ModifierList;
            var tests = new Dictionary<string, (double, double, double)>()
            {
                {"generic_exterior_window_vis_0.64", (0.36, 0.64 , 0) }, //glass
                {"generic_floor_0.20", (0.20, 0 , 0) }, //plastic
                { "white_glow",  (-999, -999 , 1)}, //glow
                {"air_boundary", (1 , 1 , 0) }, //trans
            };

            foreach (var item in tests)
            {
                var m1 = mats.FirstOrDefault(_ => _.Identifier == item.Key);
                m1.CalVisualValues();
                var refl = item.Value.Item1;
                var trans = item.Value.Item2;
                var emmi = item.Value.Item3;

                Assert.AreEqual(Math.Round(m1.Reflectance, 2), refl);
                Assert.AreEqual(Math.Round(m1.Transmittance, 2), trans);
                Assert.AreEqual(Math.Round(m1.Emittance, 2), emmi);
            }

        }
    }

}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerCfg;

namespace PowerCfgTest
{
    [TestClass]
    public class PowerCfgTests
    {
        [TestMethod]
        public void TestGetAttributes()
        {
            var ret = PowerCfgBroker.GetAttributes("sub_processor", "perfboostmode");
            Assert.AreEqual(1, ret.Length);
            Assert.IsTrue(ret[0] == "None" || ret[0] == "ATTRIB_HIDE");
            var ex = Assert.ThrowsException<System.ArgumentException>(() => PowerCfgBroker.GetAttributes("sub_processor", "perfboostmod"));
            Assert.AreEqual("Could not read sub_processor perfboostmod attribute: Invalid Parameters -- try \"/?\" for help", ex.Message);
        }

        [TestMethod]
        public void TestSetAttribute()
        {
            var ret = PowerCfgBroker.GetAttributes("sub_processor", "perfboostmode");
            bool set = (ret[0] == "ATTRIB_HIDE");
            PowerCfgBroker.SetAttribute("sub_processor", "perfboostmode", "attrib_hide", !set);
            ret = PowerCfgBroker.GetAttributes("sub_processor", "perfboostmode");
            bool set2 = (ret[0] == "ATTRIB_HIDE");
            Assert.AreNotEqual(set2, set);
            PowerCfgBroker.SetAttribute("sub_processor", "perfboostmode", "attrib_hide", set);
        }

        [TestMethod]
        public void TestQuery()
        {
            QueryValue? qv = PowerCfgBroker.Query("scheme_current", "", "");
            Assert.IsNotNull(qv);
            Assert.IsTrue(qv.Value.PowerSchemeFriendlyName != "");
            Assert.IsTrue(qv.Value.PowerSchemeGuid != "");
            Assert.IsTrue(qv.Value.SubGroups.Count > 0);
        }
    }
}

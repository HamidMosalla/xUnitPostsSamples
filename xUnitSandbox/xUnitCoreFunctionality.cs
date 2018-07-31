using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace xUnitSandbox
{
    /*
     Naming: [UnitOfWorkName]_[ScenarioUnderTest]_[ExpectedBehavior]

         UnitOfWorkName — The name of the method or group of methods or classes you’re testing.

         Scenario — The conditions under which the unit is tested, such as “bad login” or
         “invalid user” or “good password.” You could describe the parameters being sent
         to the public method or the initial state of the system when the unit of work is
         invoked such as “system out of memory” or “no users exist” or “user already exists.”

         ExpectedBehavior — What you expect the tested method to do under the specified
         conditions. This could be one of three possibilities: return a value as a
         result (a real value, or an exception), change the state of the system as a result
         (like adding a new user to the system, so the system behaves differently on the
         next login), or call a third-party system as a result (like an external web service).

        ByDefault can be used when there’s an expected return value with no prior action, as shown in the previous example.

        WhenCalled or Always can be used in the second or third kind of unit of work results (change state or call a third party)
        when the state change is done with no prior configuration or when the third-party call is done with no prior configuration;
        for example, Sum_WhenCalled_CallsTheLogger or Sum_Always_CallsTheLogger.

        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calc = MakeCalc();
            int lastSum = calc.Sum();
            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            MemCalculator calc = MakeCalc();
            calc.Add(1);
            int sum = calc.Sum();
            Assert.AreEqual(1, sum);
        }
     */

    public class XUnitCoreFunctionality
    {
        void FunctionThatThrowsAnException(string str)
        {
            if (string.IsNullOrEmpty(str)) throw new ArgumentException("There is no argument.");
        }

        [Fact]
        void FunctionThatThrowsAnException_ArgumentNullOrEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FunctionThatThrowsAnException(null));

            //Asserts that an exception that derived form this type is thrown
            Assert.ThrowsAny<Exception>(() => FunctionThatThrowsAnException(null));
        }
    }
}
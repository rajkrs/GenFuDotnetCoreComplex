using ComplexFaker.Test.Models;
using System;
using Xunit;

namespace ComplexFaker.Test
{

     
    public class SimpleData
    {
        [Fact]
        public void GenerateSimple()
        {
            IFakeDataService faker = new FakeDataService();
            //Generate Simple obj
            var obj1 = faker.Generate<ChargeSummaryDto>();

            Assert.Equal(null, obj1.ChargeInfoList);

        }



        [Fact]
        public void GenerateComplex()
        {
            IFakeDataService faker = new FakeDataService();
            //Generate Simple obj
            var obj1 = faker.GenerateComplex<ChargeSummaryDto>();

            Assert.Equal(2, obj1.ChargeInfoList.Count );

        }


    }
}

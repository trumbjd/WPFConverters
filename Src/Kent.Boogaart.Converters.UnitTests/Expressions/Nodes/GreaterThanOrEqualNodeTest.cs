using Kent.Boogaart.Converters.Expressions.Nodes;
using Xunit;

namespace Kent.Boogaart.Converters.UnitTests.Expressions.Nodes
{
    public sealed class GreaterThanOrEqualNodeTest : WideningBinaryNodeTestBase
    {
        private GreaterThanOrEqualNode greaterThanOrEqualNode;

        protected override void SetUpCore()
        {
            base.SetUpCore();
            this.greaterThanOrEqualNode = new GreaterThanOrEqualNode(new ConstantNode<int>(0), new ConstantNode<int>(0));
        }

        [Fact]
        public void OperatorSymbols_ShouldYieldCorrectOperatorSymbols()
        {
            Assert.Equal(">=", GetPrivateMemberValue<string>(this.greaterThanOrEqualNode, "OperatorSymbols"));
        }

        [Fact]
        public void DoByte_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoByte", (byte)1, (byte)2));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoByte", (byte)2, (byte)2));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoByte", (byte)3, (byte)2));
        }

        [Fact]
        public void DoInt16_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt16", (short)1, (short)2));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt16", (short)2, (short)2));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt16", (short)3, (short)2));
        }

        [Fact]
        public void DoInt32_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt32", 1, 2));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt32", 2, 2));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt32", 3, 2));
        }

        [Fact]
        public void DoInt64_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt64", 1L, 2L));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt64", 2L, 2L));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoInt64", 3L, 2L));
        }

        [Fact]
        public void DoSingle_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoSingle", 1f, 2f));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoSingle", 2f, 2f));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoSingle", 3f, 2f));
        }

        [Fact]
        public void DoDouble_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoDouble", 1d, 2d));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoDouble", 2d, 2d));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoDouble", 3d, 2d));
        }

        [Fact]
        public void DoDecimal_ShouldDoComparison()
        {
            Assert.False(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoDecimal", 1m, 2m));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoDecimal", 2m, 2m));
            Assert.True(InvokeDoMethod<bool>(this.greaterThanOrEqualNode, "DoDecimal", 3m, 2m));
        }
    }
}
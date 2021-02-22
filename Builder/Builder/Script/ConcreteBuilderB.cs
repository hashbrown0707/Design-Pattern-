namespace Builder.Script
{
    class ConcreteBuilderB : ProductBuilder
    {
        public override string BuildPartA() => "Part A, type-2";

        public override string BuildPartB() => "Part B, type-2";
    }
}

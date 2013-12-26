namespace Compound
{
    public abstract class Node
    {
        public string Value { get; set; }
        public string Name { get; set; }
        public abstract void Accept(INodeVistor nodeVistor);
    }
}
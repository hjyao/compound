namespace Compound
{
    public class TextNode : Node
    {
        public override void Accept(INodeVistor nodeVistor)
        {
            nodeVistor.VisitTextNode(this);
        }
    }
}
namespace Compound
{
    public class XmlDeclarationNode : Node
    {
        public override void Accept(INodeVistor nodeVistor)
        {
            nodeVistor.VisitDeclarationNode(this);
        }
    }
}
namespace Compound
{
    public class XmlDeclarationNode : Node
    {
        public override void Accept(XmlExtractor xmlExtractor)
        {
            xmlExtractor.VisitDeclarationNode(this);
        }
    }
}
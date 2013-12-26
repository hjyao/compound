namespace Compound
{
    public class XmlDeclarationNode : Node
    {
        public void Accept(XmlExtractor xmlExtractor)
        {
            xmlExtractor.VisitDeclarationNode(this);
        }
    }
}
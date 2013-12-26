namespace Compound
{
    public class TextNode : Node
    {
        public void Accept(XmlExtractor xmlExtractor)
        {
            xmlExtractor.VisitTextNode(this);
        }
    }
}
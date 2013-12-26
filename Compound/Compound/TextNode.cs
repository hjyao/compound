namespace Compound
{
    public class TextNode : Node
    {
        public override void Accept(XmlExtractor xmlExtractor)
        {
            xmlExtractor.VisitTextNode(this);
        }
    }
}
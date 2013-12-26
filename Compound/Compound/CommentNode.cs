namespace Compound
{
    public class CommentNode : Node
    {
        public void Accept(XmlExtractor xmlExtractor)
        {
            xmlExtractor.VisitCommentNode(this);
        }
    }
}
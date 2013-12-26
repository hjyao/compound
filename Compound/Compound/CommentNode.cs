namespace Compound
{
    public class CommentNode : Node
    {
        public override void Accept(XmlExtractor xmlExtractor)
        {
            xmlExtractor.VisitCommentNode(this);
        }
    }
}
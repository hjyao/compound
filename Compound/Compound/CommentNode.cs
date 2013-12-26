namespace Compound
{
    public class CommentNode : Node
    {
        public override void Accept(INodeVistor nodeVistor)
        {
            nodeVistor.VisitCommentNode(this);
        }
    }
}
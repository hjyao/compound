namespace Compound
{
    public interface INodeVistor
    {
        void VisitDeclarationNode(XmlDeclarationNode xmlNode);
        void VisitCommentNode(CommentNode xmlNode);
        void VisitTextNode(TextNode xmlNode);
    }
}
using System.Text;

namespace Compound
{
    public class XmlExtractor : INodeVistor
    {
        private StringBuilder result;

        public string Extract(Node xmlNode)
        {
            result = new StringBuilder();
            xmlNode.Accept(this);
            return result.ToString();

        }

        public void VisitDeclarationNode(XmlDeclarationNode xmlNode)
        {
            result.Append(string.Format("{0}:{1}\r\n", xmlNode.Name, xmlNode.Value));
        }

        public void VisitCommentNode(CommentNode xmlNode)
        {
            if (!IsScriptComment(xmlNode.Name))
            {
                result.Append(string.Format("this is a comment:{0}\r\n", xmlNode.Value));
            }
        }

        public void VisitTextNode(TextNode xmlNode)
        {
            if (!IsScriptTag(xmlNode.Name))
            {
                result.Append(string.Format("{0}:{1}\r\n", xmlNode.Name, xmlNode.Value));
            }
        }

        public static bool IsScriptComment(string comment)
        {
            return comment.ToLower().Equals("scriptcomment");
        }

        public static bool IsScriptTag(string xmlString)
        {
            return xmlString.ToLower().Equals("script");
        }
    }
}
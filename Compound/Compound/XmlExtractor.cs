using System.Text;

namespace Compound
{
    public class XmlExtractor
    {
        public string Extract(Node xmlNode)
        {
            var result = new StringBuilder();
            var nodeType = xmlNode.GetType().Name;
            if (nodeType == "TextNode")
            {
                if (!IsScriptTag(xmlNode.Name))
                {
                    result.Append(string.Format("{0}:{1}\r\n", xmlNode.Name, xmlNode.Value));
                }
            }else if (nodeType == "CommentNode"){
                if (!IsScriptComment(xmlNode.Name))
                {
                    result.Append(string.Format("this is a comment:{0}\r\n", xmlNode.Value));
                }

            }else if(nodeType == "XmlDeclarationNode")
            {
                result.Append(string.Format("this is a xml file\r\n"));
            }
            return result.ToString();

        }

        private static bool IsScriptComment(string comment)
        {
            return comment.ToLower().Equals("scriptcomment");
        }

        private static bool IsScriptTag(string xmlString)
        {
            return xmlString.ToLower().Equals("script");
        }
    }
}
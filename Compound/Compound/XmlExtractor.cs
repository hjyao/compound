using System.Text;

namespace Compound
{
    public class XmlExtractor
    {
        public string Extract(Node xmlNode)
        {
            var result = new StringBuilder();
            switch (xmlNode.GetType().Name)
            {
                case "TextNode":
                    result.Append(xmlNode.Value);
                    break;
                case "CommentNode":
                    break;
                case "XmlDeclarationNode":
                    break;
            }
            return result.ToString();

        }
    }
}
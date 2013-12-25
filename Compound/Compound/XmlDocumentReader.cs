namespace Compound
{
    public class XmlDocumentReader
    {
        public Node Read(string xmlString)
        {
            Node node = null;
            if (xmlString.Contains("?xml"))
            {
                node = new XmlDeclarationNode();
            }
            else if (xmlString.Contains("<!--"))
            {
                node = new CommentNode {Value = xmlString.Substring(4, xmlString.Length - 7)};
            }
            else if (xmlString.Contains("<Item>"))
            {
                node = new TextNode {Value = xmlString.Substring(6, xmlString.Length - 13)};
            }
            return node;
        }
    }
}
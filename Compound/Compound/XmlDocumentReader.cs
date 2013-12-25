namespace Compound
{
    public class XmlDocumentReader
    {
        public Node Read(string xmlString)
        {
            Node node = null;
            if (xmlString.Contains("?xml"))
            {
                node = new XmlDeclarationNode {Name = "Declaration", Value = xmlString};
            }
            else if (xmlString.Contains("<!--"))
            {
                node = new CommentNode {Name = "Comment", Value = xmlString.Substring(4, xmlString.Length - 7)};
            }else if (xmlString.Contains("\\"))
            {
                node = new CommentNode {Name = "ScriptComment", Value = xmlString.Substring(2, xmlString.Length - 2)};
            }
            else if (xmlString.Contains("<Item>"))
            {
                node = new TextNode {Name = "Text", Value = xmlString.Substring(6, xmlString.Length - 13)};
            }else if (xmlString.ToLower().Contains("<script>"))
            {
                node = new TextNode {Name = "script", Value = xmlString.Substring(8, xmlString.Length - 17)};
            }
            return node;
        }
    }
}
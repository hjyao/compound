using System;
using System.Linq;
using System.Text;
using Compound;
using Xunit;

namespace CompoundTest
{
    public class XmlExtractorFacts
    {
        private const string XmlString = @"<?xml version='1.0'?>
                                           <!-- This is a sample XML document -->
                                           <Item>test with a child element</Item>";

        [Fact]
        public void should_recognize_specific_node_given_xml_file()
        {
            var result = new StringBuilder();
            var lines = XmlString.Split(new[] {Environment.NewLine}, StringSplitOptions.None).Select(l => l.TrimStart()).ToArray();

            var xmlDocumentReader = new XmlDocumentReader();
            var xmlExtractor = new XmlExtractor();
            lines.ToList().ForEach(l =>
                {
                    var node = xmlDocumentReader.Read(l);
                    if (node == null)
                        return;
                    result.Append(xmlExtractor.Extract(node));
                });
            Assert.Equal("test with a child element", result.ToString());
        }

    }
}

    

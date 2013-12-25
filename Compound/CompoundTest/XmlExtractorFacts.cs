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
                                           <!--This is a sample XML document-->
                                           <Item>test with a child element</Item>";

        [Fact]
        public void should_output_specific_string_given_xml_file()
        {
            var result = new StringBuilder();
            var lines = XmlString.Split(new[] {Environment.NewLine}, StringSplitOptions.None).Select(l => l.TrimStart()).ToArray();

            var xmlDocumentReader = new XmlDocumentReader();
            var xmlExtractor = new XmlExtractor();
            lines.ToList().ForEach(line =>
                {
                    var node = xmlDocumentReader.Read(line);
                    result.Append(xmlExtractor.Extract(node));
                });
            var expectedOutput = string.Format("this is a xml file\r\nthis is a comment:This is a sample XML document\r\nText:test with a child element\r\n");
            Assert.Equal(expectedOutput, result.ToString());
        }

    }
}

    

using System.Collections.Generic;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    public class StreamTradeDataProvider : ITradeDataProvider
    {
        private readonly Stream stream;
        public StreamTradeDataProvider(Stream stream) => this.stream = stream;

        public IEnumerable<string> GetTradeData()
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}

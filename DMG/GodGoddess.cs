using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMastersGuide
{
    public class GodGoddess
    {
        private string _name;
        private string _alignment;
        private List<string> _domains;
        private string _symbol;

        public string Name => _name;
        public string Alignment => _alignment;
        public List<string> Domains => _domains;
        public string Symbol => _symbol;

        public GodGoddess(string name, string alignment, string domain, string symbol)
        {
            _name = name; ;
            _alignment = alignment;
            _domains = new List<string>();
            _domains.Add(domain);
            _symbol = symbol;
        }

        public void AddDomain(string domain)
        {
            if (_domains == null) _domains = new List<string>();
            _domains.Add(domain);
        }
    }
}

using System.Collections.Generic;

namespace ProjectBolo.Core.Interfaces
{
    public interface IReadFileProcessor
    {
        public List<string> ProcessFile(string fileName);
    }
}

namespace AppLogger
{
    public class Dependencies
    {
        private readonly Dictionary<string, List<string>> _directDependencies = new Dictionary<string, List<string>>();

        public void AddDirect(string item, List<string> dependencies)
        {
            if (!_directDependencies.ContainsKey(item))
            {
                _directDependencies[item] = new List<string>();
            }
            _directDependencies[item].AddRange(dependencies);
        }

        public List<string> DependenciesFor(string item)
        {
            var result = new HashSet<string>();
            var visited = new HashSet<string>();
            CalculateDependencies(item, result, visited);
            return result.ToList();
        }

        private void CalculateDependencies(string item, HashSet<string> result, HashSet<string> visited)
        {
            if (!visited.Contains(item))
            {
                visited.Add(item);
                if (_directDependencies.ContainsKey(item))
                {
                    foreach (var dependency in _directDependencies[item])
                    {
                        if (result.Add(dependency))
                        {
                            CalculateDependencies(dependency, result, visited);
                        }
                    }
                }
            }
        }
    }
}

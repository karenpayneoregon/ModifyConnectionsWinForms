using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace DataConnectionLibrary
{
    public class AssemblyHelpers
    {
        /// <summary>
        /// Get calling program 
        /// </summary>
        /// <returns></returns>
        public string CallingNamespace()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();

            // ReSharper disable once AssignNullToNotNullAttribute
            var callerAssemblies = new StackTrace().GetFrames()
                // ReSharper disable once PossibleNullReferenceException
                .Select(sf => sf.GetMethod().ReflectedType.Assembly)
                .Distinct()
                .Where(assembly => assembly.GetReferencedAssemblies()
                    .Any(assemblyName => assemblyName.FullName == currentAssembly.FullName));

            return callerAssemblies.Last().Location;
        }
    }
}

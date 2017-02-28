using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminders.Core
{
    public interface IPersistenceService<T>
    {
        void SaveObject(string path, T @object);
        T LoadObject(string path);
    }
}

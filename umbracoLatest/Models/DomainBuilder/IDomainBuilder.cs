using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoLatest.Models.DomainBuilder
{
    public interface IDomainBuilder<out T, in TS>
    {
        T Build(TS modelView);
    }
}

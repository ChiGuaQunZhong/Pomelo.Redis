using System.Text;

namespace Pomelo.Redis
{
    interface ICompletable
    {
        void AppendStormLog(StringBuilder sb);

        bool TryComplete(bool isAsync);
    }
}

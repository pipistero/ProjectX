using Cysharp.Threading.Tasks;

namespace InteractiveObjects
{
    public interface IInteractive
    {
        UniTask Interact();
    }
}
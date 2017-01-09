using System.Collections.Generic;
using Entitas;

public sealed class DestroySystem : ISetPool, IReactiveSystem {

    public TriggerOnEvent trigger { get { return GameMatcher.Destroy.OnEntityAdded(); } }

    Context _pool;

    public void SetPool(Context pool) {
        _pool = pool;
    }

    public void Execute(List<Entity> entities) {
        foreach(var e in entities) {
            _pool.DestroyEntity(e);
        }
    }
}

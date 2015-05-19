﻿using Entitas;

public class CreateFinishLineSystem : IStartSystem, ISetPool {
    Pool _pool;

    public void SetPool(Pool pool) {
        _pool = pool;
    }

    public void Start() {
        _pool.CreateEntity()
            .IsFinishLine(true)
            .AddResource("Finish Line")
            .AddPosition(4.5f, 3.5f, 0);
    }
}


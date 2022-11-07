﻿namespace ACM.BL.Entities.Base;

public enum EntityStateOption
{
    Active,
    Deleted
}

public abstract class EntityBase
{
    public EntityStateOption EntityState { get; set; }
    public bool HasChanges { get; set; }
    public bool IsNew { get; private set; }

    public abstract bool IsValid();
}
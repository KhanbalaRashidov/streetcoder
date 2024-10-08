﻿using System;

internal class HashcodeCombine
{
    public int TopicId { get; set; }
    public int EntryId { get; set; }

    public override int GetHashCode() => HashCode.Combine(TopicId, EntryId);
}
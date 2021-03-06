﻿using System;
using SharepointCommon.Attributes;
using SharepointCommon.Test.Entity;

namespace SharepointCommon.Test.ER.Entities
{
    public class AddingItem : CustomItem
    {
        public static AddingItem Received;
        public static Exception Exception;

        [NotMapped]
        public static bool IsAddCalled { get; set; }

        public virtual string TheText { get; set; }
    }
}

using UnityEngine;
using System;

namespace ExtraGUIs.Editor
{
    public class UseExtraGUIDrawer : PropertyAttribute
    { }
    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class ContainsReferences : PropertyAttribute
    {
        public ContainsReferences() : base()
        { }
    }
    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class ReferenceList : PropertyAttribute
    {
        public ReferenceList() : base()
        { }
    }
}
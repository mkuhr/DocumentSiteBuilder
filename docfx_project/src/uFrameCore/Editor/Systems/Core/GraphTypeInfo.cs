using System;

namespace uFrame.Editor.Core
{
    public class GraphTypeInfo : IItem
    {
        public string Group { get; set; }
        public string Label { get; set; }

        public Type Type
        {
            get { return Type.GetType(FullName); }
            set
            {
                Name = value.Name;
                FullName = value.FullName;
            }
        }

        public string Name { get; set; }

        public string FullName { get; set; }

        public bool IsPrimitive { get; set; }

        public bool IsUnityEngine { get; set; }

        public string Title
        {
            get { return Label; }
        }

        public string SearchTag
        {
            get { return Name + Label; }
        }

        public string Description { get; set; }
    }
}
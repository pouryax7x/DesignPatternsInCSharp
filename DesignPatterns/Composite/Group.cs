using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Group : Component
    {
        private List<Component> components = new List<Component>();

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Render()
        {
            foreach (var component in components)
            {
                component.Render();
            }
        }

        public void Move()
        {
            foreach (var component in components)
            {
                component.Move();
            }
        }
    }
}
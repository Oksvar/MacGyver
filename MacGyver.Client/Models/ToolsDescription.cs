using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacGyver.Client.Models
{
   
    public class ToolsDescription
    {
        public ToolsDescription()
        {
            Components = new List<Component<Material>>();
        }

       
        public string Name { get; set; }

        
        public IList<Component<Material>> Components { get; set; }


        public int Usefulness
        { 
            get 
            {
                return !(Components is null) ? Components.Sum(t => t.Quantity) : 0;
            } 
        }

        
        public bool IsBusy { get; set; }
    }

    
    public class Component<T> where T: Material
    {
        
        public T Type { get; set; }

        
        public int Quantity { get; set; }
    }

    
    public class ToolsDescriptionNode
    {
       
        public ToolsDescriptionNode Left { get; set; }

        
        public ToolsDescriptionNode Right { get; set; }

       
        public ToolsDescription Value { get; set; }

    }

 
    public class ToolsDescriptionTree
    {
        public ToolsDescriptionNode Root { get; set; }

        
        public ToolsDescriptionNode Insert(ToolsDescriptionNode root, ToolsDescription v)
        {
            if (root == null)
            {
                root = new ToolsDescriptionNode();
                root.Value = v;

                Root = Root ?? root;
            }
            else if (v.Usefulness < root.Value.Usefulness)
            {
                root.Left = Insert(root.Left, v);
            }
            else
            {
                root.Right = Insert(root.Right, v);
            }

            return root;
        }



        public void Traverse(ToolsDescriptionNode root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.Left);
            Traverse(root.Right);
        }
    }
}

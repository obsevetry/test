using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190327_TreeDemo
{
    class Tree<TKey, TValue>
        where TKey : IComparable<TKey>
    {
        public const int DEFAULT_RESULT_LENGTH_TO_STRING = 1024;

        private Node _root = null;    // ссылка на корневой узел

        public void Add(TKey id, TValue val)
        {
            Add(ref _root, id, val);
        }

        private static void Add(ref Node root, TKey id, TValue val)
        {
            // 0. тривиальный случай
            if (root == null)
            {
                root = new Node(id, val);    // !!! Создание нового узла дерева
                return;
            }

            // 1. тривиальный случай обеспечивающий уникальность добавляемых значений
            //if (root.Info.CompareTo(info) == 0)
            //{
            //    throw new Exception("Не уникальное значение!!!");
            //}

            //
            if (root.Id.CompareTo(id) > 0)
            {
                Add(ref root._left, id, val);
            }
            else
            {
                Add(ref root._right, id, val);
            }
        }


        public bool TrySetValueByKey(TKey key, TValue val)
        {
            bool result = false;

            Node SearchRoot = SearchRootByKey(key, _root);

            if (SearchRoot != null)
            {
                SearchRoot.Value = val;

                result = true;
            }

            return result;
        }

        private static Node SearchRootByKey(TKey key, Node root)
        {
            if (root == null)
            {
                return null;
            }
            else if (root.Id.CompareTo(key) == 0)
            {
                if (root.Deleted)
                {
                    return null;
                }

                return root;
            }
            else if (root.Id.CompareTo(key) > 0)
            {
                return SearchRootByKey(key, root._left);
            }
            else
            {
                return SearchRootByKey(key, root._right);
            }
        }

        // HW !!!
        public TValue GetValueByKey(TKey key)
        {
            Node SearchRoot = SearchRootByKey(key, _root);

            if (SearchRoot == null)
            {
                return default(TValue);
            }

            return SearchRoot.Value;
        }

        public TValue this[TKey key]
        {
            get
            {
                return GetValueByKey(key);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(DEFAULT_RESULT_LENGTH_TO_STRING);
            
            ToString(_root, result);

            return result.ToString();
        }

        private static void ToString(Node root, StringBuilder bldr, int level = 0)
        {
            // 0. тривиальный случай
            if (root == null)
            {
                return;
            }

            // 1. обработка левого поддерева
            ToString(root._left, bldr, level + 1);

            if (!root.Deleted)
            {
                for (int i = 0; i < level; i++)
                {
                    bldr.Append('\t');
                }
                // 2. обработка текущего узла
                bldr.Append(root.Id);
                bldr.Append('\n');                
            }

            // 3. обработка правого поддерева
            ToString(root._right, bldr, level + 1);
        }

        //private static void ToString(Node root, StringBuilder bldr)
        //{
        //     0. тривиальный случай
        //    if (root == null)
        //    {
        //        return;
        //    }

        //     1. обработка левого поддерева
        //    ToString(root._left, bldr);

        //     2. обработка текущего узла
        //    bldr.AppendFormat("{0} ", root.Info);

        //     3. обработка правого поддерева
        //    ToString(root._right, bldr);
        //}

        private class Node
        {
            public Node(TKey id, TValue val)
            {
                Id = id;
                Value = val;
                Deleted = false;
            }

            public TKey Id { get; set; }    // информационная часть (Ключ)
            public TValue Value { get; set; }    // информационная часть (Значение)
            public bool Deleted { get; set; }    // признак удаленного узла
            public Node _left = null;    // ссылка на левое поддерево
            public Node _right = null;    // ссылка на правое поддерево
        }
    }
}

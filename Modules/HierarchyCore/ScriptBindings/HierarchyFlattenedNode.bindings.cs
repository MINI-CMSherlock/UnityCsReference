// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace Unity.Hierarchy
{
    /// <summary>
    /// Represents an hierarchy flattened node.
    /// </summary>
    [NativeType(Header = "Modules/HierarchyCore/Public/HierarchyFlattenedNode.h")]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct HierarchyFlattenedNode : IEquatable<HierarchyFlattenedNode>
    {
        static readonly HierarchyFlattenedNode s_Null;
        readonly HierarchyNode m_Node;
        readonly int m_ParentOffset;
        readonly int m_NextSiblingOffset;
        readonly int m_ChildCount;
        readonly int m_Depth;

        /// <summary>
        /// Represents an hierarchy flattened node that is null/invalid.
        /// </summary>
        public static ref readonly HierarchyFlattenedNode Null => ref s_Null;

        /// <summary>
        /// The hierarchy node referenced.
        /// </summary>
        public HierarchyNode Node => m_Node;

        /// <summary>
        /// The offset of the node's parent.
        /// </summary>
        public int ParentOffset => m_ParentOffset;

        /// <summary>
        /// The offset of the node's next sibling.
        /// </summary>
        public int NextSiblingOffset => m_NextSiblingOffset;

        /// <summary>
        /// The node's number of children.
        /// </summary>
        public int ChildCount => m_ChildCount;

        /// <summary>
        /// The node's depth.
        /// </summary>
        public int Depth => m_Depth;

        /// <summary>
        /// Create a Flattened Node.
        /// </summary>
        public HierarchyFlattenedNode()
        {
            m_Node = HierarchyNode.Null;
            m_ParentOffset = 0;
            m_NextSiblingOffset = 0;
            m_ChildCount = 0;
            m_Depth = 0;
        }

        [ExcludeFromDocs]
        public static bool operator ==(in HierarchyFlattenedNode lhs, in HierarchyFlattenedNode rhs) => lhs.Node == rhs.Node;
        [ExcludeFromDocs]
        public static bool operator !=(in HierarchyFlattenedNode lhs, in HierarchyFlattenedNode rhs) => !(lhs == rhs);
        [ExcludeFromDocs]
        public bool Equals(HierarchyFlattenedNode other) => other.Node == Node;
        [ExcludeFromDocs]
        public override string ToString() => $"{nameof(HierarchyFlattenedNode)}({(this == Null ? nameof(Null) : $"{Node.Id}:{Node.Version}")})";
        [ExcludeFromDocs]
        public override bool Equals(object obj) => obj is HierarchyFlattenedNode node && Equals(node);
        [ExcludeFromDocs]
        public override int GetHashCode() => Node.GetHashCode();
    }
}

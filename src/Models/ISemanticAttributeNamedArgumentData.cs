namespace Paraminter.Arguments.Semantic.Attributes.Constructor.Models;

using Microsoft.CodeAnalysis;

/// <summary>Represents semantic data about an attribute constructor argument.</summary>
public interface ISemanticAttributeNamedArgumentData
{
    /// <summary>The attribute constructor argument.</summary>
    public abstract TypedConstant Argument { get; }
}

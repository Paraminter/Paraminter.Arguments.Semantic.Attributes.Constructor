namespace Paraminter.Arguments.Semantic.Attributes.Constructor.Models;

using Microsoft.CodeAnalysis;

using Paraminter.Associators.Models;

/// <summary>Represents semantic data about an attribute constructor argument.</summary>
public interface ISemanticAttributeConstructorArgumentData
    : IArgumentData
{
    /// <summary>The attribute constructor argument.</summary>
    public abstract TypedConstant Argument { get; }
}

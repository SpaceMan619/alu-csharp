/// <summary>Describes the quality rating assigned to a dog.</summary>
public enum Rating
{
    /// <summary>A good rating.</summary>
    Good,

    /// <summary>A great rating.</summary>
    Great,

    /// <summary>An excellent rating.</summary>
    Excellent
}

/// <summary>Represents a dog and its owner information.</summary>
public struct Dog
{
    /// <summary>The dog's name.</summary>
    public string name;

    /// <summary>The dog's age.</summary>
    public float age;

    /// <summary>The dog's owner's name.</summary>
    public string owner;

    /// <summary>The dog's rating.</summary>
    public Rating rating;
}

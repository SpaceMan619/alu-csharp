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

    /// <summary>Initializes a dog with its identifying information.</summary>
    /// <param name="name">The dog's name.</param>
    /// <param name="age">The dog's age.</param>
    /// <param name="owner">The dog's owner's name.</param>
    /// <param name="rating">The dog's rating.</param>
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    /// <summary>Returns the dog's details as four labeled lines.</summary>
    /// <returns>The dog's name, age, owner, and rating.</returns>
    public override string ToString()
    {
        return $"Dog Name: {name}\n" +
            $"Age: {age}\n" +
            $"Owner: {owner}\n" +
            $"Rating: {rating}";
    }
}

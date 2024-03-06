# Guard clause library for DotNet written in C#

This package contains a custom class named `Guard` that implements the guard clause for DotNet applications.

## Current guard operations

Below you will find a list with the guard operations supported grouped by data type.

### Strings

- IsEmpty
- NotEmpty
- Length
- Contains
- NotContains
- StarsWith
- NotStartsWith
- EndsWith
- NotEndsWith

### IComparable

Now all types that implements the `IComparable` interface can be used in the following operations

- InRange
- IsLower
- IsLowerOrEquals
- IsGreater
- IsGreaterOrEquals
- NotContains

### Equatable

Now all types that implements the `IEquatable` interface can be used in the following operations

- IsEquals
- NotEquals

### Collections

Types that implements the `ICollection` interface can be used in the following operations

- Contains
- NotContains
- IsEmpty
- NotEmpty

### Boolean

Perform guard operations for `bool` types

- IsTrue
- IsFalse

### Regular Expressions

Given a regular expression, perform guard clause in a `string`

- Match
- NotMatch 

## Example



```cs
public class PaymentEntity
{
    public record CreditCard
    {
        public string CVV { get; set; }
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
    }

    public CreditCard Card { get; set; }
    public List<object> Cart { get; private set; }

    public PaymentEntity() 
    {
        Card = new CreditCard();
        Cart = new List<object>();
    }

    public void SetCreditCard(string owner, string number, string cvv)
    {
        Card.OwnerName = owner;
        Card.CardNumber = number;
        Card.CVV = cvv;
    }

    public void AddItem(string name)
    {
        Cart.Add(name);
    }
}
```

And now, let's apply the guard clause to check that parameters are in the expected format.

```cs
using Fitomad.Guard;

...

public void Buy(PaymentEntity entity)
{
    Guard.IsNotNull(entity); // Parameter is not null
    Guard.IsNotNull(entity.Card); // Credit card parameter is not null
    Guard.NotEmpty(entity.Cart); // There are items in the cart

    Guard.Length(entity.Card.CVV, stringLength: 3); // Card cvv number is 3 characters length
    Guard.Match(entity.Card.CVV, regularExpression: @"\d{3}"); // Card cvv is only digits
    Guard.Match(entity.Card.CardNumber, regulaExpression: @"\d{4}\s*\d{4}\s*\d{4}\s*\d{4}"); // Card number format
    Guard.NotEmpty(entity.Card.OwnerName); // Card owner name is filled

    ...
}
```

## Execute custom code if guard clause fails

Fitomad.Guard package allow developers to execute custom code in case a guard clause fails

```cs
Guard.NotEmpty(entity.Cart, perform: () => 
{
    Trace.WriteLine("The customer part is empty. No products found");
});
```

In the example above, if guard clause fails the `Trace.WriteLine` code is executed **before** an exception will be throwed. 

## Custom Exceptions

You can also throw your own exceptions in case the guard clause fails.

```cs
Guard.NotEmpty(entity.Cart, perform: () => 
{
    throw new BuyUseCaseException("The customer part is empty. No products found");
});
```
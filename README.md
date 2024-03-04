# Guard clause library for DotNet written in C#

This package contains a custom class named `Guard` that implements the guard clause for DotNet applications.


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

    Guard.Lenght(entity.Card.CVV, stringLenght: 3); // Card cvv number is 3 characters length
    Guard.Match(entity.Card.CVV, regularExpression: @"\d{3}"); // Card cvv is only digits
    Guard.Match(entity.Card.CardNumber, regulaExpression: @"\d{4}\s*\d{4}\s*\d{4}\s*\d{4}"); // Card number format
    Guard.NotEmpty(entity.Card.OwnerName); // Card owner name is filled

    ...
}
```